using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cheques_Por_Extenso;

namespace Teste_ChequesPorExtenso
{
    [TestClass]
    public class Cheque_Por_ExtensoTests
    {
        private Cheque cheque;

        public Cheque_Por_ExtensoTests()
        {
            this.cheque = new Cheque();
        }

        #region Teste de Unidades
        [TestMethod]
        [DataRow(1,"um")]
        [DataRow(2,"dois")]
        [DataRow(3,"três")]
        [DataRow(4,"quatro")]
        [DataRow(5,"cinco")]
        [DataRow(6,"seis")]
        [DataRow(7,"sete")]
        [DataRow(8,"oito")]
        [DataRow(9,"nove")]
        public void EscreverUnidades(int numeroInputado , string resultado)
        {
            //cenário - arrange
            decimal numero = numeroInputado;

            //ação - action 
            var resultadoObtido = cheque.chequeEscritoPorExtenso(numero);

            //verificação - assert
            Assert.AreEqual(resultado, resultadoObtido);
        }
        #endregion

        #region Teste de Dezenas Simples
        [TestMethod]
        [DataRow(10, "dez")]
        [DataRow(20, "vinte")]
        [DataRow(30, "trinta")]
        [DataRow(40, "quarenta")]
        [DataRow(50, "cinquenta")]
        [DataRow(60, "sessenta")]
        [DataRow(70, "setenta")]
        [DataRow(80, "oitenta")]
        [DataRow(90, "noventa")]
        public void EscreverDezenasBase(int numeroInputado, string resultado)
        {
            //cenário - arrange
            decimal numero = numeroInputado;

            //ação - action 
            var resultadoObtido = cheque.chequeEscritoPorExtenso(numero);

            //verificação - assert
            Assert.AreEqual(resultado, resultadoObtido);
        }
        #endregion

        #region Teste de Dezenas Complexas
        [TestMethod]
        [DataRow(11, "onze")]
        [DataRow(12, "doze")]
        [DataRow(19, "dezenove")]
        [DataRow(49, "quarenta e nove")]
        [DataRow(59, "cinquenta e nove")]
        public void EscreverDezenasComplexas(int numeroInputado, string resultado)
        {
            //cenário - arrange
            decimal numero = numeroInputado;

            //ação - action 
            var resultadoObtido = cheque.chequeEscritoPorExtenso(numero);

            //verificação - assert
            Assert.AreEqual(resultado, resultadoObtido);
        }
        #endregion

        #region Teste de Dezenas Simples
        
        [TestMethod]
        [DataRow(100, "cem")]
        [DataRow(200, "duzentos")]
        [DataRow(300, "trezentos")]
        [DataRow(400, "quatrocentos")]
        [DataRow(500, "quinhentos")]
        [DataRow(600, "seiscentos")]
        [DataRow(700, "setecentos")]
        [DataRow(800, "oitocentos")]
        [DataRow(900, "novecentos")]
        public void EscreverCentenasBasicas(int numeroInputado, string resultado)
        {
            //cenário - arrange
            decimal numero = numeroInputado;

            //ação - action 
            var resultadoObtido = cheque.chequeEscritoPorExtenso(numero);

            //verificação - assert
            Assert.AreEqual(resultado, resultadoObtido);
        }

        #endregion

        #region Teste de Dezenas Simples
        [TestMethod]
        [DataRow(111, "cento e onze")]
        [DataRow(210, "duzentos e dez")]
        [DataRow(301, "trezentos e um")]
        [DataRow(444, "quatrocentos e quarenta e quatro")]
        //[DataRow(500, "quinhentos")]
        //[DataRow(600, "seiscentos")]
        //[DataRow(700, "setecentos")]
        //[DataRow(800, "oitocentos")]
        //[DataRow(900, "novecentos")]
        public void EscreverCentenasBComplexas(int numeroInputado, string resultado)
        {
            //cenário - arrange
            decimal numero = numeroInputado;

            //ação - action 
            var resultadoObtido = cheque.chequeEscritoPorExtenso(numero);

            //verificação - assert
            Assert.AreEqual(resultado, resultadoObtido);
        }
        #endregion

        #region Teste de Dezenas Simples
        [TestMethod]
        [DataRow(1111, "teste")]
        [DataRow(1210, "duzentos e dez")]
        [DataRow(1301, "trezentos e um")]
        [DataRow(1444, "quatrocentos e quarenta e quatro")]
        public void EscreverMilhar(int numeroInputado, string resultado)
        {
            //cenário - arrange
            decimal numero = numeroInputado;

            //ação - action 
            var resultadoObtido = cheque.chequeEscritoPorExtenso(numero);

            //verificação - assert
            Assert.AreEqual(resultado, resultadoObtido);
        }
        #endregion
    }
}
