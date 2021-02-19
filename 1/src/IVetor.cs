interface IVetor<T> {
    void adiciona(T elemento, int posicao);
    void adicionaInicio (T elemento);
    void adicionaFim(T elemento);
    bool existeDado(int posicao);
    T recuperar(int posicao);
    bool vazio();
    void remove(int posicao);
    void removeInicio();
    void removeFim();
    int tamanho();
    void limpar();
    void redimensionar();
}