using System;

namespace src {
    public class Pilha<T> : IPilha<T> {
        private Celula topo;
        private int Tamanho { set; get; }

        public Pilha() {
            this.topo = null;
            this.Tamanho = 0;
        }
        
        public void push(T elemento) {
            Celula newCelula = new Celula(elemento);
            if (this.Tamanho == 0) {
                this.topo = newCelula;
                this.Tamanho++;
            }
            else {
                newCelula.Proxima = this.topo;
                this.topo = newCelula;
                this.Tamanho++;
            }
        }

        public bool existeDado(T elemento) {
            Celula atual = this.topo;
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

        public T top() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                return (T)(object) this.topo.Elemento;
            }
        }

        public void pull(T elemento) {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                this.topo.Elemento = elemento;
            }
        }

        public void pop() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                this.topo = this.topo.Proxima;
                this.topo.Anterior = null;
                this.Tamanho--;
            }
        }

        public int tamanho() {
            return this.Tamanho;
        }

        public void limpa() {
            this.topo = null;
            GC.Collect();
            this.Tamanho = 0;
        }
    }
}