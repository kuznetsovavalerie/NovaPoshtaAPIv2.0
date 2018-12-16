using NovaPoshtaAPI.HttpModels;
using NovaPoshtaAPI.Result;
using NovaPoshtaAPI.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NovaPoshtaAPI
{
    public class NovaPoshtaSearchClient
    {
        private HttpService _httpService;

        public NovaPoshtaSearchClient(string apiKey)
        {
            this._httpService = new HttpService(apiKey);
        }

        public async Task<LocalitySearchItem[]> GetLocalitiesAsync(string searchKey, int? limit = null)
        {
            var request = new LocalitySearchRequest(searchKey, limit);
            var response = await this._httpService.GetData<LocalitySearchResponse>("Address/searchSettlements/", request);
            
            return response.data[0].Addresses;
        }

        public async Task<WarehouseSearchItem[]> GetWarehousesAsync(string searchKey, int? limit = null, int? page = null)
        {
            var request = new WarehouseSearchRequest(searchKey, limit, page);
            var response = await this._httpService.GetData<WarehouseSearchResponse>("AddressGeneral/getWarehouses/", request);
            
            return response.data;
        }
    }
}
