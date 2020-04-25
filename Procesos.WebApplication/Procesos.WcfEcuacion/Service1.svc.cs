using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Procesos.WcfEcuacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EcuacionCuadratica : IEcuacionCuadratica
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void ResolverEcuacion(double a, double b, double c, out double discriminante, out double x1, out double x2)
        {
            var laSolucion = new Resolver.EncontrarSolucion() ;
            laSolucion.ResolverEcuacion(a, b, c, out discriminante, out x1, out x2);
        }
    }
}
