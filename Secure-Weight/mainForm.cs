using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiimoteLib;

namespace Secure_Weight
{
    public partial class mainForm : Form
    {
        private Wiimote balanceBoard;
        private Timer updateTimer;

        public mainForm()
        {
            InitializeComponent();
            this.balanceBoard = new Wiimote();
            this.updateTimer = new Timer();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.balanceBoard.Connect();
                this.balanceBoard.SetLEDs(1);
                this.connStatLbl.Text = "Connected";

                this.updateTimer.Tick += updateTimer_Tick;
                this.updateTimer.Start();
            }
            catch
            {
                this.connStatLbl.Text = "Not Connected";
            }
        }

        void updateTimer_Tick(object sender, EventArgs e)
        {
            BalanceBoardState state = this.balanceBoard.WiimoteState.BalanceBoardState;
            BalanceBoardSensorsF values = state.SensorValuesKg;

            this.weightValLbl.Text = Math.Round(state.WeightKg, 1) + " kg";
            this.topLeftVal.Text = Math.Round(values.TopLeft, 1) + " kg";
            this.topRightVal.Text = Math.Round(values.TopRight, 1) + " kg";
            this.bottomLeftVal.Text = Math.Round(values.BottomLeft, 1) + " kg";
            this.bottomRightVal.Text = Math.Round(values.BottomRight, 1) + " kg";
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.balanceBoard.SetLEDs(0);
        }
    }
}
