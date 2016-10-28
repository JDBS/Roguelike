using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Interfaz.Frame.Borders;
using Roguelike.Actores.Entidades;
using Roguelike.Manejo_Planos;

/*Notas:
 * Frames
 *  Son planos que pueden formarse a partir del dibujado de Entidades,
 *  Estructuras u otros Frames. Cuando un Frame se dibuja dobre otro
 *  puede dibujarse con bordeado.
 *  Los Frames no contienen información sobre colisiones, solo lo
 *  necesario para el dibujado.
 * 
 * -Coordenadas:
 *  -Cero cero situado en Esquina superior izquierda
 *  -Coordenadas máximas en esquina inferior derecha
 * -Enlazado de Frames:
 *  -Un frame puede contener a otros frames para sincronizarse.
 *  -Así, cuando un subframe es modificado pasará la información a los superiores.
 */
namespace Roguelike.Interfaz.Frame
{
    class Frame
    {
        private char[][] fr_;
        private int sizeX_;
        private int sizeY_;

        public Frame()
        {
            fr_ = null;
            sizeX_ = 0;
            sizeY_ = 0;
        }

        public Frame(int size_x, int size_y)
        {
            fr_ = new char[size_y][];
            
            for(int i=0; i< size_y; i++)
            {
                fr_[i] = new char[size_x];
                for(int j=0; j< size_x; j++)
                {
                    fr_[i][j] = ' ';
                }
            }
            sizeX_ = size_x;
            sizeY_ = size_y;
        }


        public void clearFrame()
        {

            for (int j = 0; j < sizeX_; j++)
            {
                for (int i = 0; i < sizeY_; i++)
                {
                    fr_[i][j] = ' ';
                }
            }
        }


        //Transforma una posición absoluta en una posición relativa en el frame
        private Posicion getFramePosition(Posicion posicion_absoluta, Posicion posicion_camara)
        {
            return new Posicion(posicion_absoluta - new Offset(posicion_camara));
        }


        //si devuelve false
        //implicará un error en el dibujado
        public bool draw(Entidad entidad, Posicion CameraPos)
        {
            //Obtención de imagen a dibujar
            char[][] image = entidad.corp_.getImage();
            
            
            //Hallado de region de dibujado
            Posicion framePos = new Posicion(getFramePosition(entidad.getPos(), CameraPos));
            framePos -= entidad.corp_.getOffset();
            Posicion maxFramePos = new Posicion(framePos.getX() + image[0].Length - 1,
                                                framePos.getY() + image.Count() - 1);

            Region drawRegion = new Region(maxFramePos, framePos);

            


            //Dibujado
            if (drawRegion.maxX() < sizeX_ &&
               drawRegion.maxY() < sizeY_ &&
               drawRegion.minX() >= 0 &&
               drawRegion.minY() >= 0)
            {
                for(int i = drawRegion.minY(); i<= drawRegion.maxY(); i++)
                {
                    for(int j= drawRegion.minX(); j<= drawRegion.maxX(); j++)
                    {
                        fr_[i][drawRegion.maxX()-j + drawRegion.minX()]=image[i-drawRegion.minY()][j-drawRegion.minX()];
                    }
                }
                return true;
            }

            return false;
        }

        public void printFrameWithBorders()
        {
            Console.WriteLine(SimpleBorder.getUpperBorder(sizeX_+2));
            for (int i = 0; i < sizeY_; i++)// Las filas hay que imprimirlas al revés
            {
                Console.Write(SimpleBorder.getBorder(3));
                for(int j=0; j<sizeX_; j++) {
                    Console.Write(fr_[i][j]);
                }
                Console.Write(SimpleBorder.getBorder(3));
                Console.WriteLine();
            }
            Console.WriteLine(SimpleBorder.getLowerBorder(sizeX_ + 2));
        }

        public void printFrame()
        {
            for (int i = 0; i < sizeY_; i++)
            {
                Console.WriteLine(fr_[i]);
            }
        }

    }
}
