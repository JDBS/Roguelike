using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike.Interfaz.Frame.Borders;
using Roguelike.Actores.Colisiones;
using Roguelike.Actores.Entidades;
using Roguelike.Interfaz.Frame;
using Roguelike.Manejo_Planos;
using Roguelike.Interfaz.Texturas;
using Roguelike.File_System.Encryption;
using Roguelike.File_System.DBMS.Campos;
using Roguelike.File_System.DBMS;
using System.IO;

namespace Roguelike
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Textura tex = new Textura(3, 3);
            tex.setLine(0, "·|·");
            tex.setLine(1, "·O·");
            tex.setLine(2, "·|·");
            Cuerpo corp = new Cuerpo(1,1,tex);

            Entidad ent = new Entidad(2, 2);

            ent.corp_ = corp;

            Frame myframe = new Frame(40, 20);

            myframe.draw(ent, new Posicion(0, 0));

            myframe.printFrameWithBorders();
            myframe.printFrame();
            myframe.printFrame();

            //Console.Read();

            ent.move(Direccion.arriba);
            myframe.clearFrame();
            myframe.draw(ent, new Posicion(0, 0));
            myframe.printFrame();
            //Console.Read();

            ent.move(Direccion.derecha);
            myframe.clearFrame();
            myframe.draw(ent, new Posicion(0, 0));
            myframe.printFrame();
            //Console.Read();

            ent.move(Direccion.derecha);
            myframe.clearFrame();
            myframe.draw(ent, new Posicion(0, 0));
            myframe.printFrame();


            ent.move(Direccion.abajo);
            myframe.clearFrame();
            myframe.draw(ent, new Posicion(0, 0));
            myframe.printFrame();
            Console.ReadKey(true);
            */


            BinaryWriter BW = new BinaryWriter(File.Open(@"pepe.txt", FileMode.OpenOrCreate));

            BW.Write(25);
            BW.Write(35);
            BW.Write(45);
            BW.Seek(4, SeekOrigin.Begin);
            BW.Write(55);
            BW.Close();

            BinaryReader BR = new BinaryReader(File.Open(@"pepe.txt", FileMode.Open));
            Console.WriteLine(BR.ReadInt32());
            Console.WriteLine(BR.ReadInt32());
            Console.WriteLine(BR.ReadInt32());

            BR.Close();

            Console.ReadKey(true);

        }
    }
}
