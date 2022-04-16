using AircraftsApp.Models.Enums;

namespace AircraftsApp.Models
{
    public class Aircraft
    {
        public int AircraftId { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; set; }
        public AircraftType AircraftType { get; set; }
        public List<Engine> Engine { get; set; } 
        public DateOnly YearOfFirstFlight { get; private set; }
        public string? Description { get; private set; }
        public string? Image { get; private set; }

        public Aircraft(string manufacturer, string model, AircraftType aircraftType, DateOnly yearOfFirstFlight)
        {
            Manufacturer = manufacturer;
            Model = model;
            AircraftType = aircraftType;
            YearOfFirstFlight = yearOfFirstFlight;
        }
    }
}
