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
    public partial class RunTurnView : UserControl
    {

        private float accleration;
        private float speed;
        private Drive drive;

        public RunTurnView()
        {
            InitializeComponent();
        }

        public float Accleration
        {
            private get
            {
                return this.accleration;
            }
            set
            {
                this.accleration = value;
            }
        }

        public float Speed
        {
            private get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public float Angle
        {
            get
            {
                return (float)upDownAngle.Value;
            }
        }

        public Drive Drive
        {
            private get
            {
                return this.drive;
            }
            set
            {
                this.drive = value;
            }
        }

        public void Start()
        {
            Drive.RunTurn(this.Angle, this.Speed, this.Accleration);
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            upDownAngle.Value = decimal.Negate(upDownAngle.Value);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void upDownAngle_GotFocus(object sender, EventArgs e)
        {
            this.Focus();
            upDownAngle.Value = KeyBoard.ShowBox(upDownAngle.Value, upDownAngle.Minimum, upDownAngle.Maximum);
        }
    }
}