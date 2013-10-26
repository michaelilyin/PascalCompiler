@echo off

%~d0
cd "%~dp0"

set JAVA_HOME=C:\Program Files\Java\jdk1.6.0
set GRAPHVIZ_HOME=X:\Graphviz2.26.3

set ANTLRWORKS_JAR=.\antlrworks-1.4.jar


set PATH=%PATH%;%GRAPHVIZ_HOME%\bin

set JAVA="%JAVA_HOME%\bin\javaw"
rem set JAVAC="%JAVA_HOME%\bin\javac"

set ANTLRWORKS=%JAVA% -classpath .;%CLASSPATH%;%ANTLRWORKS_JAR% org.antlr.works.IDE



start "AntlrWorks" /b %ANTLRWORKS%
