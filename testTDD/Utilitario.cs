using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTDD
{
    public class Utilitario 
    {
        public OperacionModel ObtenerNumeroPrimo(double num1)
        {
            var model = new OperacionModel();

            int operacion = 0;

            for (int i = 0; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    operacion++;
                }
            }

            model.Mensaje = operacion > 2 ? "no es primo" : "es primo";

            return model;
        }

        public OperacionModel Fechanacimiento(OperacionModel model)
        {
            var year = DateTime.Now.Date.Year;

            model.Edad = year - model.Year;

            return model;
        }

        public OperacionModel SalarioBrutoaNeto(OperacionModel model)
        {
            model.SalarioMinimo = 13482;

            model.OperacionDescARS = model.OperacionDescAFP = model.Monto / model.SalarioMinimo;

            if (model.OperacionDescARS <= 10)
            {
                var operacion = model.Monto * 0.0304;
                model.DescARS = model.Monto - operacion;
                model.MensajeARS = "monto menor a 10 ARS";
            }

            if (model.OperacionDescARS > 10)
            {
                var operacion = model.SalarioMinimo * 10;
                model.OperacionDescARS = operacion * 0.0304;
                model.DescARS = operacion - model.OperacionDescARS;
                model.MensajeARS = "monto mayor a 10 ARS";
            }

            if (model.OperacionDescAFP <= 20)
            {
                var operacion = model.Monto * 0.0287;
                model.DescAFP = model.Monto - operacion;
                model.MensajeAFP = "monto menor a 20 AFP";
            }

            if (model.OperacionDescAFP > 20)
            {
                var operacion = model.SalarioMinimo * 20;
                model.OperacionDescAFP = operacion * 0.0287;
                model.DescAFP = operacion - model.OperacionDescAFP;
                model.MensajeAFP = "monto mayor a 20 AFP";
            }

            return model;
        }

        public OperacionModel ImpuestoDGII(OperacionModel model)
        {
            var operacion = model.salarioDGII*12;

            if (operacion < 416220)
            {
                model.ResultadoDGII = "Esta extenso de impuesto";
                model.Monto = operacion;
            }

            if (operacion > 416220 && operacion < 624329)
            {
                model.PorcientoDGII = operacion * 0.15;
                model.Monto = operacion - model.PorcientoDGII;
                model.ResultadoDGII = "15% del excedente";
                
            }

            if (operacion > 624329 && operacion < 867123)
            {
                model.PorcientoDGII = operacion * 0.20;
                model.Monto = operacion - model.PorcientoDGII-31216;
                model.ResultadoDGII = "31,216 mas el 20% del excedente";
            }

            if (operacion > 867123)
            {
                model.PorcientoDGII = operacion * 0.25;
                model.Monto = operacion - model.PorcientoDGII - 79776;
                model.ResultadoDGII = "79,776 mas el 25% excedente";
            }

            return model;
        }


    }
}
