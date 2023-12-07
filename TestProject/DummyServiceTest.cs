using InterfaceIntro.UnitTesting;

namespace TestProject
{
    public class DummyServiceTest
    {
        [Test]
        public void Test1()
        {
            var service = new DummyService();
            service.DoSomething("H1ei");
        }

        [Test]
        public void Test2()
        {
            var service = new DummyService();
            service.DoSomething("1Hei");
        }

        
        [Test]
        public void Test3()
        {
            var service = new DummyService();
            service.DoSomething(null);
        }

        /*
         Unit testing / enhetstesting
          - Korrekthet, kvalitet
          - Forenkle Feilsøking, spare tid
          - Regression test suite / continuous integration 
          - Testdrevet utvikling
          - Test coverage
         */
    }
}