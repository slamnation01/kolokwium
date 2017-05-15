using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kol_slam {
    public class Rectangle {

        public List<Point> vertices = new List<Point>();

        public Rectangle(int a, int b) {

            vertices = new List<Point> {
                new Point(0, 0),
                new Point(a, 0),
                new Point(a, b),
                new Point(0, b)
            };
        }

        public Rectangle(Point org, int a, int b) {

            vertices = new List<Point> {
                org,
                new Point(org.x + a, org.y),
                new Point(org.x + a, org.y + b),
                new Point(org.x, org.y + b)
            };
        }

    }
}
