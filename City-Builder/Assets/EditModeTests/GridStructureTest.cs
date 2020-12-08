using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GridStructureTest
    {
        private GridStructure _gridStructure;

        [OneTimeSetUp]
        public void Init()
        {
            _gridStructure = new GridStructure(3);
        }

        // A Test behaves as an ordinary method
        [Test]
        public void CalculateGridStructurePasses()
        {
            //arrange
            //act
            Vector3 position = Vector3.zero;
            //assert
            Vector3 returnPos = _gridStructure.CalculateGridStructure(position);

            Assert.AreEqual(Vector3.zero, returnPos);
        }

        [Test]
        public void CalculateGridStructureFloatPasses()
        {
            //arrange
            //act
            Vector3 position = Vector3.zero;
            //assert
            Vector3 returnPos = _gridStructure.CalculateGridStructure(position);

            Assert.AreEqual(Vector3.zero, returnPos);
        }

    }
}

