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
    public partial class Main : Form
    {
        List<Team> teams = new List<Team>();
        List<Player> players = new List<Player>();

        public Main() // main constructor, inits form
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) // legacy
        { }

        private void buttonChart_Click(object sender, EventArgs e) // generates chart form from click
        {
            Charts charts = new Charts(players);
            charts.ShowDialog();
        }

        public void buttonLoad_Click(object sender, EventArgs e) // generates load form from click, gets data back and sets globals to it. calls update
        {
            Load l = new Load(teams, players);
            l.ShowDialog();
            (List<Team>, List<Player>) t = l.Import();
            teams = t.Item1;
            players = t.Item2;
            UpdateListView();
        }

        public void UpdateListView() // updates list boxes with current data in teams and players
        {
            playersBox.Items.Clear();
            teamsBox.Items.Clear();

            foreach (Player player in players)
            {
                string output = player.FName + " " + player.LName;
                playersBox.Items.Add(output.Replace("\n", ""));
            }

            foreach (Team team in teams)
            {
                string output = team.Name;
                teamsBox.Items.Add(output);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) // saves data, has a bool for if to remove all data or not
        {
            Save s = new Save(teams, players);
            s.ShowDialog();
            bool ToF = s.Export();
            if (ToF) 
            {
                teams = new List<Team>();
                players = new List<Player>();
            }
            UpdateListView();
        }

        private void buttonPlayer_Click(object sender, EventArgs e) // generates new list, not pointers, of players to be addeds to. creates new form of add player
        {
            List<Player> y = new List<Player>();
            foreach (Player player in players)
            {
                y.Add(player);
            }


            AddOrRemovePlayer AoRP = new AddOrRemovePlayer(y);
            AoRP.ShowDialog();
            (List<Player>, bool) t = AoRP.ReturnValues();
            if (t.Item2)
            {
                players = t.Item1;
            }
            UpdateListView();
        }

        private void buttonTeam_Click(object sender, EventArgs e) // generates new list, not pointers, of teams to be addeds to. creates new form of add team
        {
            List<Team> y = new List<Team>();
            foreach (Team team in teams)
            {
                y.Add(team);
            }


            AddorRemoveTeam AoRT = new AddorRemoveTeam(y);
            AoRT.ShowDialog();
            (List<Team>, bool) t = AoRT.ReturnValues();
            if (t.Item2)
            {
                teams = t.Item1;
            }
            UpdateListView();
        }

        private void buttonSign_Click(object sender, EventArgs e) // generates new form of sign, displays form
        {
            Sign sign = new Sign(players, teams);
            sign.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e) // search button, checks which button is checked. returns data in messagebox for the outcome
        {                                                           // of the input value. Makes sure data is valid and will say if not. If no data is found
            List<Player> returnList = new List<Player>();           // message box will display saying that
            string returnValue = "";
            bool boolcheck = true;
            if (radioButton1.Checked)
            {
                try
                {
                    int search_age = Int32.Parse(richTextBox1.Text);
                    if (search_age < 1 || search_age > 99)
                    {
                        boolcheck = false;
                        MessageBox.Show("Please enter a number between 1-99");
                    }
                    DateTime today = DateTime.Today;
                    foreach (Player player in players)
                    {
                        if (today.Year - player.BirthDate.Year == search_age)
                        {
                            returnList.Add(player);
                        }
                    }
                }
                catch
                {
                    boolcheck = false;
                    MessageBox.Show("Please enter a number between 1-99");
                }
            }
            else if (radioButton2.Checked)
            {
                foreach (Player player in players)
                {
                    if (player.PlaceOfBirth.Contains(richTextBox1.Text))
                    {
                        returnList.Add(player);
                    }
                }
            }
            else
            {
                boolcheck = false;
                MessageBox.Show("No button are pressed. This shouldn't be possible");
            }

            foreach (Player x in returnList)
            {
                returnValue += "First Name: " + x.FName + "\nLast Name: " + x.LName + "\nID: " + x.Id + "\nHeight: " + x.Height + "\nWeight: " + x.Weight + "\nDate of Birth: " + x.BirthDate.ToString("dd/MM/yyyy") + "\nPlace of Birth: " + x.PlaceOfBirth +"\n";
            }
            if (returnValue != "")
            {
                boolcheck = false;
                MessageBox.Show("Matches:\n\n" + returnValue);
            }
            if (boolcheck)
            {
                MessageBox.Show("No Matches");
            }
        }

        private void playersBox_SelectedIndexChanged(object sender, EventArgs e) // event if select is changed on list box. if so displays data of player selected
        {
            Player x = new Player();

            try
            {
                foreach (Player player in players)
                {
                    if (playersBox.SelectedItem.ToString() == player.FName + " " + player.LName)
                    {
                        x = player;
                    }
                }
            }
            catch
            {
                Console.WriteLine("User Clicked on the edge of the select box, caused error. Hidden");
            }

            string output = "First Name: " + x.FName + "\nLast Name: " + x.LName + "\nID: " + x.Id + "\nHeight: " + x.Height + "\nWeight: " + x.Weight + "\nDate of Birth: " + x.BirthDate.ToString("dd/MM/yyyy") + "\nPlace of Birth: " + x.PlaceOfBirth;

            if (x.Team == null)
            {
                output += "\nTeam: Not Signed";
            }
            else
            {
                output += "\nTeam: " + x.Team;
            }
            MessageBox.Show(output);
        }

        private void teamsBox_SelectedIndexChanged(object sender, EventArgs e) // event if select is changed on list box. if so displays data of team selected
        {
            Team x = new Team();
            try
            {
                foreach (Team team in teams)
                {
                    if (teamsBox.SelectedItem.ToString() == team.Name)
                    {
                        x = team;
                    }
                }
            }
            catch
            {
                Console.WriteLine("User Clicked on the edge of the select box, caused error. Hidden");
            }

            string team_text =  "Name: " + x.Name + "\nGrounds: " + x.Ground + "\nCoaches: " + x.Coach + "\nFounded: " + x.Year + "\nRegion: " + x.Region + "\nPlayers: \n";
            
            string players_text = "";
            foreach (Player player in x.Players)
            {
                players_text += "First Name: " + player.FName + "\nLast Name: " + player.LName + "\nID: " + player.Id + "\nHeight: " + player.Height + "\nWeight: " + player.Weight + "\nDate of Birth: " + player.BirthDate + "\nPlace of Birth: " + player.PlaceOfBirth + "\n";
            }
            if (players_text == "")
            {
                players_text = "No Players Signed Yet";
            }
            MessageBox.Show(team_text + players_text);
        }
    }
}
