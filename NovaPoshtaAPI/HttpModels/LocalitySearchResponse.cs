using NovaPoshtaAPI.Result;

namespace NovaPoshtaAPI.HttpModels
{
    internal class LocalitySearchResponse: BaseSearchResponse
    {
        public LocalitySearchDataResultModel[] data { get; set; }

        internal class LocalitySearchDataResultModel
        {
            public int TotalCount { get; set; }

            public LocalitySearchItem[] Addresses { get; set; }
        }
    }
}
