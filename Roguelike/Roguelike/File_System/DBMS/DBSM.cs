using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Campos;
/*TODO:
 * Se necesitará un método bool exist(indice de campo(entero), coincidecia string)
 * para comprobar si un determinado dato existe en la DB sin petar la caché (independiente de ella)
 */
namespace Roguelike.File_System.DBMS
{
    class DBSM
    {
        private Cache cache_ = new Cache(@"data\");
        private bool close_ = false;
        //Lista de ficheros de carga y sus nombres asignados de búsqueda
        public DBSM()
        {

        }

        public void run()
        {
            while (!close_)
            {
                System.Threading.Thread.Sleep(5000);
                cache_.save();
            }
            /*
             * while(!close){
             *   sleep 1 sec
             *   cache.save()
             * }
             */
        }

        public void stop()
        {
            cache_.forceSave();
        }

        public bool save(Campo insercion)
        {
            return false;
        }

        public void insertar()
        {

        }

        public Campo load()
        {
            return new Campo();
        }

    }
}
