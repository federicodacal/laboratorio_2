using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public static class ExtensionCajaLlenaException
    {
        public static string InformarNovedad(this CajaLlenaException ex)
        {
            return ex.Message;
        }
    }
}
