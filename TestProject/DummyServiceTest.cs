using InterfaceIntro.UnitTesting;

namespace TestProject
{
    public class DummyServiceTest
    {
        [Test]
        public void Test1()
        {
            var service = new DummyService();
            service.DoSomething("Hei");
        }

        /*
         Unit testing / enhetstesting
          - Korrekthet, kvalitet
          - Forenkle Feilsøking, spare tid
          - Regression test suite
          - Testdrevet utvikling
          - Test coverage
         */
    }
}