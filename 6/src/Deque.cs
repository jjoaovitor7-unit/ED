using System;

namespace src {
    public class Deque<T> : IDeque<T> {
        private Celula primeiro;
        private Celula ultimo;
        private int Tamanho { set; get; }

        public Deque() {
            this.primeiro = null;
            this.ultimo = null;
            this.Tamanho = 0;
        }

        public void inserirNoInicio (T elemento) {
            if (this.Tamanho == 0) {
                Celula newCelula = new Celula(elemento);
                this.primeiro = newCelula;
                this.ultimo = newCelula;
                this.Tamanho++;
            }
            else {
                Celula newCelula = new Celula(elemento);
                newCelula.Proxima = this.primeiro;
                this.primeiro.Anterior = newCelula;
                this.primeiro = newCelula;
                this.Tamanho++;
            }
        }

        public void inserirNoFim(T elemento) {
            if (this.Tamanho == 0) {
                Celula newCelula = new Celula(elemento);
                this.primeiro = newCelula;
                this.ultimo = newCelula;
                this.Tamanho++;
            }
            else {
                Celula newCelula = new Celula(elemento, null, this.ultimo);
                this.ultimo.Proxima = newCelula;
                this.ultimo = newCelula;
                this.Tamanho++;
            }
        }

        public bool existeDado(T elemento) {
            Celula atual = this.primeiro;
            bool cond = false;
            for (int i=0; i < this.Tamanho; i++) {
                if (atual.Elemento.Equals(elemento)) {
                    cond = true;
                    break;
                }

                if (atual.Proxima != null) {
                    atual = atual.Proxima;
                }
                else {
                    break;
                }
            }
            return cond;
        }

        public bool isEmpty() {
            if (this.Tamanho == 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public T recuperarInicio() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                return (T)(object) this.primeiro.Elemento;
            }
        }

        public T recuperarFim() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                return (T)(object) this.ultimo.Elemento;
            }
        }

        public void alterarInicio(T elemento) {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                this.primeiro.Elemento = elemento;
            }
        }

        public void alterarFim(T elemento) {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                this.ultimo.Elemento = elemento;
            }
        }

        public void removerInicio() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }

            else if (this.primeiro == this.ultimo) {
                this.primeiro = null;
                this.ultimo = null;
                this.Tamanho--;
            }
            else {
                this.primeiro = this.primeiro.Proxima;
                this.primeiro.Anterior = null;
                this.Tamanho--;
            }
        }

        public void removerFim() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }

            else if (this.primeiro == this.ultimo) {
                this.primeiro = null;
                this.ultimo = null;
                this.Tamanho--;
            }

            else {
                this.Tamanho--;
                Celula atual = this.ultimo;
                this.ultimo = atual.Anterior;
            }
        }

        public int tamanho() {
            return this.Tamanho;
        }

        public void limpa() {
            this.primeiro = null;
            this.ultimo = null;
            GC.Collect();
            this.Tamanho = 0;
        }
    }
}
