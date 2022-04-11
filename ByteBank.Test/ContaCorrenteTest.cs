using Microsoft.VisualStudio.TestTools.UnitTesting;
using ByteBank.Contas;
using System;

namespace ByteBank.Test
{
    [TestClass]
    public class ContaCorrenteTest
    {
        private readonly ContaCorrente _contaCorrente;
        private readonly ContaCorrente _contaCorrente1;

        public ContaCorrenteTest()
        {
            _contaCorrente = new ContaCorrente(123, 123);
            _contaCorrente1 = new ContaCorrente(456, 456);
        }

        [TestMethod]
        public void TestaSaldo_AposSaque_Sucesso()
        {
            var result = _contaCorrente.Sacar(10);
            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void TestaSaldo_AposDeposito_Sucesso()
        {
            var result = _contaCorrente.Depositar(10);
            Assert.AreEqual(110, result);
        }

        [TestMethod]
        public void TestaSaldo_DaContaQueFezTransferencia_Sucesso()
        {
            _contaCorrente.Transferir(10, _contaCorrente1);
            var result = _contaCorrente.Saldo;
            Assert.AreEqual(result, 90);
        }

        [TestMethod]
        public void TestaSaldo_DaContaQueRecebeTransferencia_Sucesso()
        {
            _contaCorrente.Transferir(10, _contaCorrente1);
            var resust = _contaCorrente1.Saldo;
            Assert.AreEqual(110, resust);
        }
    }
}
