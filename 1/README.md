# 1

Considerando que os comandos serão executados na raiz da pasta 1 (ED/1/).

Para compilar o programa:
* csc /target:exe /out:1.exe Program.cs src/Aluno.cs src/IVetor.cs src/Vetor.cs

Para executar o programa:
* mono 1.exe

Para executar os testes:
* dotnet test src/VetorTest.csproj