using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

namespace Tests
{
    public class CellTest 
    {
        [Test]
        public void CellSetGameObjectPass()
        {
            Cell cell = new Cell();

            cell.ConstructCell(new GameObject());

            Assert.IsTrue(cell.IsTaken);
        }

        [Test]
        public void CellSetNullObjectFail()
        {
            Cell cell = new Cell();

            cell.ConstructCell(null);

            Assert.IsFalse(cell.IsTaken);
        }
    }
}