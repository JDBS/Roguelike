using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    class CampoChar : Campo
    {
        char contenido_;

        public CampoChar()
        {
            throw new DBException("Un campo entero no puede tener valor nulo");
        }

        public CampoChar(char contenido)
        {
            contenido_ = contenido;
            tipo_ = campoTipo.doble;
            size_ = 2;
        }


        public override void set(char contenido)
        {
            contenido_ = contenido;
        }

        public override char getChar()
        {
            return contenido_;
        }


        public override string ToString()
        {
            return contenido_.ToString();
        }

        public override int getSizeBytes()
        {
            return 0;
        }
    }
}
