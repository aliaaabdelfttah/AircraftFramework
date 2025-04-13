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
