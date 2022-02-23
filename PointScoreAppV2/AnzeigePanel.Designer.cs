
namespace PointScoreAppV2
{
    partial class AnzeigePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnzeigePanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PunkteP1 = new System.Windows.Forms.Label();
            this.PunkteP2 = new System.Windows.Forms.Label();
            this.PunkteProgressBarP1 = new System.Windows.Forms.ProgressBar();
            this.PunkteProgressBarP2 = new System.Windows.Forms.ProgressBar();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(423, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 106);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // PunkteP1
            // 
            this.PunkteP1.AutoSize = true;
            this.PunkteP1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PunkteP1.Location = new System.Drawing.Point(115, 160);
            this.PunkteP1.Name = "PunkteP1";
            this.PunkteP1.Size = new System.Drawing.Size(188, 54);
            this.PunkteP1.TabIndex = 4;
            this.PunkteP1.Text = "Punkte: 0";
            // 
            // PunkteP2
            // 
            this.PunkteP2.AutoSize = true;
            this.PunkteP2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PunkteP2.Location = new System.Drawing.Point(490, 160);
            this.PunkteP2.Name = "PunkteP2";
            this.PunkteP2.Size = new System.Drawing.Size(188, 54);
            this.PunkteP2.TabIndex = 5;
            this.PunkteP2.Text = "Punkte: 0";
            // 
            // PunkteProgressBarP1
            // 
            this.PunkteProgressBarP1.Location = new System.Drawing.Point(72, 217);
            this.PunkteProgressBarP1.Name = "PunkteProgressBarP1";
            this.PunkteProgressBarP1.Size = new System.Drawing.Size(269, 23);
            this.PunkteProgressBarP1.TabIndex = 6;
            // 
            // PunkteProgressBarP2
            // 
            this.PunkteProgressBarP2.Location = new System.Drawing.Point(446, 217);
            this.PunkteProgressBarP2.Name = "PunkteProgressBarP2";
            this.PunkteProgressBarP2.Size = new System.Drawing.Size(269, 23);
            this.PunkteProgressBarP2.TabIndex = 7;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.label1_Click);
            // 
            // AnzeigePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PunkteProgressBarP2);
            this.Controls.Add(this.PunkteProgressBarP1);
            this.Controls.Add(this.PunkteP2);
            this.Controls.Add(this.PunkteP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnzeigePanel";
            this.Text = "AnzeigePanel";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PunkteP1;
        private System.Windows.Forms.Label PunkteP2;
        private System.Windows.Forms.ProgressBar PunkteProgressBarP1;
        private System.Windows.Forms.ProgressBar PunkteProgressBarP2;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}