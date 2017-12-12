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
    public partial class SwitchView : UserControl
    {

        private Switch swi;
        private bool state;


        public SwitchView()
        {
            InitializeComponent();

            State = false;
        }

        public Switch Switch
        {
            get
            {
                return this.swi;
            }
            set
            {
                if (swi != null) swi.SwitchStateChanged -= SwitchStateChanged;

                swi = value;
                if (swi != null) swi.SwitchStateChanged += SwitchStateChanged;
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
                pictureBox.Image = (value ? Resource.SwitchOn : Resource.SwitchOff);
            }
        }

        private void SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(SwitchStateChanged), sender, e);
            }
            else
            {
                State = e.SwitchEnabled;
            }
        }  
    }
}