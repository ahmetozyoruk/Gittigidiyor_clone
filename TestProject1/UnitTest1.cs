using GittiGidiyor.Models;
using GittiGidiyor.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("Test Category")]
        [TestCase(0)]
        public void Urunler_Bosmu(int prm)
        {
            var aa = UrunService.Urunler.Count;
            Assert.IsTrue(aa == prm, "The actualCount was not greater than five");
        }


        [Test]
        public static async Task SimpleAsync()
        {
            List<Urun> aa;
            aa = UrunService.Instance.GetUrunlerAsync();
            Assert.IsTrue(aa.Count = 0, "The actualCount was not greater than five");
        }
    }
}