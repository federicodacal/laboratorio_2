using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializable<T, U>
    {
        bool Serializar(string path);

        bool Deserializar(string path, out ClaseGenerica<T, U> objeto);
    }
}
