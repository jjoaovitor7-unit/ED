namespace src {
    public class Aluno {
        public string Nome { set; get; }
        public int Idade {set; get; }

        public Aluno() {

        }

        public Aluno(string _nome, int _idade) {
            this.Nome = _nome;
            this.Idade = _idade;
        }

        public bool equals(object o) {
            Aluno outro = (Aluno)o;
            return this.Nome.Equals(outro.Nome);
        }
    }
}