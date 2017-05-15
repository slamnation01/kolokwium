using System;
using System.Collections.Generic;
using Kol_slam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kol_slamTests {
    [TestClass]
    public class RectangleTests {


        [TestMethod]
        [TestCategory("Logic")]
        public void BuildRectangleTest() {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, 4),
                new Point(0, 4)
            };

            Rectangle rec = new Rectangle(2, 4);

            foreach (Point pos in rec.vertices) {
                if (!expectedVerticles.Contains(pos)) {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void BuildRectangleWithOrginTest() {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(1, 1),
                new Point(3, 1),
                new Point(3, 5),
                new Point(1, 5)
            };

            Rectangle rec = new Rectangle(new Point(1, 1), 2, 4);

            foreach (Point pos in rec.vertices) {
                if (!expectedVerticles.Contains(pos)) {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void TranslateRectangleTest() {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(1, 1),
                new Point(3, 1),
                new Point(3, 5),
                new Point(1, 5)
            };

            Rectangle rec = new Rectangle(2, 4);
            rec.Translate(new Point(1, 1));

            foreach (Point pos in rec.vertices) {
                if (!expectedVerticles.Contains(pos)) {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void RotateRectangleTest() {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, -2),
                new Point(0, -2)
            };

            Rectangle rec = new Rectangle(2, 2);
            rec.Rotate(90);

            foreach (Point pos in rec.vertices) {
                if (!expectedVerticles.Contains(pos)) {
                    Assert.Fail();
                }
            }
        }
    }


}
