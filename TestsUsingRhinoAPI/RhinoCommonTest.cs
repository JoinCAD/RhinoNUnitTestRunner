using NUnit.Framework;
using Rhino.Geometry;

namespace TestsUsingRhinoAPI
{
    [TestFixture]
    public class RhinoCommonTest
    {
        [Test]
        public void TestThatNeedsRhinoCommon()
        {
            var bb = new BoundingBox(new Point3d(0, 0, 0), new Point3d(100, 100, 100));
            var brep = bb.ToBrep();
            var t = Transform.Translation(new Vector3d(30, 40, 50));
            brep.Transform(t);
            Assert.AreEqual(brep.GetBoundingBox(true).Center, new Point3d(80, 90, 100));
        }

        [Test]
        public void TestThatWillFail()
        {
            Assert.IsTrue(false);
        }
    }
}
