using AirportManagementSystem.Data;
using AirportManagementSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AirportManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAircrafts();
            LoadFlights();
        }

        private void LoadAircrafts()
        {
            using (var db = new AppDbContext())
            {
                var aircrafts = db.Aircrafts.ToList();
                AircraftListBox.Items.Clear();
                foreach (var aircraft in aircrafts)
                {
                    AircraftListBox.Items.Add($"Aircraft: {aircraft.AircraftNumber}, Model: {aircraft.Model}, Capacity: {aircraft.Capacity}");
                }
            }
        }

        private void LoadFlights()
        {
            using (var db = new AppDbContext())
            {
                var flights = db.Flights.ToList();
                FlightsListBox.Items.Clear();
                foreach (var flight in flights)
                {
                    FlightsListBox.Items.Add($"Flight: {flight.FlightNumber}, Departure: {flight.DepartureTime}, Aircraft: {flight.Aircraft.AircraftNumber}");
                }
            }
        }

        private void AddAircraftButton_Click(object sender, EventArgs e)
        {
            // إضافة طائرة جديدة
            var aircraft = new Aircraft
            {
                AircraftNumber = AircraftNumberTextBox.Text,
                Model = ModelTextBox.Text,
                Capacity = int.Parse(CapacityTextBox.Text),
                Manufacturer = ManufacturerTextBox.Text
            };

            using (var db = new AppDbContext())
            {
                db.Aircrafts.Add(aircraft);
                db.SaveChanges();
            }

            LoadAircrafts();
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            // إضافة رحلة جديدة
            var flight = new Flight
            {
                FlightNumber = FlightNumberTextBox.Text,
                DepartureTime = DepartureTimePicker.Value,
                Origin = OriginTextBox.Text,
                Destination = DestinationTextBox.Text,
                AircraftId = int.Parse(AircraftIdTextBox.Text)  // تحديد الطائرة المرتبطة بالرحلة
            };

            using (var db = new AppDbContext())
            {
                db.Flights.Add(flight);
                db.SaveChanges();
            }

            LoadFlights();
        }
    }
}

private void UpdateAircraftButton_Click(object sender, EventArgs e)
{
    // تعديل الطائرة بناءً على الرقم التسلسلي
    var selectedAircraft = AircraftListBox.SelectedItem.ToString();
    var aircraftNumber = selectedAircraft.Split(',')[0].Split(':')[1].Trim();

    using (var db = new AppDbContext())
    {
        var aircraft = db.Aircrafts.FirstOrDefault(a => a.AircraftNumber == aircraftNumber);
        if (aircraft != null)
        {
            aircraft.Model = ModelTextBox.Text;  // تعديل النموذج
            aircraft.Capacity = int.Parse(CapacityTextBox.Text);  // تعديل السعة
            aircraft.Manufacturer = ManufacturerTextBox.Text;  // تعديل الشركة المصنعة
            db.SaveChanges();
        }
    }

    LoadAircrafts();  // إعادة تحميل الطائرات
}

private void DeleteAircraftButton_Click(object sender, EventArgs e)
{
    var selectedAircraft = AircraftListBox.SelectedItem.ToString();
    var aircraftNumber = selectedAircraft.Split(',')[0].Split(':')[1].Trim();

    using (var db = new AppDbContext())
    {
        var aircraft = db.Aircrafts.FirstOrDefault(a => a.AircraftNumber == aircraftNumber);
        if (aircraft != null)
        {
            db.Aircrafts.Remove(aircraft);
            db.SaveChanges();
        }
    }

    LoadAircrafts();  // إعادة تحميل الطائرات بعد الحذف
}

private void UpdateFlightButton_Click(object sender, EventArgs e)
{
    var selectedFlight = FlightsListBox.SelectedItem.ToString();
    var flightNumber = selectedFlight.Split(',')[0].Split(':')[1].Trim();

    using (var db = new AppDbContext())
    {
        var flight = db.Flights.FirstOrDefault(f => f.FlightNumber == flightNumber);
        if (flight != null)
        {
            flight.Origin = OriginTextBox.Text;  // تعديل مكان الإقلاع
            flight.Destination = DestinationTextBox.Text;  // تعديل مكان الوصول
            flight.DepartureTime = DepartureTimePicker.Value;  // تعديل وقت الإقلاع
            db.SaveChanges();
        }
    }

    LoadFlights();  // إعادة تحميل الرحلات بعد التعديل
}

private void DeleteFlightButton_Click(object sender, EventArgs e)
{
    var selectedFlight = FlightsListBox.SelectedItem.ToString();
    var flightNumber = selectedFlight.Split(',')[0].Split(':')[1].Trim();

    using (var db = new AppDbContext())
    {
        var flight = db.Flights.FirstOrDefault(f => f.FlightNumber == flightNumber);
        if (flight != null)
        {
            db.Flights.Remove(flight);
            db.SaveChanges();
        }
    }

    LoadFlights();  // إعادة تحميل الرحلات بعد الحذف
}


