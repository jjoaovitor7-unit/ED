using System;
using System.Collections;

public class Vetor<T> : IVetor<T> where T : Aluno {
    private int _Tamanho { set; get; }
    private T[] vetor;

    public Vetor() {
    }

    public Vetor(int _tam) {
        this.vetor = new T[_tam];
    }

    public void adiciona(T elemento, int posicao) {
        if (tamanho() == this.vetor.Length) {
            redimensionar();
        }

        if (this.vetor[posicao] == null) {
            this.vetor[posicao] = elemento;
            this._Tamanho++;
        }

        else {
            this.vetor[posicao+=1] = this.vetor[posicao];
            for (int i=posicao+1; i >= posicao; i--) {
                this.vetor[i+1] = this.vetor[i];
            }

            this.vetor[posicao] = elemento;
            this._Tamanho++;
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
            for (int i=tamanho(); i > -1; i--) {
                if (i >= 0) {
                    this.vetor[i+1] = this.vetor[i];
                }

                if (i == 0) {
                    this.vetor[0] = elemento;
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
        if (vazio() || this.vetor[posicao] == null) {
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
        if (vazio() || this.vetor[posicao] == null) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }

        else {
            this.vetor[posicao] = null;
            this._Tamanho--;
            for (int i=posicao; i < tamanho(); i++) {
                this.vetor[i] = vetor[i+1];
            }
        }
    }

    public void removeInicio() {
        if (vazio() || this.vetor[0] == null) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }

        else {
            this.vetor[0] = null;
            for (int i=0; i < tamanho(); i++) {
                vetor[i] = vetor[i+1];
            }
            this._Tamanho--;
        }
    }

    public void removeFim() {
        if (vazio() || this.vetor[tamanho()-1] == null) {
            throw new ArgumentOutOfRangeException("Argumento fora de alcance.");
        }
        else {
            this.vetor[tamanho()] = null;
            this._Tamanho--;
        }
    }

    public int tamanho() {
        return this._Tamanho;
    }

    public void limpar() {
        for (int i=0; i < this._Tamanho; i++) {
            this.vetor[i] = null;
        }
        this._Tamanho = 0;
    }

    public void redimensionar() {
        T[] _vetor = new T[this._Tamanho*2];
        for (int i=0; i < this.vetor.Length; i++) {
            _vetor[i] = this.vetor[i];
        }
        this.vetor = _vetor;
    }
}