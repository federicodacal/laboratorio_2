using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///#.-ISerializa -> Xml() : bool
///              -> PathXml{ get; } : string
///              -> Json() : bool
///              -> PathJson{ get; } : string

namespace EntidadesSP
{
    public interface ISerializa
    {
        string PathXml { get; }
        string PathJson { get; }
        bool Xml();
        bool Json();
    }
}
