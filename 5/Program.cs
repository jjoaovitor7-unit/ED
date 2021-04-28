using System;
using src;

class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 12);
        Aluno a2 = new Aluno("A2", 32);
        Aluno a3 = new Aluno("A3", 42);

        Fila<Aluno> fila = new Fila<Aluno>();
        fila.inserir(a2);
        fila.inserir(a1);
        fila.inserir(a3);
        fila.inserir(a1);

        Console.WriteLine($"Minha fila: {fila.tamanho()}");
        Console.Write(fila.recuperar().Nome);
        Console.WriteLine();
    }
}