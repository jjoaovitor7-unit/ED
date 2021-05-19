namespace src {
    public class Celula {
        public Celula Anterior { set; get; }
        public Celula Proxima { set; get; }
        public object Elemento { set; get; }

        public Celula(object _elemento, Celula _proxima, Celula _anterior) {
            this.Proxima = _proxima;
            this.Elemento = _elemento;
            this.Anterior = _anterior;
        }

        public Celula(object _elemento) {
            this.Elemento = _elemento;
        }
    }
}
