using System;

namespace src {
    public class ListaDuplamenteEncadeadaComNoCabeca<T> : IListaDuplamenteEncadeadaComNoCabeca<T> {
        private Celula noCabeca;
        private int Tamanho { set; get; }

        public ListaDuplamenteEncadeadaComNoCabeca() {
            this.noCabeca = new Celula(null, null, null);
            this.Tamanho = 0;
        }

        private Celula pegaCelula(int posicao) {
            Celula atual = this.noCabeca.Proxima;
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
                Celula atual = this.noCabeca.Proxima;
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
                this.noCabeca.Proxima = newCelula;
                this.noCabeca.Anterior = newCelula;
                this.Tamanho++;
            }
            else {
                Celula newCelula = new Celula(elemento);
                newCelula.Proxima = this.noCabeca.Proxima;
                this.noCabeca.Proxima.Anterior = newCelula;
                this.noCabeca.Proxima = newCelula;
                this.Tamanho++;
            }
        }

        public void adicionaFim(T elemento) {            
            if (this.Tamanho == 0) {
               adicionaInicio(elemento);
            }
            else {
                Celula newCelula = new Celula(elemento, null, this.noCabeca.Anterior);
                this.noCabeca.Anterior.Proxima = newCelula;
                this.noCabeca.Anterior = newCelula;
                this.Tamanho++;
            }
        }

        public bool existeDado(T elemento) {
            Celula atual = this.noCabeca.Proxima;
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
                Celula atual = this.noCabeca.Proxima;
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

            else if (this.noCabeca.Proxima == this.noCabeca.Anterior) {
                this.noCabeca.Proxima = null;
                this.noCabeca.Anterior = null;
                this.Tamanho--;
            }

            else if (posicao == 0) {
                this.removeInicio();
            }

            else {
                Celula atual = this.noCabeca.Proxima;
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

            else if (this.noCabeca.Proxima == this.noCabeca.Anterior) {
                this.noCabeca.Proxima = null;
                this.noCabeca.Anterior = null;
                this.Tamanho--;
            }
            else {
                this.noCabeca.Proxima = this.noCabeca.Proxima.Proxima;
                this.noCabeca.Proxima.Anterior = null;
                this.Tamanho--;
            }
        }

        public void removeFim() {
            if (this.Tamanho == 0) {
                throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
            }

            else if (this.noCabeca.Proxima == this.noCabeca.Anterior) {
                this.noCabeca.Proxima = null;
                this.noCabeca.Anterior = null;
                this.Tamanho--;
            }

            else {
                this.Tamanho--;
                Celula atual = this.noCabeca.Anterior;
                this.noCabeca.Proxima = atual.Anterior;
            }
        }

        public int tamanho() {
            return this.Tamanho;
        }

        public void limpa() {
            this.noCabeca.Proxima = null;
            this.noCabeca.Anterior = null;
            GC.Collect();
            this.Tamanho = 0;
        }
    }
}
