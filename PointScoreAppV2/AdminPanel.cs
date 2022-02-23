using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PointScoreAppV2
{
    public partial class AdminPanel : Form
    {
        
        private AnzeigePanel ap = new AnzeigePanel();


        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //text to variable
            string P1Name = player1Name.Text;
            string P1MaxPoints = Convert.ToString(MaxPunkteP1.Value);
            string P1Points = Convert.ToString(pointsPlayer1.Value);
            string P2Name = player2Name.Text;
            string P2MaxPoints = Convert.ToString(MaxPunkteP2.Value);
            string P2Points = Convert.ToString(pointsPlayer2.Value);
            //WriteData aufruf mit übergabe der Variablen
            WriteData(P1Name, P1MaxPoints, P1Points, P2Name, P2MaxPoints, P2Points);
        }

        public static async Task WriteData(String P1Name, String P1MaxPoints, String P1Points, String P2Name, String P2MaxPoints, String P2Points)
        {
            string[] lines =
            {
                //Variablen werden in Array geschrieben
                P1Name,
                P1MaxPoints,
                P1Points,
                P2Name,
                P2MaxPoints,
                P2Points
            };
                //Array wird in die Update.txt Datei geschrieben, Zeilenweise
            await File.WriteAllLinesAsync("Update.txt", lines);
        }

        private void Anzeigepanel_Click(object sender, EventArgs e)
        {
            //AnzeigePanel anzeigen
            ap.Show();      //keine Absicherung das der User es nicht 2 mal oeffnet
        }
    }
}
