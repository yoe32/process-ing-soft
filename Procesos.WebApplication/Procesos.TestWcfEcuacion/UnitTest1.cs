using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Procesos.TestWcfEcuacion
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ElValorDeAEsCero_Error()
        {
            // definir el escenario
            var laClaseParaProbar = new WcfEcuacion.EcuacionCuadratica();
            double a = 0;
            double b = 1;
            double c = 2;
            double discriminante = -1;
            double x1 = -1;
            double x2 = -1;
            bool huboError = false;
            bool esperoQueHayaError = true;

            // llamo al método que deseo probar
            try
            {
                laClaseParaProbar.ResolverEcuacion(a, b, c, out discriminante, out x1, out x2);
            }
            catch (Exception)
            {

                huboError = true;
            }

            //verificación de resultados
            Assert.AreEqual(esperoQueHayaError, huboError);
        }
    }
}
