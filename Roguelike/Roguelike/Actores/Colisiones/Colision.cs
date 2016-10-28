using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Actores.Colisiones;
using Roguelike.Manejo_Planos;

/*Colisiones
 * Los Frames, al dibujar una entidad, comprueban antes
 * si había algo dibujado debajo y luego preguntan a las
 * entidades por ese objeto con el que colisionan.
 * Esta clase también contiene la información necesaria
 * para saber que puede colisionar con que.
 */

namespace Roguelike.Actores.Colisiones
{
    class Colision
    {
        //Punto en que se originó la colisión
        private Posicion colPos_;
        //La representación con la que ha colisionado
        private char colType_;
        //El cuerpo de la entidad que se está moviendo y ha colisionado
        private Cuerpo colCorpse_;

    }
}
