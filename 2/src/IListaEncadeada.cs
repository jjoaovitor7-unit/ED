namespace src {
    interface IListaEncadeada<T> {
        void adiciona(T elemento, int posicao);
        void adicionaInicio(T elemento);
        void adicionaFim(T elemento);
        bool existeDado(T elemento);
        T recupera(int posicao);
        void remove(int posicao);
        void removeInicio();
        void removeFim();
        int tamanho();
        void limpa();
    }
}