using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class Save : Form
    {
        string players_url, teams_url;
        List<Team> teams;
        List<Player> players;

        internal Save(List<Team> teams_in, List<Player> players_in) // constructor
        {
            InitializeComponent();
            teams = teams_in;
            players = players_in;
        }

        public void Saver() // save data in normal output as given by stream
        {
            List<string> teams_output = new List<string>();
            foreach (Team team in teams)
            {
                teams_output.Add(team.Name + "; " + team.Ground + "; " + team.Coach + "; Founded " + team.Year + ", " + team.Region);
            }
            string[] teamArray = teams_output.ToArray();
            File.WriteAllLines(teams_url, teamArray);

            List<string> player_output = new List<string>();
            foreach (Player player in players)
            {
                string x = player.Id + "; " + player.FName + "; " + player.LName + "; " + player.BirthDate.ToString("dd/MM/yyyy") + "; " + player.Height + "; " + player.Weight + "; " + player.PlaceOfBirth;
                if (player.Team != null)
                {
                    x += "; " + player.Team;
                }
                player_output.Add(x);
            }
            string[] playerArray = player_output.ToArray();
            File.WriteAllLines(players_url, playerArray);
        }

        public void SaverPlayers() // save players and their signed team
        {
            List<string> player_output = new List<string>();
            foreach (Player player in players)
            {
                string x = player.Id + "; " + player.FName + "; " + player.LName + "; " + player.BirthDate.ToString("dd/MM/yyyy") + "; " + player.Height + "; " + player.Weight + "; " + player.PlaceOfBirth;
                if (player.Team != null)
                {
                    x += "; Signed to: " + player.Team;
                }
                player_output.Add(x);
            }
            string[] playerArray = player_output.ToArray();
            File.WriteAllLines(players_url.Replace("\\players.txt", "\\playersWithTeams.txt"), playerArray);
        }

        public void SaverTeams() // save teams and its signed players
        {
            List<string> teams_output = new List<string>();
            foreach (Team team in teams)
            {
                teams_output.Add(team.Name + "; " + team.Ground + "; " + team.Coach + "; Founded " + team.Year + ", " + team.Region);
                foreach (Player player in team.Players)
                {
                    teams_output.Add(player.Id + "; " + player.FName + "; " + player.LName + "; " + player.BirthDate.ToString("dd/MM/yyyy") + "; " + player.Height + "; " + player.Weight + "; " + player.PlaceOfBirth);
                }
            }
            string[] teamArray = teams_output.ToArray();
            File.WriteAllLines(teams_url.Replace("\\teams.txt", "\\teamsWithSignedPlayers.txt"), teamArray);
        }

        internal bool Export() // export called by main, finds which button clicked and save relevant data to relevant location, else closes (should be impossible)
        {
            if (radioButtonPlayerTeam.Checked)
            {
                Saver();
            }
            else if (radioButtonPlayersSigned.Checked)
            {
                SaverPlayers();
            }
            else if (radioButtonTeamsSigned.Checked)
            {
                SaverTeams();
            }
            else 
            {
                Close();
                MessageBox.Show("Getting here shouldn't be possible. Closing for safety");
            }

            if (radioButtonRemove.Checked) // if remove true returns whether to del data or not
            {
                return true;
            }
            return false;
        }

        private void buttonSaveDefault_Click(object sender, EventArgs e) // default save location, root dir
        {
            var url = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("file:\\", "");
            players_url = url + "\\players.txt";
            teams_url = url + "\\teams.txt";
            Close();
        }

        private void buttonSaveCustom_Click(object sender, EventArgs e) // custom file dialog save dir
        {
            MessageBox.Show("Please select the folder you'd like to save the files in");
            FolderBrowserDialog saveFile = new FolderBrowserDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                players_url = saveFile.SelectedPath + "\\players.txt";
                teams_url = saveFile.SelectedPath + "\\teams.txt";
            }
            Close();
        }
    }
}
