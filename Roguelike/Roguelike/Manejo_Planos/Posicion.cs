using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Manejo_Planos;

namespace Roguelike.Manejo_Planos
{
    class Posicion
    {
        private int x_=0;
        private int y_=0;

        public Posicion()
        {

        }

        public Posicion(int x, int y)
        {
            x_ = x;
            y_ = y;
        }

        public Posicion(Posicion original)
        {
            x_ = original.x_;
            y_ = original.y_;
        }

        public int getX()
        {
            return x_;
        }
        public int getY()
        {
            return y_;
        }

        public void setX(int x)
        {
            x_ = x;
        }

        public void setY(int y)
        {
            y_ = y;
        }



        public static Posicion operator +(Posicion left, Offset right)
        {
            Posicion n = new Posicion();

            n.x_ = left.x_ + right.getX();
            n.y_ = left.y_ + right.getY();

            return n;
        }



        public static Posicion operator -(Posicion left, Offset right)
        {
            Posicion n = new Posicion();

            n.x_ = left.x_ - right.getX();
            n.y_ = left.y_ - right.getY();

            return n;

        }

        public static Offset operator -(Posicion left, Posicion right)
        {
            Offset n = new Offset();

            n.setX(left.x_ - right.x_);
            n.setY(left.y_ - right.y_);

            return n;
        }

        public static bool operator ==(Posicion a, Posicion b)
        {
            //si son el mismo objeto en memoria son iguales
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            //no tienen nada, por tanto no son iguales
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            
            return a.x_ == b.x_ && a.y_ == b.y_;
        }

        public static bool operator !=(Posicion a, Posicion b)
        {
            //si son el mismo objeto en memoria son iguales
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            //no tienen nada, por tanto no son distintos
            if (((object)a == null) || ((object)b == null))
            {
                return true;
            }
            
            return a.x_ != b.x_ || a.y_ != b.y_;
        }

    }
}
