using System;
using System.Collections.Generic;
using Kol_slam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kol_slamTests {
    [TestClass]
    public class TriangleTests {
        [TestMethod]
        public void TestMethod1() {

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
        }
    }
}
