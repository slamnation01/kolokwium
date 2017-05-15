using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kol_slam {
    public class Triangle {

        public List<Point> vertices = new List<Point>();

        public Triangle(int a, int b) {

            vertices = new List<Point> {
                new Point(0, 0),
                new Point(a, 0),
                new Point(0.5*a, b)
            };
        }

        public Triangle(Point org, int a, int b) {

            vertices = new List<Point> {
                org,
                new Point(org.x + a, org.y),
                new Point(org.x + 0.5*a, org.y + b)
            };
        }

    }
}
