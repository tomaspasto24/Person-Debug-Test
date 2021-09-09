using NUnit.Framework;

using UnitTestAndDebug;

namespace UnitTestAndDebug
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {            
            string nameTest = "";
            string idTest = "5290517-9";
            
            Person personaPrueba = new Person(nameTest, idTest);
            Assert.AreEqual(personaPrueba.Name, null);
            Assert.AreEqual(personaPrueba.Id, "5290517-9");
        }

        [Test]
        public void Test2() // Cambiá el nombre para indicar qué estás probando
        {            
            const string nameTest = "Prueba2";
            const string idTest = "529.051.799";
            
            Person personaPrueba = new Person(nameTest, idTest);

            Assert.AreEqual(personaPrueba.Name, nameTest);
            Assert.AreEqual(personaPrueba.Id, "");
        }

        [Test]
        public void Test3() // Cambiá el nombre para indicar qué estás probando
        {            
            const string nameTest = "Prueba3";
            const string idTest = "";
            
            Person personaPrueba = new Person(nameTest, idTest);

            Assert.AreEqual(personaPrueba.Name, nameTest);
            Assert.AreEqual(personaPrueba.Id, "");
        }
    }
}