# 3

Considerando que os comandos serão executados na raiz da pasta 3 (ED/3/).

Para compilar o programa:
* csc /target:exe /out:3.exe Program.cs src/Aluno.cs src/Celula.cs src/ListaDuplamenteEncadeada.cs src/IListaDuplamenteEncadeada.cs src/Iterador.cs

Para executar o programa:
* mono 3.exe

Para executar os testes:
* dotnet test src/ListaDuplamenteEncadeadaTest.csproj