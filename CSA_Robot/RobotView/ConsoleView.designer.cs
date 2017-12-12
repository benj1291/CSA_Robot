namespace RobotView
{
    partial class ConsoleView
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
            this.ledView1 = new RobotView.LedView();
            this.switchView1 = new RobotView.SwitchView();
            this.ledView2 = new RobotView.LedView();
            this.ledView3 = new RobotView.LedView();
            this.ledView4 = new RobotView.LedView();
            this.switchView2 = new RobotView.SwitchView();
            this.switchView3 = new RobotView.SwitchView();
            this.switchView4 = new RobotView.SwitchView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ledView1
            // 
            this.ledView1.Led = null;
            this.ledView1.Location = new System.Drawing.Point(5, 5);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.State = false;
            this.ledView1.TabIndex = 1;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(105, 5);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(20, 40);
            this.switchView1.State = false;
            this.switchView1.Switch = null;
            this.switchView1.TabIndex = 2;
            // 
            // ledView2
            // 
            this.ledView2.Led = null;
            this.ledView2.Location = new System.Drawing.Point(30, 5);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.State = false;
            this.ledView2.TabIndex = 3;
            // 
            // ledView3
            // 
            this.ledView3.Led = null;
            this.ledView3.Location = new System.Drawing.Point(55, 5);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.State = false;
            this.ledView3.TabIndex = 4;
            // 
            // ledView4
            // 
            this.ledView4.Led = null;
            this.ledView4.Location = new System.Drawing.Point(80, 5);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 20);
            this.ledView4.State = false;
            this.ledView4.TabIndex = 5;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(130, 5);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(20, 40);
            this.switchView2.State = false;
            this.switchView2.Switch = null;
            this.switchView2.TabIndex = 6;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(155, 5);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(20, 40);
            this.switchView3.State = false;
            this.switchView3.Switch = null;
            this.switchView3.TabIndex = 7;
            // 
            // switchView4
            // 
            this.switchView4.Location = new System.Drawing.Point(180, 5);
            this.switchView4.Name = "switchView4";
            this.switchView4.Size = new System.Drawing.Size(20, 40);
            this.switchView4.State = false;
            this.switchView4.Switch = null;
            this.switchView4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(55, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(80, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConsoleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchView4);
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Controls.Add(this.switchView1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(205, 50);
            this.ResumeLayout(false);

        }

        #endregion
        private LedView ledView1;
        private SwitchView switchView1;
        private LedView ledView2;
        private LedView ledView3;
        private LedView ledView4;
        private SwitchView switchView2;
        private SwitchView switchView3;
        private SwitchView switchView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
