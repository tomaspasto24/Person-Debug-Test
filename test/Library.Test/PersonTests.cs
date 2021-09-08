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
            string nameExpected = "";
            string idExpected = "52905179-9";
            
            Person personaPrueba = new Person("Prueba", "5.290.517-9");
            Assert.AreEqual(personaPrueba.Name, nameExpected);
            Assert.AreEqual(personaPrueba.ID, idExpected);
        }

        [Test]
        public void Test2() // Cambiá el nombre para indicar qué estás probando
        {            
            const string nameExpected = "Prueba2";
            const string idExpected = "529.051.799";
            
            Person personaPrueba = new Person(nameExpected, idExpected);

            Assert.AreEqual(personaPrueba.Name, nameExpected);
            Assert.AreEqual(personaPrueba.ID, idExpected);
        }

        [Test]
        public void Test3() // Cambiá el nombre para indicar qué estás probando
        {            
            const string nameExpected = "Prueba3";
            const string idExpected = "";
            
            Person personaPrueba = new Person(nameExpected, idExpected);

            Assert.AreEqual(personaPrueba.Name, nameExpected);
            Assert.AreEqual(personaPrueba.ID, idExpected);
        }
    }
}