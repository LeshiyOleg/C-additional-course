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
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
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
            int i = 0;

            while (i<6)
            {
                Turtle.Move(50);
                Turtle.Turn(60);
                i++;
            }
        }
    }
}
