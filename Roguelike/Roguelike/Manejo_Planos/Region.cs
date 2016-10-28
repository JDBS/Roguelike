using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Regiones
 * Las regiones permiten interactuar con puntos de
 * forma relativamente sencilla, hallar bordes y
 * facilitar los cálculos.
 * Requiere dos posiciones que deben ser definidas en el constructor:
 * -BSD= Borde Superior Derecho
 * -BII= Borde inferior Izquierdo
 */

namespace Roguelike.Manejo_Planos
{
    class Region
    {
        private Posicion BSD_;
        private Posicion BII_;

        public Region()
        {
            BSD_ = new Posicion(0, 0);
            BII_ = new Posicion(0, 0);
        }

        public Region(Posicion BSD, Posicion BII)
        {
            BSD_ = BSD;
            BII_ = BII;
        }

        public bool checkPointInRegion(Posicion pos)
        {
            return pos.getX() >= BII_.getX() &&
                   pos.getX() <= BSD_.getX() &&
                   pos.getY() >= BII_.getY() &&
                   pos.getY() <= BSD_.getY();
        }

        public int maxX()
        {
            return BSD_.getX();
        }

        public int maxY()
        {
            return BSD_.getY();
        }

        public int minX()
        {
            return BII_.getX();
        }

        public int minY()
        {
            return BII_.getY();
        }
    }
}
