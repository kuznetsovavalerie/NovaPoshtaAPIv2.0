using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace NovaPoshtaAPI.Tests
{
    [TestClass]
    public class SearchClientTests
    {
        [TestMethod]
        public async Task NovaPoshta_Search()
        {
            var client = new NovaPoshtaSearchClient("84fb76db9e5bb46e1f224003766f2ea5");

            var nonEmptyResult = await client.GetLocalitiesAsync("киї");

            Assert.AreNotEqual(nonEmptyResult.Length, 0);

            var threeItemsResult = await client.GetLocalitiesAsync("киї", 3);

            Assert.AreEqual(threeItemsResult.Length, 3);

            var warhousesResult = await client.GetWarehousesAsync(threeItemsResult[0].DeliveryCity);

            Assert.AreNotEqual(warhousesResult.Length, 0);

            try
            {
                var errorResult = await client.GetLocalitiesAsync("#$r");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Length > 0);
            }
        }
    }
}
