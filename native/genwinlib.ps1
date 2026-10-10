# genwinlib.ps1 - Generate MSVC import library from DLL export table
# Usage: .\genwinlib.ps1 -Dll <AetherVM.dll> -Dumpbin <dumpbin.exe> -Lib <lib.exe> -Out <AetherVM.lib>
param(
    [Parameter(Mandatory)][string]$Dll,
    [Parameter(Mandatory)][string]$Dumpbin,
    [Parameter(Mandatory)][string]$Lib,
    [Parameter(Mandatory)][string]$Out,
    [string]$LibName = [IO.Path]::GetFileNameWithoutExtension($Dll)
)

$exports = New-Object System.Collections.Generic.List[string]
$cur = $null
foreach ($line in (& $Dumpbin /EXPORTS $Dll 2>$null)) {
    if ($line -match '^\s*Summary\s*$') { break }   # 末尾的段摘要不是导出符号
    if ($line -match '^\s*[0-9]+\s+[0-9A-Fa-f]+\s+[0-9A-Fa-f]+\s+(\S.*)$') {
        if ($cur) { $exports.Add($cur) }
        $cur = $Matches[1].TrimEnd()
    }
    elseif ($cur -and $line -match '^\s*(\S.*)$') {
        $cur += $Matches[1].Trim()
    }
}
if ($cur) { $exports.Add($cur) }
# 只保留 C++ 修饰函数符号(以 ? 开头),跳过链接器生成的 .dataXXXX 数据导出
$exports = @($exports | Where-Object { $_ -match '^\?' })

if ($exports.Count -eq 0) {
    throw "Failed to parse exports from $Dll"
}
Write-Host "Parsed $($exports.Count) export symbols"

$def = Join-Path $env:TEMP "AetherVM.def"
"LIBRARY $LibName`nEXPORTS`n" + ($exports -join "`n") | Set-Content $def -Encoding ASCII

$outDir = Split-Path $Out -Parent
if ($outDir -and -not (Test-Path $outDir)) { New-Item -ItemType Directory -Force $outDir | Out-Null }

& $Lib /NOLOGO /DEF:$def /MACHINE:X64 /OUT:$Out
if ($LASTEXITCODE -ne 0) { throw "lib.exe failed to create import library" }
Write-Host "Import library created: $Out"
