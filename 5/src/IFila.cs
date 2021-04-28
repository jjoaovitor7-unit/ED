namespace src {
    interface IFila<T> {
        void inserir(T elemento);
        bool existeDado(T elemento);
        bool isEmpty();
        T recuperar();
        void alterar(T elemento);
        void remover();
        int tamanho();
        void limpa();
    }
}
