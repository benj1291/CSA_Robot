namespace RobotView
{
    partial class RunTurnView
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.upDownAngle = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 30);
            this.labelTitle.Text = "RunTurn";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(3, 30);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(200, 30);
            this.labelDescription.Text = "Angle (+/- deegres)";
            // 
            // buttonChangeSign
            // 
            this.buttonChangeSign.Location = new System.Drawing.Point(210, 30);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(45, 30);
            this.buttonChangeSign.TabIndex = 2;
            this.buttonChangeSign.Text = "+/-";
            this.buttonChangeSign.Click += new System.EventHandler(this.buttonChangeSign_Click);
            // 
            // upDownAngle
            // 
            this.upDownAngle.Location = new System.Drawing.Point(280, 30);
            this.upDownAngle.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.upDownAngle.Minimum = new decimal(new int[] {
            380,
            0,
            0,
            -2147483648});
            this.upDownAngle.Name = "upDownAngle";
            this.upDownAngle.Size = new System.Drawing.Size(100, 32);
            this.upDownAngle.TabIndex = 3;
            this.upDownAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.upDownAngle.GotFocus += new System.EventHandler(this.upDownAngle_GotFocus);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(400, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 30);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // RunTurnView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.upDownAngle);
            this.Controls.Add(this.buttonChangeSign);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Name = "RunTurnView";
            this.Size = new System.Drawing.Size(480, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonChangeSign;
        private System.Windows.Forms.NumericUpDown upDownAngle;
        private System.Windows.Forms.Button buttonStart;
    }
}
