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

namespace Week14_praktikum_Timotius_Septian_0706022110022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public DataTable Data = new DataTable();
        public int tempat = 0;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_name as team_name, t.team_id as team_id, CONCAT( t.home_stadium ,', ', t.city, ' (' ,t.capacity , ')') as stadium_name , CONCAT (m.manager_name, ' (',n.nation,')') as manager_name , m.manager_id, n.nationality_id, t.manager_id FROM team t, manager m, nationality n WHERE m.nationality_id = n.nationality_id and t.manager_id = m.manager_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Data);
            dataaja();
            
            
        }
        private void dataaja()
        {
            lbl_namateam.Text = Data.Rows[tempat]["team_name"].ToString();
            lbl_namamanager.Text = Data.Rows[tempat]["manager_name"].ToString();
            lbl_namastadium.Text = Data.Rows[tempat]["stadium_name"].ToString();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                tempat = 0;
                dataaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data sudah di awal!");
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            tempat--;
            if (tempat < 0)
            {
                tempat = tempat + 1;
                dataaja();
                MessageBox.Show("Data sudah di awal!");
            }
            else
            {
                dataaja();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tempat++;
            if (tempat > 858)
            {
                tempat = tempat - 1;
                dataaja();
                MessageBox.Show("Data sudah di akhir!");
            }
            else
            {
                dataaja();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                tempat = 858;
                dataaja();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data sudah di akhir!");
            }
        }
    }
}
