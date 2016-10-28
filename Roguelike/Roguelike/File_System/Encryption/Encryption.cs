using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike.File_System.Encryption
{
    class Encryption
    {
        private EncryptionKey key_;

        public Encryption()
        {
            throw new Exception("No tiene sentido Generar enctriptación sin clave");
        }

        public Encryption(EncryptionKey key)
        {
            key_ = key;
        }
        

        private Random getSeed(int encSum, int pos)
        {
            return new Random((int)key_ + encSum + pos);
        }



        //Encriptado
        public byte[] encrypt(byte[] b, int encSum, int pos)
        {
            byte[] aux = new byte[b.Length];
            Random sum = getSeed(encSum, pos);

            for (int i = 0; i < b.Length; i++)
            {
                aux[i] = (byte)(b[i] + sum.Next());
            }

            return aux;
        }

        public int encrypt(int value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = encrypt(aux, encSum, pos);

            //Transformación en Entero
            return BitConverter.ToInt32(aux, 0);
        }

        public long encrypt(long value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = encrypt(aux, encSum, pos);

            //Transformación en Long
            return BitConverter.ToInt64(aux, 0);
        }


        public float encrypt(float value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = encrypt(aux, encSum, pos);

            //Transformación en Float
            return BitConverter.ToSingle(aux, 0);
        }
            

        public double encrypt(double value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = encrypt(aux, encSum, pos);

            //Transformación en Double
            return BitConverter.ToDouble(aux, 0);
        }

        public char encrypt(char value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = encrypt(aux, encSum, pos);

            //Transformación en Char
            return BitConverter.ToChar(aux, 0);
        }

        public string encrypt(string value, int encSum, int pos)
        {
            Random sum = getSeed(encSum, pos);

            string auxS = "";

            for (int i=0; i<value.Length; i++)
            {
                //Transformación en bytes
                byte[] aux = BitConverter.GetBytes(value[i]);

                //Desncriptación
                aux = encrypt(aux, encSum, pos);

                //Transformación en Char
                auxS += BitConverter.ToChar(aux, 0);
            }

            return auxS;
        }


        public DateTime encrypt(DateTime value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value.Ticks);

            //Desncriptación
            aux = encrypt(aux, encSum, pos);

            //Transformación en DateTime
            return new DateTime(BitConverter.ToInt64(aux, 0));
        }

    



        //Desencriptado
        public byte[] decrypt(byte[] b, int encSum, int pos)
        {
            byte[] aux = new byte[b.Length];
            Random sum = getSeed(encSum, pos);

            for (int i = 0; i < b.Length; i++)
            {
                aux[i] = (byte)(b[i] - sum.Next());
            }

            return aux;
        }

        public int decrypt(int value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = decrypt(aux, encSum, pos);

            //Transformación en Entero
            return BitConverter.ToInt32(aux, 0);
        }

        public long decrypt(long value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = decrypt(aux, encSum, pos);

            //Transformación en Long
            return BitConverter.ToInt64(aux, 0);
        }

        public float decrypt(float value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = decrypt(aux, encSum, pos);

            //Transformación en Fkiat
            return BitConverter.ToSingle(aux, 0);
        }

        public double decrypt(double value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = decrypt(aux, encSum, pos);

            //Transformación en Double
            return BitConverter.ToDouble(aux, 0);
        }

        public char decrypt(char value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value);

            //Desncriptación
            aux = decrypt(aux, encSum, pos);

            //Transformación en Char
            return BitConverter.ToChar(aux, 0);
        }

        public string decrypt(string value, int encSum, int pos)
        {
            Random sum = getSeed(encSum, pos);

            string auxS = "";

            for (int i = 0; i < value.Length; i++)
            {
                //Transformación en bytes
                byte[] aux = BitConverter.GetBytes(value[i]);

                //Desncriptación
                aux = encrypt(aux, encSum, pos);

                //Transformación en Char
                auxS += BitConverter.ToChar(aux, 0);
            }

            return auxS;
        }

        public DateTime decrypt(DateTime value, int encSum, int pos)
        {
            //Transformación en bytes
            byte[] aux = BitConverter.GetBytes(value.Ticks);

            //Desncriptación
            aux = decrypt(aux, encSum, pos);

            //Transformación en DateTime
            return new DateTime(BitConverter.ToInt64(aux, 0));
        }

    }
}
