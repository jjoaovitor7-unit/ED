using System;
using System.Collections;

public class Vetor<T> : IVetor<T> {
    private int _Tamanho { set; get; }
    private T[] vetor;

    public Vetor() {
    }

    public Vetor(int _tam) {
        this.vetor = new T[_tam];
    }

    public void adiciona(T elemento, int posicao) {
        if (posicao < 0) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }
        else {
            if (tamanho() == this.vetor.Length) {
                redimensionar();
            }

            if (this.vetor[posicao] == null) {
                this.vetor[posicao] = elemento;
                this._Tamanho++;
            }
            else {
                this.vetor[posicao+=1] = this.vetor[posicao];

                int i=posicao+1;

                IEnumerator it = this.vetor.GetEnumerator();

                while (it.MoveNext()) {
                    while (i >= posicao) {
                        this.vetor[i+1] = this.vetor[i];
                        i--;
                    }
                }

                this.vetor[posicao] = elemento;
                this._Tamanho++;
            }
        }
    }

    public void adicionaInicio(T elemento) {
        if (tamanho() == this.vetor.Length) {
            redimensionar();
        }

        if (this.vetor[0] == null) {
            this.vetor[0] = elemento;
        }
        else {
            IEnumerator it = this.vetor.GetEnumerator();

            int i=tamanho();
            while (it.MoveNext()) {
                while (i > -1) {
                    if (i >= 0) {
                        this.vetor[i+1] = this.vetor[i];
                    }

                    if (i == 0) {
                        this.vetor[0] = elemento;
                    }
                    i--;
                }
            }
            this._Tamanho ++;
        }
    }

    public void adicionaFim(T elemento) {
        if (tamanho() == this.vetor.Length) {
            redimensionar();
        }

        this.vetor[tamanho()] = elemento;
        this._Tamanho++;
    }

    public bool existeDado(int posicao) {
        if (this.vetor[posicao] != null) {
            return true;
        }
        else {
            return false;
        }
    }

    public T recuperar(int posicao) {
        if (vazio() || this.vetor[posicao] == null || posicao < 0) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }
        else {
            return this.vetor[posicao];
        }
    }

    public bool vazio() {
        if (this._Tamanho == 0) {
            return true;
        }
        else {
            return false;
        }
    }

    public void remove(int posicao) {
        if (vazio() || this.vetor[posicao] == null || posicao < 0) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }

        else {
            this.vetor[posicao] = default(T);
            this._Tamanho--;
            IEnumerator it = this.vetor.GetEnumerator();

            int i=posicao;
            while (it.MoveNext()) {
                while (i < tamanho()) {
                    this.vetor[i] = vetor[i+1];
                    i++;
                }
            }
        }
    }

    public void removeInicio() {
        if (vazio() || this.vetor[0] == null) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }

        else {
            this.vetor[0] = default(T);

            IEnumerator it = this.vetor.GetEnumerator();

            int i=0;
            while (it.MoveNext()) {
                while (i < tamanho()) {
                    vetor[i] = vetor[i+1];
                    i++;
                }
            }
            
            this._Tamanho--;
        }
    }

    public void removeFim() {
        if (vazio() || this.vetor[tamanho()-1] == null) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }
        else {
            this.vetor[tamanho()] = default(T);
            this._Tamanho--;
        }
    }

    public int tamanho() {
        return this._Tamanho;
    }

    public void limpar() {
        IEnumerator it = this.vetor.GetEnumerator();

        int i=0;
        while (it.MoveNext()) {
            this.vetor[i] = default(T);
            i++;
        }

        this._Tamanho = 0;
    }

    public void redimensionar() {
        T[] _vetor = new T[this._Tamanho*2];

        IEnumerator it = this.vetor.GetEnumerator();

        int i=0;
        while (it.MoveNext()) {
            while (i < this.vetor.Length) {
                _vetor[i] = this.vetor[i];
                i++;
            }
        }

        this.vetor = _vetor;
    }
}
