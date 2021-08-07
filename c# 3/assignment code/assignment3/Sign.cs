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
    public partial class Sign : Form
    {
        List<Player> players;
        List<Team> teams;
        Team selected_team;
        Player selected_player;

        internal Sign(List<Player> players_in, List<Team> teams_in) // constructor
        {
            players = players_in;
            teams = teams_in;
            InitializeComponent();
        }

        private void Sign_Load(object sender, EventArgs e) // on load update listviews
        {
            UpdateListView();
        }

        private void teambox_SelectedIndexChanged(object sender, EventArgs e) // on select change event, change selected team
        {
            try 
            { 
                foreach (Team team in teams)
                {
                    if (teambox.SelectedItem.ToString() == team.Name)
                    {
                        selected_team = team;
                    }
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("User Clicked on the edge of the select box, caused error. Hidden");
            }
        }

        private void playerbox_SelectedIndexChanged(object sender, EventArgs e) // on select change event, change selected player
        {
            try { 
                foreach (Player player in players)
                {
                    if (playerbox.SelectedItem.ToString() == player.FName + " " + player.LName)
                    {
                        selected_player = player;
                    }
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("User Clicked on the edge of the select box, caused error. Hidden");
            }
        }

        private void button1_Click(object sender, EventArgs e) // on button click, check if team in player is null, if so check with user the sign, else
        {                                                      // player is already signed
            if (selected_player.Team == null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to sign this person to a team?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    selected_player.Team = selected_team.Name;
                    selected_team.Players.Add(selected_player);
                    MessageBox.Show(selected_player.FName + "'s Team is now: " + selected_team.Name);
                }
            }
            else
            {
                MessageBox.Show(selected_player.FName + " is already Signed. Please unsign them first");
            }
        }

        private void button2_Click(object sender, EventArgs e) // on button click, check if team isnt null. if so, check with user to unsign, else say player not signed
        {
            if (selected_player.Team != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to unsign this person from their team?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    selected_player.Team = null;
                    selected_team.Players.Remove(selected_player);
                    MessageBox.Show(selected_player.FName + " is now Unsigned");
                }
            }
            else 
            {
                MessageBox.Show(selected_player.FName + " is already Unsigned");
            }
        }

        public void UpdateListView() // update listviews
        {
            playerbox.Items.Clear();
            teambox.Items.Clear();

            foreach (Player player in players)
            {
                string output = player.FName + " " + player.LName;
                playerbox.Items.Add(output.Replace("\n", ""));
            }

            foreach (Team team in teams)
            {
                string output = team.Name;
                teambox.Items.Add(output.Replace("\n", ""));
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) // close form on close click
        {
            Close();
        }
    }
}