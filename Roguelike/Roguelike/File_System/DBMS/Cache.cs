using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Bloqueos:
 * Se realizan si:
 * -Se bloquea una TUpla en caché (para evitar inconsistencia) (lockTUpla())
 *  -En este caso es sólo para esa TUpla
 * -Cuando se está en proceso de guardado
 * -Cuando se está en un proceso de carga
 * 
 * Guardados:
 * -ForceSave (no recomendado usar a menos que se vaya a apagar la DB) Fuerza el guardado de la caché tal como está.
 * -Se pueden forzar llamado save() pero no se guardarán algunas TUplas si están bloqueadas
 * -Se guarda cuando
 * 
 * Inserciones:
 * -Se añaden a la caché hasta que esta se guarde
 * 
 * -Cargas:
 * -Se cargan del fichero correspondiente hasta que estos se guarden.
 */

namespace Roguelike.File_System.DBMS
{
    class Cache
    {
        List<Tabla> listaCache_= new List<Tabla>();     //TUplas en Cache
        List<TUpla> lockedTUplas_ = new List<TUpla>();  //TUplas en bloqueo
        int totalTuplas_ = 0;
        string saveDir_ = "";

        public Cache()
        {

        }

        public Cache(string saveDir)
        {
            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }
        }

        //fuerza un guardado incluso de las TUplas bloqueadas
        public void forceSave()
        {

        }

        //devuelve el número de elementos en caché bloqueados
        public int save()
        {
            //guardado de todo menos lo bloqueado (bloquea durante el proceso)
            return totalTuplas_;
        }

        public bool insert(TUpla tupla, string tabla)
        {
            //se inserta una tUpla y se espera si algo está bloqueado (bloquea durante el proceso)
            if (true)
            {
                totalTuplas_++;
                //si totalTuplas> X
                //  save()
                return true;
            }
            return false;
        }

        public bool load(TUpla tupla, string tabla)
        {
            //se carga una tUpla y se espera si algo está bloqueado (bloquea durante el proceso)
            if (true)
            {
                totalTuplas_++;
                return true;
            }
            //si totalTuplas > X
            //  save
            return false;
        }

        public bool insertTable(Tabla table)
        {
            return false;
        }

        public bool lockTUpla(TUpla tupla, string tabla)
        {
            return false;
        }
    }
}
