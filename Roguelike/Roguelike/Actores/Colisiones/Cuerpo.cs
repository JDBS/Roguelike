using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Actores.Entidades;
using Roguelike.Manejo_Planos;
using Roguelike.Interfaz.Texturas;

namespace Roguelike.Actores.Colisiones
{
    class Cuerpo
    {
        /*TODO:
         * Añadir atributo tipo GameObject en referencia al objeto que lo crea.
         */

        protected Textura tx_;
        protected Offset cent_;

        public Cuerpo()
        {
            tx_ = new Textura();
            cent_ = new Offset();
        }

        public Cuerpo(int centro_x, int centro_y, Textura tx)
        {
            tx_ = tx;
            if (centro_x >= 0 && centro_y >= 0)
            {
                if (centro_x < tx_.getSizeX() && centro_y < tx_.getSizeY())
                {
                    cent_= new Offset(centro_x,centro_y);
                }
                else
                {
                    cent_ = new Offset();
                }              
            }
            else
            {
                cent_ = new Offset();
            }
        }

   
        public bool detectarColision(Posicion pos_cuerpo, Posicion pos_colision)
        {
            if(tx_.getSizeX()<=0 || tx_.getSizeY() <= 0)
            {
                return false;   //si no tienen volumen no pueden colisionar
            }

            if(tx_.getSizeX()==1 && tx_.getSizeY() == 1)
            {
                return (pos_cuerpo == pos_colision);    //si su tamaño es 1 solo se compara una posición.
            }else {
                //crea una region y la usa como caja de colisiones
                Region CajaColision = new Region(getBII(pos_cuerpo), getBSD(pos_cuerpo));

                //true si la posicion está en la región
                return CajaColision.checkPointInRegion(pos_colision); 
            }
        }


        public char[][] getImage()
        {
            return tx_.getImage();
        }

        public int getOffsetX()
        {
            return cent_.getX();
        }

        public int getOffsetY()
        {
            return cent_.getY();
        }

        public Offset getOffset()
        {
            return cent_;
        }

        // Obtiene el Borde Superior Izquierdo en base a la posicion
        private Posicion getBSI(Posicion pos_cuerpo)
        {
            return new Posicion(pos_cuerpo.getX()-getOffsetX(),
                pos_cuerpo.getY() + (tx_.getSizeY() - 1) - getOffsetY());
        }
        

        // Obtiene el Borde Inferior Izquierdo en base a la posicion
        private Posicion getBII(Posicion pos_cuerpo)
        {
            return new Posicion(pos_cuerpo.getX() - getOffsetX(), 
                pos_cuerpo.getY() - getOffsetY());
        }



        // Obtiene el Borde Superior Derecho en base a la posicion
        private Posicion getBSD(Posicion pos_cuerpo)
        {
            return new Posicion(pos_cuerpo.getX() + (tx_.getSizeX() - 1) - getOffsetX(),
                pos_cuerpo.getY() + (tx_.getSizeY() - 1) - getOffsetY());
        }



        // Obtiene el Borde Inferior Derecho en base a la posición
        private Posicion getBID(Posicion pos_cuerpo)
        {
            return new Posicion(pos_cuerpo.getX() + (tx_.getSizeX() - 1) - getOffsetX(),
                pos_cuerpo.getY() - getOffsetY());
        }

    }
}
