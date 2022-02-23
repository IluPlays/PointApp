using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            try
            {
                //lesen der Update.txt, Zeilenweise
                string[] lines = File.ReadAllLines(@"Update.txt");

                //Array zu Variable (*Ilu: Ja ich weis, dass das nicht noetig gewesen waere)
                String P1Name = lines[0];
                String P1MaxPoints = lines[1];
                String P1Points = lines[2];
                String P2Name = lines[3];
                String P2MaxPoints = lines[4];
                String P2Points = lines[5];


                //setze Player1 / Player2 auf Spielernamen
                label1.Text = P1Name;
                label2.Text = P2Name;

                //Zeige die Punkte an
                PunkteP1.Text = "Punkte: " + P1Points;
                PunkteP2.Text = "Punkte: " + P2Points;

                try
                {
                    //Ansteuern der Progressbar als zusatz zur Punkteanzeige
                    PunkteProgressBarP1.Maximum = Convert.ToInt32(P1MaxPoints);
                    PunkteProgressBarP1.Value = Convert.ToInt32(P1Points);
                    PunkteProgressBarP2.Maximum = Convert.ToInt32(P2MaxPoints);
                    PunkteProgressBarP2.Value = Convert.ToInt32(P2Points);
                }
                catch
                {
                    UpdateTimer.Stop();
                    MessageBox.Show("Es ist was schiefgelaufen. \nBitte achten Sie darauf das der Maximum Wert höher seien muss als der Punkte Wert. \n\n\nERRORCODE:AP_L1C_PB");
                }
            }
            catch{
                UpdateTimer.Stop();
                MessageBox.Show("Es ist was schiefgelaufen. \nBitte starten Sie die Anwendung neu oder kontaktieren sie den Developer. \n\n\nERRORCODE:AP_L1C_Load");
            }

        }

        private void PunkteP2_Click(object sender, EventArgs e)
        {
            UpdateTimer.Start();
        }
    }
}
