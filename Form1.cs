using Systeme;
using Systeme.Collections.Generic;
using Systeme.ComponentModel;
using Systeme.Data;
using Systeme.Drawing;
using Systeme.Linq;
using Systeme.Text;
using Systeme.Threading.Tasks;
using Systeme.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCpu.NextValue();
            chart1.Series["CPU"].Points.AddY(fcpu);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();

        }
    }
}
