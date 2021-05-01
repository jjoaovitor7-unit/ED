namespace src {
    interface IDeque<T> {
        void inserirNoInicio(T elemento);
        void inserirNoFim(T elemento);
        bool existeDado(T elemento);
        bool isEmpty();
        T recuperarInicio();
        T recuperarFim();
        void alterarInicio(T elemento);
        void alterarFim(T elemento);
        void removerInicio();
        void removerFim();
        int tamanho();
        void limpa();
    }
}
