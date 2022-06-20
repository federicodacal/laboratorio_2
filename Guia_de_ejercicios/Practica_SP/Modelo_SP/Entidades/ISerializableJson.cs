using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializableJson
    {
        bool Serializar(string path);

        bool Deserializar(string path, out Usuario objeto);
    }
}
