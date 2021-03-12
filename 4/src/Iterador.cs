namespace src {
    public class Iterador<T> {
        private Celula atual;

        public Iterador(Celula atual) {
            this.atual = atual;
        }

        public bool hasNext() {
            if (atual != null) {
                return true;
            }
            else {
                return false;
            }
        }

        public object next() {
            T elemento = (T) atual.Elemento;
            atual = atual.Proxima;
            return elemento;
        }

        public Celula current() {
            return atual;
        }
    }
}
