# 2

Considerando que os comandos serão executados na raiz da pasta 2 (ED/2/).

Para compilar o programa:
* csc /target:exe /out:2.exe Program.cs src/Aluno.cs src/Celula.cs src/ListaEncadeada.cs src/IListaEncadeada.cs src/Iterador.cs

Para executar o programa:
* mono 2.exe

Para executar os testes:
* dotnet test src/ListaEncadeadaTest.csproj