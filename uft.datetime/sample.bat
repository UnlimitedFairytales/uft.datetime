@echo off
for /f "delims=" %%i in ('uft.datetime.exe -6 -5 -4 -3 -20 -10') do (set "output=%%i")
echo %output%
pause