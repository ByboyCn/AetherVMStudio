# genwinlib.ps1 — 从 DLL 导出表生成 MSVC 导入库
# 用法: .\genwinlib.ps1 -Dll <AetherVM.dll 路径> -Dumpbin <dumpbin.exe> -Lib <lib.exe> -Out <AetherVM.lib>
param(
    [Parameter(Mandatory)][string]$Dll,
    [Parameter(Mandatory)][string]$Dumpbin,
    [Parameter(Mandatory)][string]$Lib,
    [Parameter(Mandatory)][string]$Out
)

$exports = & $Dumpbin /EXPORTS $Dll 2>$null | ForEach-Object {
    if ($_ -match '^\s+[0-9]+\s+[0-9A-Fa-f]+\s+[0-9A-Fa-f]+\s+(\S+)\s*$') { $Matches[1] }
}
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
