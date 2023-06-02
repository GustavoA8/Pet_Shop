using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMarket
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public DateTime validade { get; set; }
        public string marca { get; set; }
        public DateTime registro { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }

    }
}
