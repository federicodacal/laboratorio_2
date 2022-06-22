using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///#.-IDeserializa -> Xml(out zapato) : bool
namespace EntidadesSP
{
    public interface IDeserializa
    {
        bool Xml(out Zapato zapato); 
    }
}
