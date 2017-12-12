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
    public partial class RunArcView : UserControl
    {

        enum EnumDirection { right, left};

        private float accleration;
        private float speed;
        private EnumDirection direction;
        private Drive drive;

        public RunArcView()
        {
            InitializeComponent();

            radioButtonLeft_CheckedChanged(null, EventArgs.Empty);
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

        public float Radius
        {
            get
            {
                return (float)upDownRadius.Value;
            }
        }

        EnumDirection Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
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
            switch (Direction)
            {
                case EnumDirection.left:
                    Drive.RunArcLeft(this.Radius/1000, this.Angle, this.Speed, this.Accleration);
                    break;

                case EnumDirection.right:
                    Drive.RunArcRight(this.Radius/1000, this.Angle, this.Speed, this.Accleration);
                    break;
            }
        }

        private void radioButtonLeft_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonRight.Checked = false;
            Direction = EnumDirection.left;
        }

        private void radioButtonRight_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonLeft.Checked = false;
            Direction = EnumDirection.right;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            upDownAngle.Value = decimal.Negate(upDownAngle.Value);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void upDownRadius_GotFocus(object sender, EventArgs e)
        {
            this.Focus();
            upDownRadius.Value = KeyBoard.ShowBox(upDownRadius.Value, upDownRadius.Minimum, upDownRadius.Maximum);
        }

        private void upDownAngle_GotFocus(object sender, EventArgs e)
        {
            this.Focus();
            upDownAngle.Value = KeyBoard.ShowBox(upDownAngle.Value, upDownAngle.Minimum, upDownAngle.Maximum);
        }
    }
}