namespace NoBullFlightTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Load User Data


            // call api



            // Display information in new form


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Flight
    {
        public string Airline { get; }
        public DateTime FlightTime { get; }
        public float Cost { get; }


        // Default US Currency Format
        // string.Format(new CultureInfo("en-US"), "{0:C}", 1456.12155)      // $1,456.12
    }
}
