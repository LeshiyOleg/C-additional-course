using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining_ver_2
{
    class Program
    {
        static void WriteT(int sizeT)
        {
            // Буква "Т" начало
            Turtle.Angle = 0;
            Turtle.Move(sizeT);
            //Turtle.Angle = 270;
            Turtle.TurnLeft();
            Turtle.Move(sizeT / 3);
            Turtle.Angle = 90;
            Turtle.Move(2 * sizeT / 3);
            // Буква "Т" конец
        }
        static void WriteO(int sizeO)
        {
            // Буква "О" начало
             Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(sizeO);
                Turtle.TurnRight();
            }
            // Буква "О" конец
        }

        static void WriteP(int sizeP)
        {
            // Буква "P" начало
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(sizeP);
                Turtle.TurnRight();
            }
            Turtle.Angle = 180;
            Turtle.Move(sizeP);
            // Буква "P" конец
        }

        static void WriteK(int sizeK)
        {
            // Буква K начало
            Turtle.Angle = 0;
            Turtle.Move(sizeK);
            Turtle.X = 100;
            Turtle.Y = 100 - sizeK/2;
            Turtle.Angle = 30;
            Turtle.Move(sizeK/2 / 0.87);
            Turtle.X = 100;
            Turtle.Y = 100 - sizeK/2;
            Turtle.Angle = 150;
            Turtle.Move(sizeK/2 / 0.87);
            // Буква K конец
        }

        static void WriteC(int sizeC)
        {
            // Буква "C" начало
            Turtle.X = 140 + sizeC;
            Turtle.Angle = -90;
            for (int i = 0; i < 3; i++)
            {
                Turtle.Move(sizeC);
                Turtle.TurnRight();
            }
            // Буква "C" конец
        }
        static void Main(string[] args)
        {
            //Turtle.Speed = 8;
            /* int n = 0;
            while (n < 4)
            {
                int r = 0;

                while (r < 2)
                {
                    Turtle.Move(30);
                    Turtle.TurnRight();
                    r++;
                }
                int l = 0;
                while (l < 2)
                {
                    Turtle.Move(30);
                    Turtle.TurnLeft();
                    l++;
                }
                n++; 
            }
            */


            //int i = 0;

            //while (i < 6)
            //{
            //    turtle.move(50);
            //    turtle.turn(60);
            //    i++;
            //}


            //for (int i=0; i<4; i++)
            //{
            //    turtle.move(20);
            //    turtle.turnright();
            //    turtle.move(20);
            //    turtle.turnright();
            //    turtle.move(20);
            //    turtle.turnleft();
            //    turtle.move(20);
            //    turtle.turnleft();
            //}

            // Торт

            //Turtle.Speed = 8;
            //Turtle.X = 200;
            //Turtle.Y = 200;

            //WriteT(60);

            //Turtle.X = 260;
            //Turtle.Y = 200;

            //WriteO(30);

            //Turtle.X = 330;
            //Turtle.Y = 200;

            //WriteP(30);

            //Turtle.X = 410;
            //Turtle.Y = 200;

            //WriteT(30);

            // Имя Ксю

            Turtle.Speed = 9;
            Turtle.X = 100;
            Turtle.Y = 100;

            WriteK(60);

            Turtle.X = 140;
            Turtle.Y = 100;

            WriteC(30);

            Turtle.X = 180;
            Turtle.Y = 100;

            Turtle.Angle = 0;
            Turtle.Move(30);
            Turtle.X = 180;
            Turtle.Y = 85;
            Turtle.Angle = 90;
            Turtle.Move(15);
            Turtle.X = 195;
            Turtle.Y = 100;
            WriteO(30);


        }
    }
}

