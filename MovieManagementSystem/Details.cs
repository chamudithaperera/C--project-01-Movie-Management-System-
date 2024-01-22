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
    public partial class Details : Form
    {

        private AddMovieDetails addMovieDet = null;
        public Details()
        {
            InitializeComponent();
        }

        public Details(AddMovieDetails addMovieDet)
        {
            addMovieDet = addMovieDet;
            InitializeComponent();

            labelMovieName.Text = addMovieDet.getMovieName();
            labelMovieID.Text = addMovieDet.getMovieID();
            labelReview.Text = addMovieDet.getReview();
            labelDirector.Text = addMovieDet.getDirector();
            labelEmail.Text = addMovieDet.getEmail();
            labelProductionCompany.Text = addMovieDet.getPeoductionCompany();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(addMovieDet == null || addMovieDet.IsDisposed)
            {
                addMovieDet = new AddMovieDetails(this);
            }
            addMovieDet.Show();
            this.Hide();

        }
    }
}
