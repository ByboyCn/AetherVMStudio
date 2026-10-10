# genwinlib.ps1 — 从 DLL 导出表生成 MSVC 导入库
# 用法: .\genwinlib.ps1 -Dll <AetherVM.dll 路径> -Dumpbin <dumpbin.exe> -Lib <lib.exe> -Out <AetherVM.lib>
param(
    [Parameter(Mandatory)][string]$Dll,
    [Parameter(Mandatory)][string]$Dumpbin,
    [Parameter(Mandatory)][string]$Lib,
    [Parameter(Mandatory)][string]$Out
)

# dumpbin 对超长 C++ 修饰名会折行输出:先收集,再把续行拼接回去
$exports = New-Object System.Collections.Generic.List[string]
$cur = $null
foreach ($line in (& $Dumpbin /EXPORTS $Dll 2>$null)) {
    if ($line -match '^\s*[0-9]+\s+[0-9A-Fa-f]+\s+[0-9A-Fa-f]+\s+(\S.*)$') {
        if ($cur) { $exports.Add($cur) }
        $cur = $Matches[1].TrimEnd()
    }
    elseif ($cur -and $line -match '^\s*(\S.*)$') {
        $cur += $Matches[1].Trim()
    }
}
if ($cur) { $exports.Add($cur) }
$exports = @($exports | Where-Object { $_ })
if (-not $exports -or $exports.Count -eq 0) {
    throw "未能从 $Dll 解析出导出符号"
}
Write-Host "解析到 $($exports.Count) 个导出符号"

$def = Join-Path $env:TEMP "AetherVM.def"
"LIBRARY AetherVM`nEXPORTS`n" + ($exports -join "`n") | Set-Content $def -Encoding ASCII

$outDir = Split-Path $Out -Parent
if ($outDir -and -not (Test-Path $outDir)) { New-Item -ItemType Directory -Force $outDir | Out-Null }

& $Lib /NOLOGO /DEF:$def /MACHINE:X64 /OUT:$Out
if ($LASTEXITCODE -ne 0) { throw "lib.exe 生成导入库失败" }
Write-Host "已生成导入库: $Out"
