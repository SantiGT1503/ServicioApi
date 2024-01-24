using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSOAP.CSD
{
    public class Convertir
    {
        public string Numero2Letras(ulong Numero)
        {
            string Respuesta;
            ConversionNumerica.NumberConversionSoapTypeClient oConvNum = new ConversionNumerica.NumberConversionSoapTypeClient("NumberConversionSoap");

            Respuesta = oConvNum.NumberToWords(Numero);

            return Respuesta;
        }

        public string Numero2Dolares(decimal Numero)
        {
            string Respuesta;
            ConversionNumerica.NumberConversionSoapTypeClient oConvDol = new ConversionNumerica.NumberConversionSoapTypeClient("NumberConversionSoap");

            Respuesta = oConvDol.NumberToDollars(Numero);

            return Respuesta;
        }
    }
}