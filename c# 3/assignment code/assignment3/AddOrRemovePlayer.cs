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
    public partial class AddOrRemovePlayer : Form
    {
        bool exitCheck = false;

        List<Player> players;
        List<Player> players_export = new List<Player>();

        internal AddOrRemovePlayer(List<Player> players_in) // constructor
        {
            InitializeComponent();
            players = players_in;
            players_export = players;
        }

        private void AddOrRemove_Load(object sender, EventArgs e) // on load display players
        {
            UpdateListView();
        }

        public void UpdateListView() // updates list box with new players
        {
            PlayersList.Items.Clear();

            foreach (Player player in players)
            {
                string output = player.FName + " " + player.LName;
                PlayersList.Items.Add(output.Replace("\n", ""));
            }
        }

        internal (List<Player>, bool) ReturnValues() // returns to main
        {
            (List<Player>, bool) t = (players_export, exitCheck);
            return t;
        }

        private void PlayersList_SelectedIndexChanged(object sender, EventArgs e) // event for if select changes. if so remove that player
        {
            Player x = new Player();

            foreach (Player player in players)
            {
                if (PlayersList.SelectedItem.ToString() == player.FName + " " + player.LName)
                {
                    x = player;
                }
            }
            players.Remove(x);
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e) // adds new player if data matches what it should be
        {
            int id, height, weight;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || dateTimePicker1.Value.ToString("dd/MM/yyyy") == "01/01/2021")
            {
                MessageBox.Show("Error: Some input is blank");
            }
            else 
            {
                try
                {
                    bool tof = true;
                    id = Int32.Parse(textBox3.Text);

                    foreach (Player player in players)
                    {
                        if (player.Id == id) 
                        {
                            MessageBox.Show("Duplicate ID");
                            tof = false;
                        }
                    }
                    if (tof)
                    {
                        height = Int32.Parse(textBox5.Text);
                        weight = Int32.Parse(textBox6.Text);
                        Player x = new Player(id, height, weight, textBox1.Text, textBox2.Text, textBox7.Text, dateTimePicker1.Value);
                        players.Add(x);
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
            players_export = players;
            exitCheck = true;
            Close();
        }
    }
}
