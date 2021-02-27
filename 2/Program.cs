using System;
using src;

class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 12);
        Aluno a2 = new Aluno("A2", 32);
        Aluno a3 = new Aluno("A3", 42);

        ListaEncadeada<Aluno> lista = new ListaEncadeada<Aluno>();
        lista.adicionaInicio(a1);
        lista.adicionaInicio(a3);
        lista.adicionaInicio(a2);
        lista.adiciona(a1, 0);
        Console.WriteLine(lista.tamanho());
        Console.WriteLine(lista.recupera(3).Nome);
    }
}