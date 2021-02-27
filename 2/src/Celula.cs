namespace src {
    public class Celula {
        public Celula Proxima { set; get; }
        public object Elemento { set; get; }

        public Celula(object _elemento, Celula _proxima) {
            this.Proxima = _proxima;
            this.Elemento = _elemento;
        }

        public Celula(object _elemento) {
            this.Elemento = _elemento;
        }
    }
}