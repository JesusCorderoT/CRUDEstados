using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    public class EstadosStruc
    {
        public EstadosStruc(string ide,string des) {
            IDE = ide;
            DES = des;
        }

        public EstadosStruc() { }   
        public string IDE { get; set; }
        public string DES { get; set; }

    }
}
