using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class Charts : Form
    {
        private List<Player> players;

        internal Charts(List<Player> players)
        {
            this.players = players;
            InitializeComponent();
        }

        private void chart_Load(object sender, EventArgs e) // on form load, all calculation for charts is done. for each player chart1 adds player with xy of
        {                                                   // weight, height. foreach player if the age of parent foreach player age is = count incremented
            List<int> already_in = new List<int>();         // checks for no duplicate ages. adds age as x and count as y
            foreach (Player player in players) 
            {
                chart1.Series.Add(player.FName);
                chart1.Series[player.FName].Points.AddXY(player.Weight, player.Height);

                DateTime today = DateTime.Today;
                int count = 0;
                int age = today.Year - player.BirthDate.Year;
                foreach (Player player2 in players)
                {
                    if (today.Year - player2.BirthDate.Year == age)
                    {
                        count += 1;
                    }
                }
                bool check = true;
                foreach (int num in already_in)
                { 
                    if (num == age) 
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    already_in.Add(age);
                    chart2.Series.Add(age + "");
                    chart2.Series[age + ""].Points.AddY(count);
                }
            }
        }
    }
}
