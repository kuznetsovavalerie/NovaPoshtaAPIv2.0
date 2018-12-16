namespace NovaPoshtaAPI.Result
{
    public class WarehouseSearchItem
    {
        public decimal SiteKey { get; set; }
        public string Description { get; set; }
        public string DescriptionRu { get; set; }
        public string Phone { get; set; }
        public string TypeOfWarehouse { get; set; }
        public string Ref { get; set; }
        public int Number { get; set; }
        public string CityRef { get; set; }
        public string CityDescription { get; set; }
        public string CityDescriptionRu { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int TotalMaxWeightAllowed { get; set; }
        public int PlaceMaxWeightAllowed { get; set; }

        public WorkingHours Schedule { get; set; }

        public class WorkingHours
        {
            public string Monday { get; set; }
            public string Tuesday { get; set; }
            public string Wednesday { get; set; }
            public string Thursday { get; set; }
            public string Friday { get; set; }
            public string Saturday { get; set; }
            public string Sunday { get; set; }
        }
    }
}
