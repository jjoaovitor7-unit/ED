using System;
using src;

class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 12);
        Aluno a2 = new Aluno("A2", 32);
        Aluno a3 = new Aluno("A3", 42);

        Pilha<Aluno> pilha = new Pilha<Aluno>();
        pilha.push(a2);
        pilha.push(a1);
        pilha.push(a3);
        pilha.push(a1);
        pilha.pop();

        Console.WriteLine($"Minha pilha: {pilha.tamanho()}");
        Console.Write(pilha.top().Nome);
        Console.WriteLine();
    }
}