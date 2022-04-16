namespace AircraftsApp.Models.Enums
{
    public class Engine
    {
        public int EngineId { get; set; }
        public string EngineManufacturer { get; set; }
        public string EngineType { get; set; }
        public int? AircraftId { get; set; }
        public Aircraft? Aircraft { get; set; }

        public Engine(string engineManufacturer, string engineType)
        {
            EngineManufacturer = engineManufacturer;
            EngineType = engineType;
        }
    }
}
