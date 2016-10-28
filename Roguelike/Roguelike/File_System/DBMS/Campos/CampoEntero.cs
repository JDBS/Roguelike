using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    public class CampoEntero : Campo
    {
        private int contenido_;

        
        public CampoEntero()
        {
            throw new DBException("Un campo entero no puede tener valor nulo");
        }

        public CampoEntero(int contenido)
        {
            contenido_ = contenido;
            tipo_ = campoTipo.entero;
            size_ = 4;
        }


        public override void set(int contenido)
        {
            contenido_ = contenido;
        }

        public override int getInt()
        {
            return contenido_;
        }

        public override string ToString()
        {
            return contenido_.ToString();
        }

    }
}
