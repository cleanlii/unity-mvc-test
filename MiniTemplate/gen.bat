set WORKSPACE=..
set LUBAN_DLL=%WORKSPACE%\Tools\Luban\Luban.dll
set CONF_ROOT=.

dotnet %LUBAN_DLL% ^
    -t all ^
    -c cs-simple-json ^
    -d json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=D:\Code\ProjectPackage\Assets\Plugins\Luban\GenCode ^
    -x outputDataDir=D:\Code\ProjectPackage\Assets\Plugins\Luban\GenData

pause