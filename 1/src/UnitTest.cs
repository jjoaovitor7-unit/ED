using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using src;

namespace VetorTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AdicionandoElementoNaPosicaoERecuperandoElementoNaPosicaoNoVetor()
        {
            Aluno a1 = new Aluno("A1", 18);
            Vetor<Aluno> v = new Vetor<Aluno>(1);
            v.adiciona(a1, 0);
            Assert.AreEqual(v.recuperar(0), a1);
        }

        [TestMethod]
        public void AdicionadoElementoNaPosicaoELimpandoVetor()
        {
            Aluno a1 = new Aluno("A1", 18);
            Vetor<Aluno> v = new Vetor<Aluno>(1);
            v.adiciona(a1, 0);
            v.limpar();

            try {
                v.recuperar(0);
                Assert.Fail();
            }

            catch (ArgumentOutOfRangeException) {
            }
        }

        [TestMethod]
        public void AdicionadoElementoNaPosicaoERemovendoElementoNaPosicao()
        {
            Aluno a1 = new Aluno("A1", 18);
            Aluno a2 = new Aluno("A2", 20);
            Vetor<Aluno> v = new Vetor<Aluno>(3);
            v.adiciona(a1, 0);
            v.adiciona(a2, 1);
            v.remove(0);
            Assert.AreEqual(v.recuperar(0), a2);
        }

        [TestMethod]
        public void AdicionandoElementoNoInicioERemovendoElementoNoInicio() {
            Aluno a1 = new Aluno("A1", 18);
            Aluno a2 = new Aluno("A2", 20);
            Vetor<Aluno> v = new Vetor<Aluno>(3);
            v.adicionaInicio(a1);
            v.adicionaInicio(a2);
            v.removeInicio();
            Assert.AreEqual(v.recuperar(0), a1);
        }

        [TestMethod]
        public void AdicionandoElementoNoFinalERemovendoElementoNoFinal() {
            Aluno a1 = new Aluno("A1", 18);
            Aluno a2 = new Aluno("A2", 20);
            Vetor<Aluno> v = new Vetor<Aluno>(3);
            v.adicionaFim(a1);
            v.adicionaFim(a2);
            v.removeFim();
            Assert.AreEqual(v.recuperar(0), a1);
        }
    }
}
