using System;

namespace TEST3
{
    public partial class Form1 : Form
    {
        private string uiMode = "Light"; // Default mode

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            if (uiMode == "Light")
            {
                // Set Light Mode
                btnChangeMode.Text = "Enable Dark Mode";
                lblmsg.Text = "Light Mode is Enabled now.";
                this.ForeColor = Color.FromArgb(0, 0, 0); // Dark text
                this.BackColor = Color.FromArgb(245, 246, 250); // Light background
            }
            else
            {
                // Set Dark Mode
                btnChangeMode.Text = "Enable Light Mode";
                lblmsg.Text = "Dark Mode is Enabled now.";
                this.ForeColor = Color.FromArgb(245, 246, 250); // Light text
                this.BackColor = Color.FromArgb(0, 0, 0); // Dark background
            }
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            // Toggle the mode
            uiMode = (uiMode == "Light") ? "Dark" : "Light";

            // Reinitialize the UI with the new mode
            InitializeUI();
        }
    }
}
