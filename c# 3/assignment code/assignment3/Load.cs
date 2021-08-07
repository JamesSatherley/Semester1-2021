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
    public partial class Load : Form
    {
        string players_url, teams_url;
        List<Team> teams;
        List<Player> players;

        internal Load(List<Team> teams_in, List<Player> players_in) // constructor
        {
            InitializeComponent();
            teams = teams_in;
            players = players_in;
        }

        internal (List<Team>, List<Player>) Import() // imports default data as given on stream
        {
            if (radioButtonReplace.Checked) 
            {
                teams = new List<Team>();
                players = new List<Player>();
            }
            bool check = false;
            string[] players_list = File.ReadAllLines(players_url);
            string[] teams_list = File.ReadAllLines(teams_url);
            foreach (string line in teams_list)
            {
                bool yesOrNo = true;
                string[] words = line.Split(new string[] { "; " }, StringSplitOptions.None);
                string[] foundedvsregion = words[3].Trim().Split(',');
                List<Player> x = new List<Player>();
                int founded = Int32.Parse(foundedvsregion[0].Replace("Founded", ""));
                foreach (Team t in teams)
                {
                    if (t.Name == words[0])
                    {
                        yesOrNo = false;
                        check = true;
                    }
                }
                if (yesOrNo)
                {
                    Team team = new Team(words[0], words[1], words[2], founded, foundedvsregion[1], x);
                    teams.Add(team);
                }
            }
            foreach (string line in players_list)
            {
                bool yesOrNo = true;
                string[] words = line.Split(new string[] { "; " }, StringSplitOptions.None);
                int id = Int32.Parse(words[0]);
                int height = Int32.Parse(words[4]);
                int weight = Int32.Parse(words[5]);
                DateTime bday = Convert.ToDateTime(words[3]);
                foreach (Player p in players) 
                {
                    if (p.Id == id) 
                    {
                        yesOrNo = false;
                        check = true;
                    }
                }
                if (yesOrNo)
                {
                    Player player = new Player(id, height, weight, words[1], words[2], words[6], bday);
                    players.Add(player);
                }
            }
            if (check) 
            {
                MessageBox.Show("One or more entries were not added as an id or name of that kind was already in the system");
            }
            (List<Team>, List<Player>) tup = (teams, players);
            return tup;
        }

        private void buttonLoadDefault_Click(object sender, EventArgs e) // gets from default dir
        {
            var url = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("file:\\", "");
            players_url = url + "\\players.txt";
            teams_url = url + "\\teams.txt";
            Close();
        }

        private void buttonLoadCustom_Click(object sender, EventArgs e) // imports from custom dir
        {
            MessageBox.Show("Please select your player database (.txt)");
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string x = openFile.FileName;
                if (x.Substring(x.Length - 4) == ".txt")
                {
                    players_url = x;
                }
            }

            MessageBox.Show("Please select your Teams database (.txt)");
            openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string x = openFile.FileName;
                if (x.Substring(x.Length - 4) == ".txt")
                {
                    teams_url = x;
                }
            }
            Close();
        }
    }
}
