using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dtPlayerIdentity = new DataTable();
        DataTable dtManager = new DataTable();
        DataTable dtFindMatch = new DataTable();
        DataTable dtFindMatch2 = new DataTable();
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public Form1()
        {

            InitializeComponent();
            sqlQuery = "SELECT player_name, team_name, playing_pos, weight, height  FROM premier_league.player p, premier_league.team WHERE p.team_id = team.team_id and ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dt);
            
        }

        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            sqlQuery = "SELECT team_name, team_id FROM premier_league.team t;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            comboBoxPanel1.DataSource = dt;
            comboBoxPanel1.DisplayMember = "team_name";
            comboBoxPanel1.ValueMember = "team_id";
            comboBoxPanel2.DataSource = dt;
            comboBoxPanel2.DisplayMember = "team_name";
            comboBoxPanel2.ValueMember = "team_id";
        }

        private void buttonOkFindMatch_Click(object sender, EventArgs e)
        {
            dtFindMatch.Rows.Clear();
            sqlQuery = $"SELECT t.team_name as team_name_1, t2.team_name as team_name_2, match_date, goal_home, goal_away, referee_name FROM premier_league.team t, premier_league.team t2, premier_league.referee r, premier_league.`match` m WHERE r.referee_id = m.referee_id and m.team_home = t.team_id and m.team_away = t2.team_id and t.team_id = '{comboBoxPanel2.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtFindMatch);

            sqlQuery = $"SELECT t.team_name as team_name_1, t2.team_name as team_name_2, match_date, goal_home, goal_away, referee_name FROM premier_league.team t, premier_league.team t2, premier_league.referee r, premier_league.`match` m WHERE r.referee_id = m.referee_id and m.team_home = t.team_id and m.team_away = t2.team_id and t2.team_id = '{comboBoxPanel2.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtFindMatch);
            dataGridView3.DataSource = dtFindMatch;
        }

        private void buttonOKTeamData_Click(object sender, EventArgs e)
        {
            dtManager.Rows.Clear();
            dtPlayerIdentity.Rows.Clear();
            sqlQuery = $"SELECT player_name, team_name, playing_pos, weight, height  FROM premier_league.player p, premier_league.team WHERE p.team_id = team.team_id and team.team_id = '{comboBoxPanel1.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerIdentity);
            dataGridView1.DataSource = dtPlayerIdentity;

            sqlQuery = $"SELECT team_name, manager_name, birthdate, nation FROM premier_league.manager m, premier_league.nationality n, premier_league.team t WHERE m.manager_id = t.manager_id and n.nationality_id = m.nationality_id and t.team_id = '{comboBoxPanel1.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtManager);
            dataGridView2.DataSource = dtManager;
        }

        private void comboBoxPanel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dtFindMatch.Rows.Clear();
            //sqlQuery = $"SELECT t.team_name as team_name_1, t2.team_name as team_name_2, match_date, goal_home, goal_away, referee_name FROM premier_league.team t, premier_league.team t2, premier_league.referee r, premier_league.`match` m WHERE r.referee_id = m.referee_id and m.team_home = t.team_id and m.team_away = t2.team_id and t.team_id = '{comboBoxPanel2.SelectedValue.ToString()}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtFindMatch);

            //sqlQuery = $"SELECT t.team_name as team_name_1, t2.team_name as team_name_2, match_date, goal_home, goal_away, referee_name FROM premier_league.team t, premier_league.team t2, premier_league.referee r, premier_league.`match` m WHERE r.referee_id = m.referee_id and m.team_home = t.team_id and m.team_away = t2.team_id and t2.team_id = '{comboBoxPanel2.SelectedValue.ToString()}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtFindMatch);
            //dataGridView3.DataSource = dtFindMatch;
        }

        private void comboBoxPanel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dtManager.Rows.Clear();
            //sqlQuery = $"SELECT player_name, team_name, playing_pos, weight, height  FROM premier_league.player p, premier_league.team WHERE p.team_id = team.team_id and team.team_id = '{comboBoxPanel1.SelectedValue.ToString()}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtPlayerIdentity);
            //dataGridView1.DataSource = dtPlayerIdentity;

            //sqlQuery = $"SELECT team_name, manager_name, birthdate, nation FROM premier_league.manager m, premier_league.nationality n, premier_league.team t WHERE m.manager_id = t.manager_id and n.nationality_id = m.nationality_id and t.team_id = '{comboBoxPanel1.SelectedValue.ToString()}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtManager);
            //dataGridView2.DataSource = dtManager;
        }
    }
}
