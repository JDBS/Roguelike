using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.File_System.DBMS.Exception;

namespace Roguelike.File_System.DBMS.Campos
{
    public enum campoTipo
    {
        nulo,       //null
        entero,     //int32 o int64 (cuidado con lo que se guarda)
        flotante,   //float
        doble, //double
        cadena,     //cadena
        caracter,
        fecha       //fecha
    };

    //Clase Base para campos
    public class Campo
    {
        protected int size_; //el número de bytes existentes
        protected campoTipo tipo_;  //de tipo nulo

        public Campo()
        {
            size_ = 0;
            tipo_ = campoTipo.nulo;
        }


        public virtual void set(int value)
        {
            throw new DBException("El tipo del campo: ["+ tipo_ + "] no coincide con el introducido [int]");
        }
        

        public virtual void set(float value)
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no coincide con el introducido [float]");
        }

        public virtual void set(double value)
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no coincide con el introducido [double]");
        }

        public virtual void set(char value)
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no coincide con el introducido [char]");
        }

        public virtual void set(string value)
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no coincide con el introducido [string]");
        }

        public virtual void set(DateTime value)
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no coincide con el introducido [DateTime]");
        }




        public virtual int getInt()
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no retorna [int]");
        }

        public virtual float getFloat()
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no retorna [float]");
        }

        public virtual double getDouble()
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no retorna [double]");
        }

        public virtual char getChar()
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no retorna [char]");
        }

        public virtual string getString()
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no retorna [string]");
        }

        public virtual DateTime getDate()
        {
            throw new DBException("El tipo del campo: [" + tipo_ + "] no retorna [DateTime]");
        }



        public virtual campoTipo getType()
        {
            return tipo_;
        }


        public override string ToString()
        {
            return "";
        }

        public virtual int getSizeBytes()
        {
            return 0;
        }

    }
 
}
