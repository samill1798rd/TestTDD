using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testTDD;

namespace TesterTDD
{
    [TestClass]
    public class Test
    {
   
        [TestMethod]
        public void Test_Numero_Primo_True()
        {
            var utilitario = new Utilitario();

            var operacion = utilitario.ObtenerNumeroPrimo(5);

            Assert.AreSame(operacion.Mensaje, "es primo");
        }

        [TestMethod]
        public void Test_Numero_Primo_False()
        {
            var utilitario = new Utilitario();

            var operacion = utilitario.ObtenerNumeroPrimo(6);

            Assert.AreSame(operacion.Mensaje, "no es primo");
        }

        [TestMethod]
        public void Test_Fecha_Nacimiento()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                Dia = 17,
                Mes = 04,
                Year = 1998
            };

            var operacion = utilitario.Fechanacimiento(model);

            Assert.AreEqual(operacion.Edad,23);
        }

        [TestMethod]
        public void Test_Salario_Bruto_to_Neto_ARS_Menor_a_10()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                Monto = 60000
            };

            var operacion = utilitario.SalarioBrutoaNeto(model);

            Assert.AreSame(operacion.MensajeARS, "monto menor a 10 ARS");
        }

        [TestMethod]
        public void Test_Salario_Bruto_to_Neto_ARS_Mayor_a_10()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                Monto = 200000
            };

            var operacion = utilitario.SalarioBrutoaNeto(model);

            Assert.AreSame(operacion.MensajeARS, "monto mayor a 10 ARS");
        }

        [TestMethod]
        public void Test_Salario_Bruto_to_Neto_AFP_Menor_a_20()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                Monto = 60000
            };

            var operacion = utilitario.SalarioBrutoaNeto(model);

            Assert.AreSame(operacion.MensajeAFP, "monto menor a 20 AFP");
        }

        [TestMethod]
        public void Test_Salario_Bruto_to_Neto_AFP_Mayor_a_20()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                Monto = 300000
            };

            var operacion = utilitario.SalarioBrutoaNeto(model);

            Assert.AreSame(operacion.MensajeAFP, "monto mayor a 20 AFP");
        }

        [TestMethod]
        public void Test_Salario_DGII_Extenso()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                salarioDGII = 30000
            };

            var operacion = utilitario.ImpuestoDGII(model);

            Assert.AreSame(operacion.ResultadoDGII, "Esta extenso de impuesto");
        }

        [TestMethod]
        public void Test_Salario_DGII_15_Porciento()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                salarioDGII = 50000
            };

            var operacion = utilitario.ImpuestoDGII(model);

            Assert.AreSame(operacion.ResultadoDGII, "15% del excedente");
        }


        [TestMethod]
        public void Test_Salario_DGII_20_Porciento_menos_31216()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                salarioDGII = 60000
            };

            var operacion = utilitario.ImpuestoDGII(model);

            Assert.AreSame(operacion.ResultadoDGII, "31,216 mas el 20% del excedente");
        }

        [TestMethod]
        public void Test_Salario_DGII_25_Porciento_menos_79776()
        {
            var utilitario = new Utilitario();

            var model = new OperacionModel()
            {
                salarioDGII = 80000
            };

            var operacion = utilitario.ImpuestoDGII(model);

            Assert.AreSame(operacion.ResultadoDGII, "79,776 mas el 25% excedente");
        }
    }
}
