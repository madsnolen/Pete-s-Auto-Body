using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pete_s_Auto_Body_Managemnet_App
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madison\Documents\GarageDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(CarNumTb.Text == "Car Number" || CarBrandTb.Text == "Car Brand" || CarModelTb.Text == "Car Model" || ColorTb.Text == "Color" || OwnerNameTb.Text == "Owner Name" || CarNumTb.Text =="" || CarBrandTb.Text == "" || CarModelTb.Text == "" || ColorTb.Text == "")
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CarTbl(CNum,CBrand,CModel,CDate,CColor,OwnerName) values(@CN,@CB,@CM,@CD,@CC,@ON)", Con);
                    cmd.Parameters.AddWithValue("@CN",CarNumTb.Text);
                    cmd.Parameters.AddWithValue("@CB", CarBrandTb.Text);
                    cmd.Parameters.AddWithValue("@CM", CarModelTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CDate.Text);
                    cmd.Parameters.AddWithValue("@CC", ColorTb.Text);
                    cmd.Parameters.AddWithValue("@ON", OwnerNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Register");
                    Con.Close();

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

    }
}
