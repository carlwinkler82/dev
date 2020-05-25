@echo off

set _roslynatorPath=..\..\Roslynator\src
set _visualStudioPath=C:\Program Files\Microsoft Visual Studio\2019\Community
set _msbuildPath=%_visualStudioPath%\MSBuild\Current\Bin

"%_msbuildPath%\msbuild" "%_roslynatorPath%\CommandLine.sln" /t:Build /p:Configuration=Release /v:m /m

"%_roslynatorPath%\CommandLine\bin\Release\net472\roslynator" fix "..\Snippetica.sln" ^
 --msbuild-path "%_msbuildPath%" ^
 --analyzer-assemblies ^
  "%_roslynatorPath%\Analyzers.CodeFixes\bin\Release\netstandard1.3\Roslynator.CSharp.Analyzers.dll" ^
  "%_roslynatorPath%\Analyzers.CodeFixes\bin\Release\netstandard1.3\Roslynator.CSharp.Analyzers.CodeFixes.dll" ^
  "%_roslynatorPath%\Formatting.Analyzers.CodeFixes\bin\Release\netstandard1.3\Roslynator.Formatting.Analyzers.dll" ^
  "%_roslynatorPath%\Formatting.Analyzers.CodeFixes\bin\Release\netstandard1.3\Roslynator.Formatting.Analyzers.CodeFixes.dll" ^
 --ignored-projects Snippetica.Test ^
 --format ^
 --verbosity d ^
 --file-log "roslynator.log" ^
 --file-log-verbosity diag ^
 --diagnostic-fix-map "RCS1155=Roslynator.RCS1155.OrdinalIgnoreCase" ^
 --file-banner " Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information."

pause
