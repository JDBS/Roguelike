using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Actores.Colisiones;

namespace Roguelike.Actores.Colisiones
{
    class PuntoColision
    {
        private Cuerpo colCorp_ = null;
        int colType_;


        public PuntoColision()
        {
            colType_ = -1;
        }

        public PuntoColision(Cuerpo Colision_Corpse, int Colision_Type)
        {
            colCorp_ = Colision_Corpse;
            colType_ = Colision_Type;
            
        }
       
    }
}
