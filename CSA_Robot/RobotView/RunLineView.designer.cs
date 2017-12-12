namespace RobotView
{
    partial class RunLineView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnStartRunLine = new System.Windows.Forms.Button();
            this.upDownLength = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "RunLine";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.Text = "Length (+/- mm)";
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Location = new System.Drawing.Point(210, 30);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(45, 30);
            this.btnChangeSign.TabIndex = 2;
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.Click += new System.EventHandler(this.btnChangeSign_Click);
            // 
            // btnStartRunLine
            // 
            this.btnStartRunLine.Location = new System.Drawing.Point(400, 30);
            this.btnStartRunLine.Name = "btnStartRunLine";
            this.btnStartRunLine.Size = new System.Drawing.Size(70, 30);
            this.btnStartRunLine.TabIndex = 3;
            this.btnStartRunLine.Text = "Start";
            this.btnStartRunLine.Click += new System.EventHandler(this.btnStartRunLine_Click);
            // 
            // upDownLength
            // 
            this.upDownLength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownLength.Location = new System.Drawing.Point(280, 30);
            this.upDownLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownLength.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.upDownLength.Name = "upDownLength";
            this.upDownLength.Size = new System.Drawing.Size(100, 32);
            this.upDownLength.TabIndex = 4;
            this.upDownLength.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownLength.GotFocus += new System.EventHandler(this.upDownLength_GotFocus);
            // 
            // RunLineView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.upDownLength);
            this.Controls.Add(this.btnStartRunLine);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RunLineView";
            this.Size = new System.Drawing.Size(480, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnStartRunLine;
        private System.Windows.Forms.NumericUpDown upDownLength;
    }
}
