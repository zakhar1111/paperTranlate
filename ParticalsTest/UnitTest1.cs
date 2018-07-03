using System;
using Particals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParticalsTest
{
    [TestClass]
    public class UnitTest1
    {
        Particles arr;

        [TestMethod]
        public void TestAdd()
        {
            arr.Add(new Particle());
            Assert.AreEqual(2, arr.Count);
        }
        public UnitTest1()
        {
            //create non empty List
            arr = new Particles();
        }
        [TestMethod]
        public void RemoveParticle()
        {
            var removable = arr[0];
            arr.Remove(removable);
            Assert.AreEqual(0, arr.Count);
        }

    }
}
