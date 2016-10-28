using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    class CampoFlotante : Campo
    {
        private float contenido_;


        public CampoFlotante()
        {
            throw new DBException("Un campo flotante no puede tener valor nulo");
        }

        public CampoFlotante(float contenido)
        {
            contenido_ = contenido;
            tipo_ = campoTipo.flotante;
            size_ = 4;
        }


        public override void set(float contenido)
        {
            contenido_ = contenido;
        }

        public override float getFloat()
        {
            return contenido_;
        }

        public override string ToString()
        {
            return contenido_.ToString();
        }

        

    }
}
