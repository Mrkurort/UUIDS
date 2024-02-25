using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace UUIDS
{
    public partial class Form3 : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;

        public Form3()
        {
            InitializeComponent();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Close();
            form2.Show();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPos = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastCursorPos.X) + e.X,
                    (this.Location.Y - lastCursorPos.Y) + e.Y);

                this.Update();
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void studBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Stud". При необходимости она может быть перемещена или удалена.
            this.studTableAdapter.Fill(this.dataSet1.Stud);
            flowLayoutPanel1.Controls.Clear();

            string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = UUIDS; Integrated Security = SSPI";
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();

                SqlCommand sqlCom = new SqlCommand($"Select * from Stud", conn);

                SqlDataReader reader = sqlCom.ExecuteReader();
                while (reader.Read())
                {
                    StudInfo info = new StudInfo();
                    info.GTB1.Text= reader.GetString(0);
                    info.GTB2.Text= reader.GetString(1);
                    info.GTB3.Text= reader.GetString(2);
                    info.GTB4.Text= reader.GetString(3);
                    info.GTB5.Text= reader.GetString(4);
                    info.GTB6.Text= reader.GetString(5);
                    info.GTB7.Text= reader.GetString(6);

                    flowLayoutPanel1 .Controls.Add(info);
                }


                reader.Close();
                sqlCom.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = UUIDS; Integrated Security = SSPI";
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();

                SqlCommand sqlCom = new SqlCommand($"Select * from Stud where Группа like @Searth", conn);
                sqlCom.Parameters.AddWithValue("@Searth",(string.Format("{0}%", guna2TextBox1.Text)));
                SqlDataReader reader = sqlCom.ExecuteReader();
                while (reader.Read())
                {
                    StudInfo info = new StudInfo();
                    info.GTB1.Text = reader.GetString(0);
                    info.GTB2.Text = reader.GetString(1);
                    info.GTB3.Text = reader.GetString(2);
                    info.GTB4.Text = reader.GetString(3);
                    info.GTB5.Text = reader.GetString(4);
                    info.GTB6.Text = reader.GetString(5);
                    info.GTB7.Text = reader.GetString(6);

                    flowLayoutPanel1.Controls.Add(info);
                }

                reader.Close();
                sqlCom.ExecuteNonQuery();
                conn.Close();
            }
        }

        
    }
}
