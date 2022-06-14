using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    public class Estados
    {
       
        static  Dictionary<string, EstadosStruc> _lstEstados = new Dictionary<string, EstadosStruc>();

        public Dictionary<string, EstadosStruc> ConsultaTodos(){
            return _lstEstados;
        }

        public  EstadosStruc ConsultaUno(string ide)
        {
            EstadosStruc estados = new EstadosStruc();
            if (_lstEstados.ContainsKey(ide)) {
                 estados = _lstEstados[ide];
                    }
            return estados;
        }

        public static void Agregar(EstadosStruc estados)
        {
            _lstEstados.Add(estados.IDE, estados);
        }


        public static void Actualizar(EstadosStruc est)
        {
          //  EstadosStruc estados = new EstadosStruc();
            if (_lstEstados.ContainsKey(est.IDE))
            {
                _lstEstados[est.IDE] = est;
              //  estados.DES= est.DES;
            }
          //  return estados;


        }
        public static void Eliminar(EstadosStruc estados)
        {
            _lstEstados.Remove(estados.IDE);
        }

 




    }



    }

