using System;
using src;

class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 12);
        Aluno a2 = new Aluno("A2", 32);
        Aluno a3 = new Aluno("A3", 42);
        Aluno a4 = new Aluno("A4", 11);
        Aluno a5 = new Aluno("A5", 23);
        Aluno a6 = new Aluno("A6", 52);

        Vetor<Aluno> v = new Vetor<Aluno>(3);
        v.adiciona(a1, 0);
        v.adiciona(a2, 1);
        v.adiciona(a3, 2);
        v.adiciona(a4, 3);
        v.adiciona(a5, 4);
        v.adiciona(a6, 5);

        Console.WriteLine("Elementos do Vetor: ");
        for (int i=0; i < v.tamanho(); i++) {
            Console.WriteLine($"{v.recuperar(i).Nome} : {v.recuperar(i).Idade}");
        }
    }
}