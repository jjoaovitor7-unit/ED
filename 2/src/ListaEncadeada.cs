using System;

namespace src {
    public class ListaEncadeada<T> : IListaEncadeada<T> {
        private Celula primeiro;
        private Celula ultimo;
        private int Tamanho { set; get; }

        public ListaEncadeada() {
            this.primeiro = null;
            this.ultimo = null;
            this.Tamanho = 0;
        }

        public void adiciona(T elemento, int posicao) {
            if (posicao == 0) {
                adicionaInicio(elemento);
            }

            else if (posicao == this.Tamanho) {
                adicionaFim(elemento);
            }
            
            else {
                Celula atual = this.primeiro;
                for (int i=0; i < this.Tamanho; i++) {
                    object aux = atual.Elemento;
                    atual.Elemento = elemento;
                    atual.Proxima.Elemento = aux;
                }
                this.Tamanho++;
            }
        }

        public void adicionaInicio(T elemento) {
            Celula newCelula = new Celula(elemento);
            if (this.Tamanho == 0) {
                this.primeiro = newCelula;
                this.ultimo = newCelula;
                this.Tamanho++;
            }
            else {
                newCelula.Proxima = this.primeiro;
                this.primeiro = newCelula;
                this.Tamanho++;
            }
        }

        public void adicionaFim(T elemento) {
            Celula newCelula = new Celula(elemento);
            
            if (this.Tamanho == 0) {
                this.primeiro = this.ultimo;
                this.ultimo = newCelula;
                this.Tamanho++;
            }
            else {
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

        public T recupera(int posicao) {
            if (this.Tamanho == 0 || posicao < 0 || posicao >= this.Tamanho) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                Celula atual = this.primeiro;
                for (int i=0; i < posicao; i++) {
                    if (atual.Proxima != null) {
                        atual = atual.Proxima;
                    }                
                }
                return (T)(object) atual.Elemento;
            }
        }

        public void remove(int posicao) {
            if (this.Tamanho == 0 || posicao < 0 || posicao >= this.Tamanho) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }

            else if (this.primeiro == this.ultimo) {
                this.primeiro = null;
                this.ultimo = null;
                this.Tamanho--;
            }

            else {
                Celula atual = this.primeiro;
                for (int i=0; i < this.Tamanho; i++) {
                    atual.Proxima = atual.Proxima.Proxima;
                    if (i == (posicao-1)) {
                        this.Tamanho--;
                        break;
                    }
                }
            }
        }

        public void removeInicio() {
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
                this.Tamanho--;
            }
        }

        public void removeFim() {
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

                Celula atual = this.primeiro;

                for (int i=0; i != this.Tamanho-1; i++) {
                    atual = atual.Proxima;
                    this.ultimo = atual;
                }
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