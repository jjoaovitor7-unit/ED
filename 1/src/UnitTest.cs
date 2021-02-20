using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using src;

namespace VetorTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AdicionandoERecuperandoElementoNoVetor()
        {
            Aluno a1 = new Aluno("A1", 12);
            Vetor<Aluno> v = new Vetor<Aluno>(1);
            v.adiciona(a1, 0);
            Assert.AreEqual(v.recuperar(0), a1);
        }

        [TestMethod]
        public void AdicionadoELimpandoVetor()
        {
            Aluno a1 = new Aluno("A1", 12);
            Vetor<Aluno> v = new Vetor<Aluno>(3);
            v.adiciona(a1, 0);
            v.limpar();

            try {
                v.recuperar(0);
                Assert.Fail();
            }

            catch (ArgumentOutOfRangeException) {
            }
        }
    }
}
