using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PointScoreAppV2
{
    public partial class AnzeigePanel : Form
    {
        public AnzeigePanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Update.txt");
            String P1Name = lines[0];
            String P1MaxPoints = lines[1];
            String P1Points = lines[2];
            String P2Name = lines[3];
            String P2MaxPoints = lines[4];
            String P2Points = lines[5];

            label1.Text = P1Name;
            label2.Text = P2Name;

            PunkteP1.Text = "Punkte: " + P1Points;
            PunkteP2.Text = "Punkte: " + P2Points;

            PunkteProgressBarP1.Maximum = Convert.ToInt32(P1MaxPoints);
            PunkteProgressBarP1.Value = Convert.ToInt32(P1Points);
            PunkteProgressBarP2.Maximum = Convert.ToInt32(P2MaxPoints);
            PunkteProgressBarP2.Value = Convert.ToInt32(P2Points);

        }
    }
}
