@SET VAR=bin.exe
@IF EXIST %VAR% DEL %VAR%
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc /nologo /target:winexe /win32icon:icon.ico /out:%VAR% *.cs
PAUSE