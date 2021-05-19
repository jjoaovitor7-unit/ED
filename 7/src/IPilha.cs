interface IPilha<T> {
    void push(T elemento);
    bool existeDado(T elemento);
    bool isEmpty();
    T top();
    void pull(T elemento);
    void pop();
    int tamanho();
    void limpa();
}