﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Stud". При необходимости она может быть перемещена или удалена.
            this.studTableAdapter.Fill(this.dataSet1.Stud);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var quit = MessageBox.Show("Вы действительно хотите закрыть?", "Закрыть",MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            var quit = MessageBox.Show("Вы действительно хотите закрыть?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
