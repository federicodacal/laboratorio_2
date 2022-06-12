using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IGuardar<T>
        where T : class
    {
        string RutaDeArchivo { get; set; }

        bool Guardar();

        T Leer();
    }
}
