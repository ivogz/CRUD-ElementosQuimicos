using Entidades;
namespace TestUnitario
    
{
    [TestClass]
    public class Elemento_Test
    {
        [TestMethod]
        public void TestIgualdad()
        {
            //arrange
            Elemento e1 = new Gas(1, "Hidrogeno", "H");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2; 

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod] 
        public void TestIgualdad1()
        {

            //arrange
            Elemento e1 = new Gas(1, "Hidrogeno", "Hi");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad2()
        {

            //arrange
            Elemento e1 = new Gas(1, "Hidrogenos", "H");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad3()
        {

            //arrange
            Elemento e1 = new Gas(2, "Hidrogeno", "H");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad4()
        {

            //arrange
            Elemento e1 = new Gas(1, "Hidrogenos", "Hi");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad5()
        {

            //arrange
            Elemento e1 = new Gas(2, "Hidrogeno", "Hi");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad6()
        {

            //arrange
            Elemento e1 = new Gas(2, "Hidrogenos", "H");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad7()
        {

            //arrange
            Elemento e1 = new Gas(12, "Oro", "Au");
            Elemento e2 = new Gas(1, "Hidrogeno", "H");

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsFalse(rta);

        }

        [TestMethod]
        public void TestIgualdad8()
        {

            //arrange
            Elemento e1 = new Gas(12, "Oro", "Au", 2,2);
            Elemento e2 = new Gas(1, "Hidrogeno", "H",2,2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad9()
        {

            //arrange
            Elemento e1 = new Gas(12, "Oro", "Au", 7, 2);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsFalse(rta);

        }

        [TestMethod]
        public void TestIgualdad10()
        {

            //arrange
            Elemento e1 = new Gas(12, "Oro", "Au", 2, 7);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsFalse(rta);

        }

        [TestMethod]
        public void TestIgualdad11()
        {

            //arrange
            Elemento e1 = new Gas(12, "Oro", "Au", 3, 5);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsFalse(rta);

        }

        [TestMethod]
        public void TestIgualdad12()
        {

            //arrange
            Elemento e1 = new Gas(1, "Oro", "H", 2, 2);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad13()
        {

            //arrange
            Elemento e1 = new Gas(1, "Oro", "Hg", 2, 2);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad14()
        {

            //arrange
            Elemento e1 = new Gas(1, "Oro", "Hg", 4, 5);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsTrue(rta);

        }

        [TestMethod]
        public void TestIgualdad15()
        {

            //arrange
            Elemento e1 = new Metal(1, "Hidrogeno", "H", ECategoriasMetales.MetalPostransicional);
            Elemento e2 = new Gas(1, "Hidrogeno", "H", 2, 2);

            //act
            bool rta = e1 == e2;

            //assert
            Assert.IsFalse(rta);

            //me dio mal la prueba y ya lo solucione :D!!

        }

    }
}