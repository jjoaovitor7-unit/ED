# 1

Considerando que os comandos serão executados na raiz da pasta 1 (ED/1/).

Para compilar o programa:
* csc /target:exe /out:1.exe 1/Program.cs 1/src/Aluno.cs 1/src/IVetor.cs 1/src/Vetor.cs

Para executar o programa:
* mono 1.exe

Para executar os testes:
    dotnet test VetorTest.csproj