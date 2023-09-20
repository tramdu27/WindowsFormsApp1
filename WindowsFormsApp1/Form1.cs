using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicWebDataSet.pcd_GetUsers' table. You can move, or remove it, as needed.
            this.pcd_GetUsersTableAdapter.Fill(this.basicWebDataSet.pcd_GetUsers);
            // TODO: This line of code loads data into the 'basicWebDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.basicWebDataSet.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
