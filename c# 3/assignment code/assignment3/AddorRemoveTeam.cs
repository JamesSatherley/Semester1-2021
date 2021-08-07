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
    public partial class AddorRemoveTeam : Form
    {
        bool exitCheck = false;

        List<Team> teams;
        List<Team> teams_export = new List<Team>();

        internal AddorRemoveTeam(List<Team> teams_in) // constructor
        {
            InitializeComponent();
            teams = teams_in;
            teams_export = teams;
        }

        private void AddorRemoveTeam_Load(object sender, EventArgs e) // on load display teams
        {
            UpdateListView();
        }

        public void UpdateListView() // updates list box with new teams
        {
            TeamsList.Items.Clear();

            foreach (Team team in teams)
            {
                string output = team.Name;
                TeamsList.Items.Add(output.Replace("\n", ""));
            }
        }
        internal (List<Team>, bool) ReturnValues() // returns to main
        {
            (List<Team>, bool) t = (teams_export, exitCheck);
            return t;
        }

        private void TeamsList_SelectedIndexChanged(object sender, EventArgs e) // event for if select changes. if so remove that team
        {
            Team x = new Team();

            foreach (Team team in teams)
            {
                if (TeamsList.SelectedItem.ToString() == team.Name)
                {
                    x = team;
                }
            }
            teams.Remove(x);
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e) // adds new team if data matches what it should be
        {
            int year;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Error: Some input is blank");
            }
            else
            {
                try
                {
                    bool tof = true;
                    string name = textBox1.Text;

                    foreach (Team team in teams)
                    {
                        if (team.Name == name)
                        {
                            MessageBox.Show("Duplicate Name");
                            tof = false;
                        }
                    }
                    if (tof)
                    {
                        year = Int32.Parse(textBox4.Text);
                        List<Player> x = new List<Player>();
                        Team y = new Team(textBox1.Text, textBox2.Text, textBox3.Text, year, textBox5.Text, x);
                        teams.Add(y);
                        UpdateListView();
                    }
                }
                catch
                {
                    MessageBox.Show("An input that should be a number is not");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) // sends data. exits form
        {
            teams_export = teams;
            exitCheck = true;
            Close();
        }
    }
}
