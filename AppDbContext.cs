using Microsoft.EntityFrameworkCore;
using AirportManagementSystem.Models;

namespace AirportManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // الاتصال بقاعدة بيانات SQLite
            options.UseSqlite("Data Source=airportManagement.db");
        }
    }
}
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

private void ExportToPdfButton_Click(object sender, EventArgs e)
{
    using (var db = new AppDbContext())
    {
        var aircrafts = db.Aircrafts.ToList();
        var document = new Document();
        var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Aircrafts.pdf");

        PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
        document.Open();

        document.Add(new Paragraph("Aircrafts Data"));
        document.Add(new Paragraph("\n"));

        foreach (var aircraft in aircrafts)
        {
            document.Add(new Paragraph($"Aircraft Number: {aircraft.AircraftNumber}"));
            document.Add(new Paragraph($"Model: {aircraft.Model}"));
            document.Add(new Paragraph($"Capacity: {aircraft.Capacity}"));
            document.Add(new Paragraph($"Manufacturer: {aircraft.Manufacturer}"));
            document.Add(new Paragraph("\n"));
        }

        document.Close();
        MessageBox.Show($"Data exported to {filePath}");
    }
}
