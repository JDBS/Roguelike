using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike.Manejo_Planos
{
    class Offset
    {
        private int x_ = 0;
        private int y_ = 0;

        public Offset()
        {

        }

        public Offset(int x, int y)
        {
            x_ = x;
            y_ = y;
        }


        public Offset(Offset original)
        {
            x_ = original.x_;
            y_ = original.y_;
        }

        public Offset(Posicion original)
        {
            x_ = original.getX();
            y_ = original.getY();
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




    }
}
