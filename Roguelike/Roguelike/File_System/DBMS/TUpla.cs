using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;
using Roguelike.File_System.DBMS.Campos;

namespace Roguelike.File_System.DBMS
{
    class TUpla
    {
        Campo[] campoL_;


        public TUpla()
        {

        }

        public TUpla(List<Campo> auxTUpla)
        {
            campoL_ = new Campos.Campo[auxTUpla.Count];
            for (int i = 0; i < auxTUpla.Count; i++)
            {
                campoL_[i] = auxTUpla[i];
            }
        }

        //Acepta campos separados por comas
        public TUpla(params Campo[] auxTUpla)
        {

            campoL_ = auxTUpla;
        }
        

        //Constructor para un campo Extra al principio de una TUpla (útil en inserción)
        public TUpla(Campo campoExtra, TUpla auxTUpla)
        {
            campoL_ = new Campo[auxTUpla.Count() + 1];
            campoL_[0] = campoExtra;

            for(int i=1; i <= auxTUpla.Count(); i++)
            {
                campoL_[i] = auxTUpla[i];
            }
        }

        public Campo getCampo(int i)
        {
            if (i < campoL_.Count() && i>=0)
            {
                return campoL_[i];
            }
            else
            {
                //Error, campo "i" no encontrado
                return new Campo();
            }
        }
        public int Count()
        {
            return campoL_.Count();
        }

        public override string ToString()
        {
            string aux = "[";
            for(int i=0; i<campoL_.Count(); i++)
            {
                aux += campoL_[i].ToString();
                if (i < (campoL_.Count() - 1))
                {
                    aux += ",";
                }
            }
            aux += "]";

            return aux;
        }
        
        public Campo this[int i]
        {
            get { return campoL_[i]; }
            set {
                if(value.GetType()== campoL_[i].GetType()) {
                    campoL_[i] = value;
                }else
                {
                    throw new DBException("El Campo " + value.ToString() + " de tipo " + value.GetType() + " no puede ser insertado en la TUpla debido a que es de distinto tipo.");
                }
            }
        }

    }
    //Sobrecarga operador de Comparacion
    
}
