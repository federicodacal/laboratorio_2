using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear las interfaces (en class library): 
///#.-ISerializa -> Xml() : bool
///              -> Path{ get; } : string

namespace EntidadesSP
{
    public interface ISerializa
    {
        string Path { get; }

        bool Xml();
    }
}
