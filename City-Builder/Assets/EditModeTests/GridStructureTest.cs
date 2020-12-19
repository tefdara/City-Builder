using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

namespace Tests
{
    public class GridStructureTest
    {
        private GridStructure _gridStructure;

        [OneTimeSetUp]
        public void Init()
        {
            _gridStructure = new GridStructure(3, 100,100);
        }

        #region PositionTest

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
        public void CalculateGridStructureFloatFail()
        {
            //arrange
            //act
            Vector3 position = new Vector3(3.2f, 0, 0);
            //assert
            Vector3 returnPos = _gridStructure.CalculateGridStructure(position);

            Assert.AreNotEqual(Vector3.zero, returnPos);
        }

        #endregion


        #region IsTakenTest


        [Test]
        public void PlaceStructure303IsTakenPass()
        {
            Vector3 pos = new Vector3(3, 0, 0);

            _gridStructure.CalculateGridStructure(pos);

            GameObject go = new GameObject("testGO");

            _gridStructure.PlaceObjectOnGrid(pos, go);

            Assert.IsTrue(_gridStructure.IsCellTaken(pos));
        }


        [Test]
        public void PlaceStructureAtMaxIndexAndCheckIsTaken()
        {
            Vector3 pos = new Vector3(297, 0, 297);


            _gridStructure.CalculateGridStructure(pos);

            GameObject go = new GameObject("testGO");

            _gridStructure.PlaceObjectOnGrid(pos, go);

            Assert.IsTrue(_gridStructure.IsCellTaken(pos));
        }

        [Test]
        public void PlaceStructureAtMinIndexAndCheckIsTaken()
        {
            Vector3 pos = new Vector3(0, 0, 0);


            _gridStructure.CalculateGridStructure(pos);

            GameObject go = new GameObject("testGO");

            _gridStructure.PlaceObjectOnGrid(pos, go);

            Assert.IsTrue(_gridStructure.IsCellTaken(pos));
        }

        [Test]
        public void PlaceStructureAtOutOfBoundIndexAndCheckIsTaken()
        {
            Vector3 pos = new Vector3(302, 0, 302);

            Assert.Throws<IndexOutOfRangeException>(() => _gridStructure.IsCellTaken(pos));
        }

        #endregion

    }

}

