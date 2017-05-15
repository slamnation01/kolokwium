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

        public void Translate(Point t) {
            foreach (Point pos in vertices) {
                pos.x += t.x;
                pos.y += t.y;
            }
        }

        public void Rotate(int deg) {

        }

    }
}
