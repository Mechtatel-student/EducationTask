using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner_It_is_possible_to_play
{
    [TestFixture]  
    class Class1
    {
        [Test]
        public static void TestIsOpened()
        {
            Field a = new Field(3,5);
            Assert.IsTrue(a.IsOpened(a.GetWidth(), 0) == false);
            Assert.IsFalse(a.IsOpened(0,a.GetHeigth()));
            a.OpenCell(0, 0);
            Assert.IsTrue(a.IsOpened(0, 0));
            a.OpenCell(1, 2);
            a.OpenCell(1, 4); 
            Assert.IsTrue(a.IsOpened(1,2));
            Assert.IsTrue(a.IsOpened(1,4));
            Assert.IsFalse(a.IsOpened(1,3));
            Assert.IsFalse(a.IsOpened(2,3));
            
        }

        [Test]
        public static void TestIsMine()
        {
            Field a = new Field(4, 5);
            
            Assert.IsTrue(a.IsMine(1,1)==false);
            Assert.IsFalse(a.IsMine(5,5));

            a.SetMine(1, 1);
            Assert.IsTrue(a.IsMine(1,1));
            
            a.SetMine(5,5);
            a.SetMine(2, 3);
            
            Assert.IsFalse(a.IsMine(5,5));
            Assert.IsTrue(a.IsMine(2, 3));

        }

        [Test]
        public static void TestIsEmpty()
        {
            Field a = new Field(5, 5);
            Assert.IsTrue(a.IsEmpty(5,5) == false);
            Assert.IsFalse(a.IsEmpty(1,5));
            a.OpenCell(0, 0);
            Assert.IsTrue(a.IsEmpty(0,0));
            a.OpenCell(1, 2);
            a.OpenCell(1, 4);
            a.SetMine(1, 1);
            a.SetMine(5, 5);
            a.SetMine(2, 3);
           
            Assert.IsFalse(a.IsEmpty(1, 1));
            Assert.IsFalse(a.IsEmpty(2, 3));
            Assert.IsFalse(a.IsEmpty(5, 5));
            Assert.IsTrue(a.IsEmpty(1, 2));
            Assert.IsTrue(a.IsEmpty(1, 4));
            Assert.IsTrue(a.IsEmpty(1, 3));

        }
        [Test]
        public static void TestOpenCell()
        {
            Field a = new Field(5, 5);
            Assert.IsTrue(a.OpenCell(1,4));
            Assert.IsTrue(a.OpenCell(1,4));
            Assert.IsTrue(a.OpenCell(2,3));
            Assert.IsFalse(a.OpenCell(5,5));
        }

        [Test]
        public static void TestSetMine()
        {
            Field a = new Field(5, 5);
            Assert.IsTrue(a.SetMine(1, 4));
            Assert.IsTrue(a.SetMine(1, 4));
            Assert.IsTrue(a.SetMine(2, 3));
            Assert.IsFalse(a.SetMine(5, 5));
        }

        [Test]
        public static void TestCountMineAround()
        {
            Field a = new Field(5,5);
            a.SetMine(1, 1);
            a.SetMine(0, 2);
            a.SetMine(0, 3);
            a.SetMine(4,1);
            a.SetMine(4,2);
            Assert.AreEqual(a.CountMineAround(0, 0), 1);
            Assert.AreEqual(a.CountMineAround(0, 1), 2);
            Assert.AreEqual(a.CountMineAround(1, 2), 3);
            Assert.AreEqual(a.CountMineAround(2,4), 0);
            Assert.AreEqual(a.CountMineAround(4,0), 1);
            Assert.AreEqual(a.CountMineAround(0, 2), 2);
            Assert.AreEqual(a.CountMineAround(5,5), 0);



        }

        [Test]
        public static void TestCountOpenedCells()
        {
            Field a = new Field(5,5);
            a.OpenCell(0, 0);
            a.OpenCell(1, 0);
            a.OpenCell(1, 1);
            a.OpenCell(1, 2);
            a.OpenCell(5,5);
            Assert.AreEqual(a.CountOpenedCells(), 4);
            a.OpenCell(0, 0);
            a.OpenCell(2, 2);
            Assert.AreEqual(a.CountOpenedCells(), 5);

        }

        [Test]
        public static void TestCountCellsWithMine()
        {
            Field a = new Field(5,5);
            a.SetMine(0, 0);
            a.SetMine(1, 0);
            a.SetMine(1, 1);
            a.SetMine(1, 2);
            a.SetMine(5, 5);
            Assert.AreEqual(a.CountCellsWithMine(), 4);
            a.SetMine(0, 0);
            a.SetMine(2, 2);
            Assert.AreEqual(a.CountCellsWithMine(), 5);

        }

        [Test]
        public static void TestCountOpenedCellsWithMine()
        {
            Field a = new Field(5,5);
            a.OpenCell(0, 0);
            a.OpenCell(1, 0);
            a.OpenCell(1, 1);
            a.OpenCell(1, 2);
            a.OpenCell(1, 5);
            a.SetMine(1, 1);
            a.SetMine(1, 2);
            a.SetMine(1, 3);
            a.SetMine(1, 5);
            Assert.AreEqual(a.CountOpenedCellsWithMine(), 2);
            a.OpenCell(0, 0);
            a.OpenCell(2, 2);
            a.SetMine(1,1);
            a.SetMine(2, 2);
            Assert.AreEqual(a.CountOpenedCellsWithMine(), 3);

        }

        [Test]
        public static void TestCountEmptyOpenedCells()
        {
            Field a = new Field(5,5);
            a.OpenCell(0, 0);
            a.OpenCell(1, 0);
            a.OpenCell(1, 1);
            a.OpenCell(1, 2);
            a.OpenCell(1, 5);
            a.SetMine(1, 1);
            a.SetMine(1, 2);
            a.SetMine(1, 3);
            a.SetMine(1, 5);
            Assert.AreEqual(a.CountOpenedEmptyCells(), 2);
            a.OpenCell(0, 0);
            a.OpenCell(2, 2);
            a.SetMine(1, 1);
            a.SetMine(2, 2);
            Assert.AreEqual(a.CountOpenedEmptyCells(), 2);

        }
    }
}
