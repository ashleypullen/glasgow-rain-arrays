
namespace glasgow_rain
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxRain = new System.Windows.Forms.ListBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxRain
            // 
            this.listBoxRain.FormattingEnabled = true;
            this.listBoxRain.Location = new System.Drawing.Point(12, 49);
            this.listBoxRain.Name = "listBoxRain";
            this.listBoxRain.Size = new System.Drawing.Size(209, 381);
            this.listBoxRain.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(290, 49);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(100, 50);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(290, 119);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(100, 45);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(290, 253);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(100, 49);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(290, 182);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 49);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Glasgow",
            "Liverpool",
            "Aylesbury"});
            this.cmbLocation.Location = new System.Drawing.Point(12, 12);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(209, 21);
            this.cmbLocation.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.listBoxRain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRain;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ComboBox cmbLocation;
    }
}

