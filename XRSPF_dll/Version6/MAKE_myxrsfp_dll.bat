rem
rem For run on dev system
rem Creates the myxrsfp.dll to be included in the XactControl project 
rem the dll allows mananaged C# code to call legacy C++ COM interface
rem functions
rem
c:

cd\
rem cd "program files\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 tools"
cd "Program Files\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools"

dir myxrsfp.dll
pause

tlbimp.exe "c:\crossroads scientific\XRS-FP\xrs-fp.exe" /out:myxrsfp.dll

dir myxrsfp.dll

pause

copy myxrsfp.dll c:\dev\Gen2\Rev1\trunk\xrsfp_dll\version6\myxrsfp.dll

cd\
cd dev\Gen2\Rev1\trunk\xrsfp_dll\version6\

dir myxrsfp.dll

pause