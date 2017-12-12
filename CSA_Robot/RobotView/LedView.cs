using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class LedView : UserControl
    {

        private Led led;
        private bool state;

        public LedView()
        {
            InitializeComponent();

            this.state = false;
        }

        public Led Led
        {
            get
            {
                return this.led;
            }
            set
            {
                if (led != null) this.led.LedStateChanged -= LedStateChanged;

                led = value;
                if (led != null) this.led.LedStateChanged += LedStateChanged;
            }
        }

        public bool State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
                pictureBox.Image = (value ? Resource.LedOn : Resource.LedOff);
            }
        }

        private void LedStateChanged(object sender, LedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<LedEventArgs>(LedStateChanged), sender, e);
            }
            else
            {
                State = e.LedEnabled;
            }
        }
    }
}