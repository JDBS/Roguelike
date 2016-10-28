using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    class CampoString : Campo
    {
        string contenido_;

        public CampoString()
        {
            throw new DBException("Un campo entero no puede tener valor nulo");
        }

        public CampoString(string contenido, int longitud)
        {
            if (contenido.Length <= longitud)
            {
                contenido_ = contenido;
                tipo_ = campoTipo.cadena;
                size_ = contenido.Length * 2;

                size_ = longitud * 4;
            }
            else
            {
                throw new DBException("El contenido a insertar [" + contenido + "] en el campo string supera el número de caracteres permitidos en el campo en declaración [" + longitud + "].");
            }
        }


        public override void set(string contenido)
        {
            if (contenido.Length <= (size_ / 4)) {
                contenido_ = contenido;
            }else
            {
                throw new DBException("El contenido a insertar [" + contenido + "] en el campo string supera el número de caracteres permitidos en el campo [" + (size_ / 4) + "].");
            }
        }

        public override string getString()
        {
            return contenido_;
        }

        public override string ToString()
        {
            return contenido_;
        }
    }
}
