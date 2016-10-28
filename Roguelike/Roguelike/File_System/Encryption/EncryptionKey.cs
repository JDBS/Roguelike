using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike.File_System.Encryption
{
    class EncryptionKey
    {
        //Values for Encryption
        struct EncryptionValues
        {
            public string password_;
            public DateTime date_;
            public string localMachine_; // Only if local machine linked encryption
        };

        private int key_ = 0;


        public int key
        {
            get
            {
                return key_;
            }
            private set
            {
                key_ = value;
            }
        }

        
        /// <summary>
        /// No se debe usar este constructor, dará error.
        /// </summary>
        public EncryptionKey()
        {
            throw new Exception("No se puede generar una clave sin parámetros");
        }


        public EncryptionKey(string password, DateTime date)
        {
            EncryptionValues aux = new EncryptionValues();
            aux.password_ = password;
            aux.date_ = date;
            generateKey(aux);
        }

        public EncryptionKey(string password, DateTime date, bool localmachine)
        {
            EncryptionValues aux = new EncryptionValues();
            aux.password_ = password;
            aux.date_ = date;

            if (localmachine)
            {
                aux.localMachine_ = System.Environment.MachineName;
            }else
            {
                aux.localMachine_ = null;
            }

            generateKey(aux);
        }

        //Genera la clave con los valores obtenidos
        private void generateKey(EncryptionValues values)
        {
            Int64 auxInt=0;

            //Password
            for (int i = 0; i < values.password_.Length; i++)
            {
                auxInt += (values.password_[i] * i);
                if (auxInt >= int.MaxValue)
                {
                    auxInt = auxInt % int.MaxValue;
                }
            }

            //Fecha
            auxInt += values.date_.GetHashCode() + 5 * DateTime.Now.GetHashCode();
            if (auxInt >= int.MaxValue)
            {
                auxInt = auxInt % int.MaxValue;
            }

            //Local Machine
            if (values.localMachine_ != null)
            {
                for (int i = 0; i < values.localMachine_.Length; i++)
                {
                    auxInt += (values.localMachine_[i] * i);
                    if (auxInt >= int.MaxValue)
                    {
                        auxInt = auxInt % int.MaxValue;
                    }
                }
            }

            //Key Generada
            key_ = Convert.ToInt32(auxInt);
        }




        public override string ToString()
        {
            return key_.ToString();
        }


        static public explicit operator int(EncryptionKey val)
        {
            return val.key_;
        }

        static public explicit operator Int64(EncryptionKey val)
        {
            return val.key_;
        }
    }
}
