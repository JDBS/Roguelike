using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Actores.Colisiones;
using Roguelike.Manejo_Planos;

namespace Roguelike.Actores.Entidades
{
    enum Direccion { arriba, abajo, derecha, izquierda};

    class Entidad
    {
        int ID_;                        //Identificador de la entidad
        protected string name_;         //Nombre de la entidad
        protected Posicion pos_;        //Posicion de la entidad
        public Cuerpo corp_{get; set;}  //Cuerpo de la entidad

        //corpse_ (skin & collider)

        public Entidad()
        {
            corp_ = new Cuerpo();
            name_ = "";
            pos_ = new Posicion(0, 0);
        }
        public Entidad(int x, int y)
        {
            corp_ = new Cuerpo();
            name_ = "";
            pos_ = new Posicion(x, y);
        }

        public virtual void move(Direccion dir)
        {
            switch (dir)
            {
                case Direccion.arriba:
                    pos_.setY(pos_.getY() - 1);
                    break;
                case Direccion.abajo:
                    pos_.setY(pos_.getY() + 1);
                    break;
                case Direccion.derecha:
                    pos_.setX(pos_.getX() + 1);
                    break;
                case Direccion.izquierda:
                    pos_.setX(pos_.getX() - 1);
                    break;
            }
        }

        public Posicion getPos()
        {
            return pos_;
        }
        public void printPos()
        {
            Console.WriteLine("(" + pos_.getX() + "," + pos_.getY() + ")");
        }

    }
}
