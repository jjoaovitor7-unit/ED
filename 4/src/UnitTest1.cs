using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace src
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdicionandoElementoERecuperandoElemento() {
            Aluno a1 = new Aluno("A1", 12);
            Aluno a2 = new Aluno("A2", 32);
            Aluno a3 = new Aluno("A3", 42);

            ListaDuplamenteEncadeadaComNoCabeca<Aluno> lista = new ListaDuplamenteEncadeadaComNoCabeca<Aluno>();

            lista.adicionaInicio(a1);
            lista.adiciona(a2, 1);
            lista.adicionaFim(a3);

            Assert.AreEqual(lista.recupera(0), a1);
            Assert.AreEqual(lista.recupera(1), a2);
            Assert.AreEqual(lista.recupera(2), a3);
        }

        [TestMethod]
        public void AdicionandoElementoNaPosicaoELimpandoListaEncadeada() {
            Aluno a1 = new Aluno("A1", 12);
            Aluno a2 = new Aluno("A2", 32);
            Aluno a3 = new Aluno("A3", 42);

            ListaDuplamenteEncadeadaComNoCabeca<Aluno> lista = new ListaDuplamenteEncadeadaComNoCabeca<Aluno>();
            lista.adicionaInicio(a1);
            lista.adiciona(a2, 1);
            lista.adicionaFim(a3);
            lista.limpa();
            try {
                lista.recupera(0);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException) {
            }
        }

        [TestMethod]
        public void AdicionandoElementoNoInicioERemovendoElementoNoInicio(){
            Aluno a1 = new Aluno("A1", 12);
            Aluno a2 = new Aluno("A2", 32);

            ListaDuplamenteEncadeadaComNoCabeca<Aluno> lista = new ListaDuplamenteEncadeadaComNoCabeca<Aluno>();
            
            lista.adicionaInicio(a1);
            lista.adicionaInicio(a2);
            lista.removeInicio();

            Assert.AreEqual(lista.recupera(0), a1);
        }

        [TestMethod]
        public void AdicionandoElementoNoFinalERemovendoElementoNoFinal() {
            Aluno a1 = new Aluno("A1", 12);
            Aluno a2 = new Aluno("A2", 32);

            ListaDuplamenteEncadeadaComNoCabeca<Aluno> lista = new ListaDuplamenteEncadeadaComNoCabeca<Aluno>();

            lista.adicionaFim(a1);
            lista.adicionaFim(a2);
            lista.removeFim();

            Assert.AreEqual(lista.recupera(0), a1);
        }
    }
}
