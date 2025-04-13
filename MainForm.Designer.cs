namespace AirportManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox AircraftListBox;
        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.TextBox AircraftNumberTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Button AddAircraftButton;
        private System.Windows.Forms.TextBox FlightNumberTextBox;
        private System.Windows.Forms.TextBox OriginTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.DateTimePicker DepartureTimePicker;
        private System.Windows.Forms.TextBox AircraftIdTextBox;
        private System.Windows.Forms.Button AddFlightButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AircraftListBox = new System.Windows.Forms.ListBox();
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.AircraftNumberTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.AddAircraftButton = new System.Windows.Forms.Button();
            this.FlightNumberTextBox = new System.Windows.Forms.TextBox();
            this.OriginTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AircraftIdTextBox = new System.Windows.Forms.TextBox();
            this.AddFlightButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // AircraftListBox
            this.AircraftListBox.FormattingEnabled = true;
            this.AircraftListBox.Location = new System.Drawing.Point(12, 12);
            this.AircraftListBox.Name = "AircraftListBox";
            this.AircraftListBox.Size = new System.Drawing.Size(400, 160);
            this.AircraftListBox.TabIndex = 0;

            // FlightsListBox
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.Location = new System.Drawing.Point(12, 200);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(400, 160);
            this.FlightsListBox.TabIndex = 1;

            // Other TextBoxes and Buttons Setup
            // (Similar to the previous setup: AircraftNumberTextBox, ModelTextBox, etc.)

            // AddAircraftButton
            this.AddAircraftButton.Location = new System.Drawing.Point(12, 240);
            this.AddAircraftButton.Name = "AddAircraftButton";
            this.AddAircraftButton.Size = new System.Drawing.Size(100, 30);
            this.AddAircraftButton.TabIndex = 2;
            this.AddAircraftButton.Text = "Add Aircraft";
            this.AddAircraftButton.UseVisualStyleBackColor = true;
            this.AddAircraftButton.Click += new System.EventHandler(this.AddAircraftButton_Click);

            // AddFlightButton
            this.AddFlightButton.Location = new System.Drawing.Point(120, 240);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(100, 30);
            this.AddFlightButton.TabIndex = 3;
            this.AddFlightButton.Text = "Add Flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.AddAircraftButton);
            this.Controls.Add(this.AircraftIdTextBox);
            this.Controls.Add(this.DepartureTimePicker);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.OriginTextBox);
            this.Controls.Add(this.FlightNumberTextBox);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.CapacityTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.AircraftNumberTextBox);
            this.Controls.Add(this.FlightsListBox);
            this.Controls.Add(this.AircraftListBox);
            this.Name = "MainForm";
            this.Text = "Airport Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
