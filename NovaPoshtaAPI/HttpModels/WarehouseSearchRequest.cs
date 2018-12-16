namespace NovaPoshtaAPI.HttpModels
{
    internal class WarehouseSearchRequest: BaseSearchRequest
    {
        public MethodProperties methodProperties { get; set; }

        public WarehouseSearchRequest(string cityRef, int? limit, int? page)
            : base("AddressGeneral", "getWarehouses")
        {
            this.methodProperties = new MethodProperties
            {
                CityRef = cityRef,
                Limit = limit,
                Page = page
            };
        }

        internal class MethodProperties
        {
            public string CityRef { get; set; }
            public int? Limit { get; set; }
            public int? Page { get; set; }
        }
    }
}
