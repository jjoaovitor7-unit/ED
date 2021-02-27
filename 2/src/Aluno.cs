namespace src {
    public class Aluno {
        public string Nome { set; get; }
        public int Idade { set; get; }

        public Aluno() {
            this.Nome = " ";
            this.Idade = 0;
        }

        public Aluno(string _nome, int _idade) {
            this.Nome = _nome;
            this.Idade = _idade;
        }
    }
}