using NovaPoshtaAPI.Result;

namespace NovaPoshtaAPI.HttpModels
{
    internal class WarehouseSearchResponse : BaseSearchResponse
    {
        public WarehouseSearchItem[] data { get; set; }
    }
}
