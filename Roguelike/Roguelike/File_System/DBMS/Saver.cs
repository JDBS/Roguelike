using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Roguelike.File_System.DBMS.Campos;

/*Responsable de guardar y encriptar la información
 */
namespace Roguelike.File_System.DBMS
{
    static class Saver
    {
        

        static void save(Campo campo, string ruta, int pos)
        {
            BinaryWriter BW = new BinaryWriter(File.Open(ruta, FileMode.OpenOrCreate));

            BW.Seek(pos, SeekOrigin.Begin);
            


            BW.Close();
        }
        static void save(TUpla tupla, string ruta, int pos)
        {
            for(int i=0; i<tupla.Count(); i++)
            {
                int offset = 0;
                save(tupla[i], ruta, pos + offset);

                //Caso String
                if(tupla[i] is CampoString) {
                    CampoString a = (CampoString)tupla[i];
                    
                }
            }
        }

        
    }
}
