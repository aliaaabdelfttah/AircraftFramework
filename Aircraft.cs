namespace AirportManagementSystem.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string AircraftNumber { get; set; }  // الرقم التسلسلي للطائرة
        public string Model { get; set; }  // نموذج الطائرة
        public int Capacity { get; set; }  // سعة الطائرة
        public string Manufacturer { get; set; }  // الشركة المصنعة
    }
}
