using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterafaceSegregationRefactor
{
    // Creamos una interfaz de alto nivel
    interface IMultiCompleto: IFax, IMultiBasico
    {
    }
}
