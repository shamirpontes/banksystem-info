using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Dynamic;

namespace BrasilApi.Dtos
{
    public class BancoResponse
    {
        public string Ispb { get; set; }

        public string Nome { get; set; }

        public int Codigo { get; set; }
        
        public string NomeCompleto { get; set; }
    }
}