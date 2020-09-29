using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Testing1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vishalini\Documents\Car_Database.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display_Data();
        }



        private void btn_Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Car_Table values('"+txt_CarName.Text+"','"+txt_CarNumber.Text+"','"+txt_CarLocation.Text+"','"+txt_CarAvailability.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            Display_Data();
            Clear_text();
            MessageBox.Show("Record Inserted Successfully");

        }

        public void Clear_text()
        {
            txt_CarName.Text = "";
            txt_CarNumber.Text = "";
            txt_CarLocation.Text = "";
            txt_CarAvailability.Text = "";
            txt_CarNewName.Text = "";
        }


        public void Display_Data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Car_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
         }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Car_Table where Car_Name ='"+txt_CarName.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            Display_Data();
            Clear_text();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Car_Table set Car_Name ='"+txt_CarNewName.Text+"' where Car_Name = '"+txt_CarName.Text+"'   ";
            cmd.ExecuteNonQuery();
            con.Close();
            Display_Data();
            Clear_text();
            MessageBox.Show("Record Updated Successfully");
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Car_Table where Car_Name = '"+txt_CarName.Text+"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Clear_text();
            con.Close();
        }
    }
}
