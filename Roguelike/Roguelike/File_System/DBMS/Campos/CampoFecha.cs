using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    class CampoFecha : Campo
    {
        DateTime contenido_;

        public CampoFecha()
        {
            throw new DBException("Un campo entero no puede tener valor nulo");
        }

        public CampoFecha(DateTime contenido)
        {
            contenido_ = contenido;
            tipo_ = campoTipo.fecha;
            size_ =  8;
        }


        public override void set(DateTime contenido)
        {
            contenido_ = contenido;
        }

        public override DateTime getDate()
        {
            return contenido_;
        }

        public override string ToString()
        {
            return contenido_.ToString();
        }
    }
}
