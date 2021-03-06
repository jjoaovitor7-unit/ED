using System;

namespace src {
    public class ListaDuplamenteEncadeada<T> : IListaDuplamenteEncadeada<T> {
        private Celula primeiro;
        private Celula ultimo;
        private int Tamanho { set; get; }

        public ListaDuplamenteEncadeada() {
            this.primeiro = null;
            this.ultimo = null;
            this.Tamanho = 0;
        }

        private Celula pegaCelula(int posicao) {
            Celula atual = this.primeiro;
            Iterador<T> it = new Iterador<T>(atual);
            while (it.hasNext()) {
                for (int i=0; i <= posicao; i++) {
                    atual = atual.Proxima;
                }
                break;
                it.next();
            }
            
            return atual;
        }

        public void adiciona(T elemento, int posicao) {
            if (posicao < 0 || posicao > this.Tamanho) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }

            else if (posicao == 0 || this.Tamanho == 0) {
                adicionaInicio(elemento);
            }

            else if (posicao == this.Tamanho) {
                adicionaFim(elemento);
            }

            else {
                Celula atual = this.primeiro;
                Celula newCelula = new Celula(elemento);
                Iterador<T> it = new Iterador<T>(atual);
                while (it.hasNext()) {
                    for (int i=0; i < posicao; i++) {
                        atual = atual.Proxima.Anterior;
                        if (i == posicao-1) {
                            if (atual != null) {
                                newCelula.Proxima = atual.Proxima;
                                atual.Proxima = newCelula;
                            }
                        }
                    }
                    break;
                    it.next();
                }
                this.Tamanho++;
            }
        }

        public void adicionaInicio(T elemento) {
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

        public void adicionaFim(T elemento) {            
            if (this.Tamanho == 0) {
               adicionaInicio(elemento);
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
            Iterador<T> it = new Iterador<T>(atual);
            while (it.hasNext()) {
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
                break;
                it.next();
            }
            return cond;
        }

        public T recupera(int posicao) {
            if (this.Tamanho == 0 || posicao < 0 || posicao >= this.Tamanho) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }
            else {
                Celula atual = this.primeiro;
                Iterador<T> it = new Iterador<T>(atual);
                while (it.hasNext()) {
                    for (int i=0; i < posicao; i++) {
                        if (atual.Proxima != null) {
                            atual = atual.Proxima;
                        }
                    }
                    break;
                    it.next();
                }
                return (T)(object) atual.Elemento;
            }
        }

        public void remove(int posicao) {
            if (this.Tamanho == 0 || posicao < 0 || posicao > this.Tamanho) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }

            else if (this.primeiro == this.ultimo) {
                this.primeiro = null;
                this.ultimo = null;
                this.Tamanho--;
            }

            else if (posicao == 0) {
                this.removeInicio();
            }

            else {
                Celula atual = this.primeiro;
                Iterador<T> it = new Iterador<T>(atual);
                while (it.hasNext()) {
                    for (int i=0; i != posicao-1; i++) {
                        atual = atual.Proxima;
                    }
                    if (atual != null) {
                        atual.Anterior = atual.Proxima;
                        atual.Proxima = atual.Anterior.Proxima;
                        atual = atual.Anterior.Proxima;
                    }
                    break;
                    it.next();
                }
                this.Tamanho--;
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
                this.primeiro.Anterior = null;
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
