namespace NovaPoshtaAPI.HttpModels
{
    internal class LocalitySearchRequest: BaseSearchRequest
    {        
        public MethodProperties methodProperties { get; set; }

        public LocalitySearchRequest(string cityName, int? limit)
            : base("Address", "searchSettlements")
        {
            this.methodProperties = new MethodProperties
            {
                CityName = cityName,
                Limit = limit
            };
        }

        internal class MethodProperties
        {
            public string CityName { get; set; }
            public int? Limit { get; set; }
        }
    }
}
