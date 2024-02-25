using System.Text;

namespace SmartHome.Tests
{
    [TestClass]
    public class HeizungsventilTests
    {
        [TestMethod]
        public void HeizungsventilOffen19_Aussen18()
        {

            bool expected = true;
            bool result;

            WettersensorMock wettersensorMock = new WettersensorMock(18, true, 35);

            Wohnung wohnung = new Wohnung(wettersensorMock);
            wohnung.SetTemperaturvorgabe("BadWC", 19);
            wohnung.SetPersonenImZimmer("BadWC", true);


            wohnung.GeneriereWetterdaten();


            var zimmer = wohnung.GetZimmer<Heizungsventil>("BadWC");
            result = zimmer.IsHeizungsventilOffen;

            Assert.AreEqual(expected, result);
        }
    }
}