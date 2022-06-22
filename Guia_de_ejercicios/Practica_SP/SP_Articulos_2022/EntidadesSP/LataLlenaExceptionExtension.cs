using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public static class LataLlenaExceptionExtension
    {
        public static string InformarNovedad(this LataLlenaException ex)
        {
            return ex.Message;
        }
    }
}
