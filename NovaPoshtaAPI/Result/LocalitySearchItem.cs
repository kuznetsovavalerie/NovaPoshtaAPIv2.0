namespace NovaPoshtaAPI.Result
{
    public class LocalitySearchItem
    {
        /// <summary>
        /// Full locality name
        /// </summary>
        public string MainDescription { get; set; }

        /// <summary>
        /// Administrative district
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Administrative sub-district
        /// </summary>
        public string Area { get; }

        /// <summary>
        /// Short locality type
        /// </summary>
        public string SettlementTypeCode { get; set; }

        /// <summary>
        /// Locality identifier
        /// </summary>
        public string DeliveryCity { get; set; }

        /// <summary>
        /// The number of warhouses in locality
        /// </summary>
        public int Warehouses { get; set; }
    }
}
