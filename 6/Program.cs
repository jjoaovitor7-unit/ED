using System;
using src;

class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 12);
        Aluno a2 = new Aluno("A2", 32);
        Aluno a3 = new Aluno("A3", 42);

        Deque<Aluno> deque = new Deque<Aluno>();
        deque.inserirNoInicio(a1);
        deque.inserirNoInicio(a2);
        deque.inserirNoFim(a3);

        Console.WriteLine($"Minha deque: {deque.tamanho()}");
        Console.Write(deque.recuperarInicio().Nome + " " + deque.recuperarFim().Nome);
        Console.WriteLine();
    }
}