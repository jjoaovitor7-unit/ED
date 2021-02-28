using System;
using src;

class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 12);
        Aluno a2 = new Aluno("A2", 32);
        Aluno a3 = new Aluno("A3", 42);

        ListaEncadeada<Aluno> lista = new ListaEncadeada<Aluno>();
        lista.adicionaInicio(a2); // a2
        lista.adicionaInicio(a3); // a3 a2
        lista.adicionaInicio(a2); // a2 a3 a2
        lista.adiciona(a2, 1); // a2 a2 a3 a2
        lista.adiciona(a1, 1); // a2 a1 a2 a3 a2
        lista.adiciona(a1, 0); // a1 a2 a1 a2 a3 a2
        lista.adiciona(a1, 1); // a1 a1 a2 a1 a2 a3 a2

        Console.WriteLine($"Minha lista: {lista.tamanho()}");
        for (int i=0; i < lista.tamanho(); i++) {
            Console.Write(lista.recupera(i).Nome + " ");
        }
        Console.WriteLine();
    }
}