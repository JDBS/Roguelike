using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike.Interfaz.Frame.Borders
{
    static class SimpleBorder
    {
        /// <summary>
        /// Obtiene el caracter que corresponde al borde.
        /// El caracter que devuelve corresponde a la suma de los
        /// valores de sus conexiones:
        /// -Superior:1
        /// -Inferior:2
        /// -Izquierdo:4
        /// -Derecho:8
        /// </summary>
        /// <param name="tipo">Tipo</param>
        /// <returns></returns>
        public static char getBorder(int tipo)
        {
            switch (tipo)
            {
                case 0://Sin Conexión
                    return '·';
                case 1://Superior
                    return '╵';
                case 2://Inferior
                    return '╷';
                case 3://Superior-Inferior
                    return '│';
                case 4://Izquierdo
                    return '╴';
                case 5://Izquierdo-Superior
                    return '┘';
                case 6://Izquierdo-Inferior
                    return '┐';
                case 7://Izquierdo-Inferior-Superior
                    return '┤';
                case 8://Derecho
                    return '╶';
                case 9://Derecho-Superior
                    return '└';
                case 10://Derecho-Inferior
                    return '┌';
                case 11://Derecho-Inferior-Superior
                    return '├';
                case 12://Derecho-Izquierdo
                    return '─';
                case 13://Derecho-Izquierdo-Superior
                    return '┴';
                case 14://Derecho-Izquierdo-Inferior
                    return '┬';
                case 15://Derecho-Izquierdo-Inferior-Superior
                    return '┼';
                default:
                    return '#';
            }
        }

        public static string getUpperBorder(int size)
        {
            string printBorder = "";
            printBorder += getBorder(10);
            for (int j = 0; j < (size - 2); j++)
            {
                printBorder += getBorder(12);
            }
            printBorder += getBorder(6);
            return printBorder;
        }

        public static string getLowerBorder(int size)
        {
            string printBorder = "";
            printBorder += getBorder(9);
            for (int j = 0; j < (size - 2); j++)
            {
                printBorder += getBorder(12);
            }
            printBorder += getBorder(5);
            return printBorder;
        }
    }
}
