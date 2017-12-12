namespace RobotView
{
    partial class RunArcView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.labelRadius = new System.Windows.Forms.Label();
            this.upDownRadius = new System.Windows.Forms.NumericUpDown();
            this.labelAngle = new System.Windows.Forms.Label();
            this.upDownAngle = new System.Windows.Forms.NumericUpDown();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 30);
            this.labelTitle.Text = "RunArc";
            // 
            // labelDirection
            // 
            this.labelDirection.Location = new System.Drawing.Point(3, 30);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(100, 20);
            this.labelDirection.Text = "Direction";
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(280, 30);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(80, 30);
            this.radioButtonLeft.TabIndex = 2;
            this.radioButtonLeft.Text = "left";
            this.radioButtonLeft.CheckedChanged += new System.EventHandler(this.radioButtonLeft_CheckedChanged);
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.Location = new System.Drawing.Point(360, 30);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(80, 30);
            this.radioButtonRight.TabIndex = 3;
            this.radioButtonRight.TabStop = false;
            this.radioButtonRight.Text = "right";
            this.radioButtonRight.CheckedChanged += new System.EventHandler(this.radioButtonRight_CheckedChanged);
            // 
            // labelRadius
            // 
            this.labelRadius.Location = new System.Drawing.Point(3, 70);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(150, 20);
            this.labelRadius.Text = "Radius (+ mm)";
            // 
            // upDownRadius
            // 
            this.upDownRadius.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownRadius.Location = new System.Drawing.Point(280, 70);
            this.upDownRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownRadius.Name = "upDownRadius";
            this.upDownRadius.Size = new System.Drawing.Size(100, 32);
            this.upDownRadius.TabIndex = 8;
            this.upDownRadius.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownRadius.GotFocus += new System.EventHandler(this.upDownRadius_GotFocus);
            // 
            // labelAngle
            // 
            this.labelAngle.Location = new System.Drawing.Point(3, 110);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(200, 30);
            this.labelAngle.Text = "Angle (+/- degrees)";
            // 
            // upDownAngle
            // 
            this.upDownAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownAngle.Location = new System.Drawing.Point(280, 110);
            this.upDownAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.upDownAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.upDownAngle.Name = "upDownAngle";
            this.upDownAngle.Size = new System.Drawing.Size(100, 32);
            this.upDownAngle.TabIndex = 11;
            this.upDownAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.upDownAngle.GotFocus += new System.EventHandler(this.upDownAngle_GotFocus);
            // 
            // buttonChangeSign
            // 
            this.buttonChangeSign.Location = new System.Drawing.Point(220, 110);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(45, 30);
            this.buttonChangeSign.TabIndex = 12;
            this.buttonChangeSign.Text = "+/-";
            this.buttonChangeSign.Click += new System.EventHandler(this.buttonChangeSign_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(400, 110);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 30);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // RunArcView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonChangeSign);
            this.Controls.Add(this.upDownAngle);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.upDownRadius);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.radioButtonLeft);
            this.Controls.Add(this.radioButtonRight);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.labelTitle);
            this.Name = "RunArcView";
            this.Size = new System.Drawing.Size(480, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.NumericUpDown upDownRadius;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.NumericUpDown upDownAngle;
        private System.Windows.Forms.Button buttonChangeSign;
        private System.Windows.Forms.Button buttonStart;
    }
}
