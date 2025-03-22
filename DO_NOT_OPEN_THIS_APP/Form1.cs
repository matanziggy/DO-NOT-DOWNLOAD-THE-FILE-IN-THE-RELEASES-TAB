using System.Diagnostics;

namespace DO_NOT_OPEN_THIS_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://cutt.ly/XroZTDmb",
                UseShellExecute = true
            });
        }
    }
}
