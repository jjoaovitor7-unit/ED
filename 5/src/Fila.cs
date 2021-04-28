using System;

namespace src {
    public class Fila<T> : IFila<T> {
        private Celula primeiro;
        private Celula ultimo;
        private int Tamanho { set; get; }

        public Fila() {
            this.primeiro = null;
            this.ultimo = null;
            this.Tamanho = 0;
        }

        public void inserir(T elemento) {
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

        public T recuperar() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                return (T)(object) this.primeiro.Elemento;
            }
        }

        public void alterar(T elemento) {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                this.primeiro.Elemento = elemento;
            }
        }

        public void remover() {
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
