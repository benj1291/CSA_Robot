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
    public partial class RunLineView : UserControl
    {

        private float speed;
        private float acceleration;
        private Drive drive;

        public RunLineView()
        {
            InitializeComponent();
        }

        public float Speed
        {
            set
            {
                this.speed = value;
            }
            private get
            {
                return this.speed;
            }
        }

        public float Acceleration
        {
            set
            {
                this.acceleration = value;
            }
            private get
            {
                return this.acceleration;
            }
        }

        public float Length
        {
            get
            {
                return (float)upDownLength.Value;
            }
        }

        public Drive Drive
        {
            set
            {
                this.drive = value;
            }
        }

        public void Start()
        {
            drive.RunLine(this.Length / 1000, this.Speed, this.Acceleration);
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            upDownLength.Value = decimal.Negate(upDownLength.Value);
        }

        private void btnStartRunLine_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void upDownLength_GotFocus(object sender, EventArgs e)
        {
            this.Focus();
            upDownLength.Value = KeyBoard.ShowBox(upDownLength.Value, upDownLength.Minimum, upDownLength.Maximum);
        }
    }
}