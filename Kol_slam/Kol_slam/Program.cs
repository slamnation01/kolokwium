using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kol_slam {
    class Program {
        static void Main(string[] args) {

            char input = 'x';

            Console.WriteLine("p: Prostokat");
            Console.WriteLine("t: Trojkat");
            Console.WriteLine("e: Exit");

            while (input != 'e') {

                input = Console.ReadKey().KeyChar;

                try{
                    switch (input) {
                        case 'p':
                            Console.WriteLine("Podaj boki a i b");
                            int a = Convert.ToInt32(Console.ReadLine());
                            int b = Convert.ToInt32(Console.ReadLine());
                            Rectangle rec = new Rectangle(a, b);
                            Console.WriteLine("({0},{1}) ({2},{3}) ({4},{5}) ({6},{7})",
                            rec.vertices[0].x, rec.vertices[0].y, rec.vertices[1].x, rec.vertices[1].y,
                            rec.vertices[2].x, rec.vertices[2].y, rec.vertices[3].x, rec.vertices[3].y
                            );
                            break;
                        case 't':
                            Console.WriteLine("Podaj bok i wyskosc");
                            int x = Convert.ToInt32(Console.ReadLine());
                            int h = Convert.ToInt32(Console.ReadLine());
                            Triangle tri = new Triangle(x, h);
                            Console.WriteLine("({0},{1}) ({2},{3}) ({4},{5})",
                            tri.vertices[0].x, tri.vertices[0].y, tri.vertices[1].x, tri.vertices[1].y,
                            tri.vertices[2].x, tri.vertices[2].y
                            );
                            break;

                    }                  
                } catch (Exception e) { }

                Console.WriteLine(input);
            }
        }
    }
}
