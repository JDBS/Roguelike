using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    class CampoDouble : Campo
    {
        private double contenido_;


        public CampoDouble()
        {
            throw new DBException("Un campo doble no puede tener valor nulo");
        }

        public CampoDouble(double contenido)
        {
            contenido_ = contenido;
            tipo_ = campoTipo.doble;
            size_ = 8;
        }


        public override void set(double contenido)
        {
            contenido_ = contenido;
        }

        public override double getDouble()
        {
            return contenido_;
        }

        public override string ToString()
        {
            return contenido_.ToString();
        }
        

    }
}
