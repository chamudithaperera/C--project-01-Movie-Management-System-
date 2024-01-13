using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManagementSystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private AddMovieDetails addMV = new AddMovieDetails();
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            addMV.Show();
            this.Hide();
        }
    }
}
