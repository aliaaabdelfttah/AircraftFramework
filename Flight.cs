namespace AirportManagementSystem.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }  // رقم الرحلة
        public DateTime DepartureTime { get; set; }  // وقت الإقلاع
        public string Origin { get; set; }  // مكان الإقلاع
        public string Destination { get; set; }  // مكان الوصول
        public int AircraftId { get; set; }  // ربط الطائرة بالرحلة
        public Aircraft Aircraft { get; set; }  // العلاقة بين الرحلة والطائرة
    }
}
