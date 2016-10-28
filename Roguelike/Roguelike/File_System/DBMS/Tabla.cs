using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;
using Roguelike.File_System.DBMS.Campos;
using System.IO;

namespace Roguelike.File_System.DBMS
{
    class Tabla
    {
        string nombre_;
        //int id_;


        struct atributo
        {
            public string nom_;         //Nombre de la columna
            public int tam_;            //Tamaño del atributo
            public campoTipo tipo_;     //Tipo del atributo
        }
        
        atributo[] atrL_;           //Array con información sobre cada atributo de las TUplas.
        public int clavePos_;       //Posición de clave primaria [0,N-1] (debe ser entero 32bits)


        List<TUpla> TUplaL_ = new List<TUpla>();    //Lista con las TUplas cacheadas en memoria
        

        int lastKey_; //Contendrá la última Clave Primaria creada en la tabla para una TUpla.


        public Tabla()
        {

        }

        public Tabla(string path)
        {
            //Acabar Loader o Saver
        }


        public Tabla(string nombreTabla ,campoTipo[] tipos,string[] nombres, int[] bytes, int keyPos)
        {
            if(tipos.Count()==nombres.Count() &&    //Comprobar que haya el mismo numero de
                tipos.Count()== bytes.Count())      //elementos en cada array
            {
                if(keyPos>0 && keyPos < tipos.Count()) {        //keyPos está en un rango que existe?
                    if (tipos[keyPos] == campoTipo.entero) {    //La clave es realmente entera?
                        nombre_ = nombreTabla;
                        atrL_ = new atributo[tipos.Count()];
                        for(int i=0; i< tipos.Count(); i++)
                        {
                            atrL_[i].tipo_=tipos[i];
                            atrL_[i].nom_ = nombres[i];
                            atrL_[i].tam_ = bytes[i];
                        }
                        lastKey_ = 0;
                    }else
                    {
                        throw new DBException("La clave primaria indicada no es entera");
                    }
                }
                else
                {
                    throw new DBException("La clave primaria indicada se sale de rango");
                }
            }
            else
            {
                throw new DBException("Al crear la tabla, no coincide el número de tipos, nombres y medidas de espacio.");
            }
        }


        //Actualiza la última clave y la retorna
        private int giveKey()
        {
            lastKey_++;
            return lastKey_;
        }

        /*
        public Tabla()
        {
            
        }

        //El nombre es el fichero donde se almacena
        public Tabla(string nombre, int id, TUpla atributos, int atributoClave)
        {
            //cargar lastId_ de fichero (si no existe es cero)
            
        }



        //Devuelve false si no logra insertarla
        //Se debe insertar la TUpla sin el Id( que se genera automáticamente)
        public void insertarTUpla(TUpla argTUpla)
        {
            //Comprobar que tiene campos compatibles
            if((argTUpla.Count()-1)== atributos_.Count())
            {
                for(int i=0; i < argTUpla.Count(); i++)
                {
                    if(atributos_.getCampo(i+1).getType() != argTUpla.getCampo(i).getType())
                    {
                        //Error: si algún campo correspondiente no coincide en el tipo no inserta
                        throw new DBException("La TUpla " + argTUpla.ToString() + " es incompatible con los atributos de la tabla " + nombre_ + ".");
                    }
                }
            }
            else
            {
                //Mostrar la TUPla y el nombre de la tabla (TODO)
                throw new DBException("Error al insertar la TUpla " + argTUpla.ToString() + " en la tabla " + nombre_ + ". No coincide con el número de campos requeridos.");
            }
            int clave = getNewId();
            TUpla auxTUpla = new TUpla(new CampoEntero(clave), argTUpla);
            claveL_.Add(clave);
            TUplaH_.Add(clave, auxTUpla);
        }



        //actualiza y genera un nuevo identificador numérico.
        private int getNewId()
        {
            lastKey_++;
            return lastKey_;
        }


        public TUpla getTUpla(int clave)
        {
            //mal, hay que comparar todas las de la caché. Sería más óptimo en hash.
            //Informarse sobre tablas hash en C#
            if (claveL_.Contains(clave))
            {
                return (TUpla)TUplaH_[clave];
            }
            else
            {
                //Error, TUpla "clave" no encontrada
                return new TUpla();
            }
        }
        */
    }

}
