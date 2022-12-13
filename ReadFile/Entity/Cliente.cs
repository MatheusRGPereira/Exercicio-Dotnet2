using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile.Entity
{
    public record struct  Cliente
    {
        public string nome { get; set; }
        public string telefone { get; set;}

    }
}
