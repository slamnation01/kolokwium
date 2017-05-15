using System;
using System.Collections.Generic;
using Kol_slam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kol_slamTests {
    [TestClass]
    public class TriangleTests {

        [TestMethod]
        [TestCategory("Logic")]
        public void BuildTriangleTest() {
            List<Point> expectedVerticles = new List<Point>
            {
            new Point(0, 0),
            new Point(4, 0),
            new Point(2, 3)
        };

            Triangle tri = new Triangle(4, 3);

            foreach (Point pos in tri.vertices) {
                if (!expectedVerticles.Contains(pos)) {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        [TestCategory("Logic")]
        public void BuildTriangleWithOrginTest() {
            List<Point> expectedVerticles = new List<Point>
            {
                new Point(1, 1),
                new Point(5, 1),
                new Point(3, 4)
            };

            Triangle tri = new Triangle(new Point(1, 1), 4, 3);

            foreach (Point pos in tri.vertices) {
                if (!expectedVerticles.Contains(pos)) {
                    Assert.Fail();
                }
            }
        }
    }
}

