using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UUIDS
{
    public partial class StudInfo : UserControl
    {
        public StudInfo()
        {
            InitializeComponent();
            
        }

        public Guna2TextBox GTB1
        {
            get { return guna2TextBox1; }
            set { guna2TextBox1 = value; }
        }
        public Guna2TextBox GTB2
        {
            get { return guna2TextBox2; }
            set { guna2TextBox2 = value; }
        }
        public Guna2TextBox GTB3
        {
            get { return guna2TextBox3; }
            set { guna2TextBox3 = value; }
        }
        public Guna2TextBox GTB4
        {
            get { return guna2TextBox4; }
            set { guna2TextBox4 = value; }
        }
        public Guna2TextBox GTB5
        {
            get { return guna2TextBox5; }
            set { guna2TextBox5 = value; }
        }
        public Guna2TextBox GTB6
        {
            get { return guna2TextBox6; }
            set { guna2TextBox6 = value; }
        }
        public Guna2TextBox GTB7
        {
            get { return guna2TextBox7; }
            set { guna2TextBox7 = value; }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var del = MessageBox.Show("Вы действительно хотите удалить карточку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                var delC = MessageBox.Show("Подтверждение приведёт к безвозвратному удалению информации!", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delC == DialogResult.Yes)
                {

                }
            }
        }
    }
}
