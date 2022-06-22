using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///#.-IDeserializa<T> (tendrá como restricción que la clase posea un constructor por defecto)
///             -> Xml(out T) : bool
///             -> Json(out T) : bool

namespace EntidadesSP
{
    public interface IDeserializa<T>
        where T : new()
    {
        bool Xml(out T data);
        bool Json(out T data);
    }
}
