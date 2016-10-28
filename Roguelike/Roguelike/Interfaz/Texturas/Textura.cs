using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike.Interfaz.Texturas
{
    class Textura
    {
        private char[][] tx_;
        //List<string> tx_ = new List<string>();
        private int sizeX_;
        private int sizeY_;

        public Textura() {
            tx_ = null;
            sizeX_ = 0;
            sizeY_ = 0;
        }

        public Textura(char image)
        {
            tx_ = new char[1][];
            tx_[0] = new char[1];
            tx_[0][0] = image;
        }

        public Textura(int size_x, int size_y)
        {
            sizeX_ = size_x;
            sizeY_ = size_y;

            tx_ = new char[sizeY_][];
            for (int i=0; i < size_y; i++)
            {
                tx_[i] = new char[sizeX_];
                for (int j = 0; j < size_x; j++)
                {
                    tx_[i][j] = ' ';
                }
            }
        }
        // Cambia una línea de la textura
        public void setLine(int linea_numero, string linea_texto)
        {
            if (linea_texto.Length <= sizeX_)
            {
                if (linea_numero < sizeY_ && linea_numero >=0)
                {
                    for (int j=0; j< linea_texto.Length; j++) { 
                        tx_[linea_numero][j] = linea_texto[j];
                    }
                }
            }
        }

        public int getSizeX()
        {
            return sizeX_;
        }

        public int getSizeY()
        {
            return sizeY_;
        }

        public char[][] getImage()
        {
            return tx_;
        }
        /*
        public List<string> getImage()
        {
            return tx_;
        }
        */
    }
}
