using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    {
        T Leer(string path);
        bool Escribir(string path, T data, bool append);
    }
}
