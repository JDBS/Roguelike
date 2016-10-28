using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Actores.Colisiones;

namespace Roguelike.Actores.Colisiones
{
    //Tiene información de los puntos de colisión existentes
    class PlanoColision
    {
        private PuntoColision[][] colFr_=null;

        int sizeX_=0;
        int sizeY_=0;

        public PlanoColision()
        {
        }

        public PlanoColision(int size_x, int size_y)
        {
            sizeX_ = size_x;
            sizeY_ = size_y;
            colFr_ = new PuntoColision[size_y][];
            for(int i=0; i<sizeY_; i++)
            {
                colFr_[i] = new PuntoColision[sizeX_];
            }
        }
    }
}
