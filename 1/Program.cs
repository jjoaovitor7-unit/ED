class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno("A1", 42);
        Aluno a2 = new Aluno("A2", 42);
        Aluno a3 = new Aluno("A3", 42);
        Aluno a4 = new Aluno("A4", 42);
        Aluno a5 = new Aluno("A5", 42);
        Aluno a6 = new Aluno("A6", 42);

        Vetor<Aluno> v = new Vetor<Aluno>(3);
        v.adiciona(a1, 0);
        v.adiciona(a2, 1);
        v.adiciona(a3, 2);
        v.adiciona(a4, 3);
        v.adiciona(a5, 4);
        v.adiciona(a6, 5);
        v.limpar();

        v.adiciona(a1, 0);
        v.adiciona(a2, 1);
        v.adicionaInicio(a3);
        v.adicionaFim(a4);
        v.remove(0);
    }
}