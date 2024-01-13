using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MovieManagementSystem
{
    public partial class AddMovieDetails : Form
    {

        private Details det = null;
        public AddMovieDetails()
        {
            InitializeComponent();
        }
        public AddMovieDetails(Details det)
        {
            det = det;
            InitializeComponent();
        }

        private Boolean validateData()
        {
            string movieName = textBoxMovieName.Text;
            string movieID = textBoxMovieID.Text;
            string review = textBoxReview.Text;
            string director = textBoxDirector.Text;
            string email = textBoxEmail.Text;
            string productionCompany = textBoxProductionCompany.Text;


            if (!string.IsNullOrEmpty(movieName))
            {
                if (!Regex.Match(movieName, @"^[A-Za-z\s]+$").Success)
                {
                    errorProviderMovieName.SetError(textBoxMovieName,"Invalid Name!");
                    textBoxMovieName.Focus();
                    return false;
                }
            }
            else
            {
                errorProviderMovieName.SetError(textBoxMovieName, "Field is empty!");
                textBoxMovieName.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(movieID))
            {
                if (!Regex.Match(movieID, @"^\d{4}/[A-Za-z]{4}-\d{1,3}$").Success)
                {
                    errorProviderMovieID.SetError(textBoxMovieID, "Invalid Movie ID!");
                    textBoxMovieID.Focus();
                    return false;
                }
            }
            else
            {
                errorProviderMovieName.SetError(textBoxMovieID, "Field is empty!");
                textBoxMovieID.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(review))
            {
                if (!Regex.Match(review, @"^\d{1}$").Success)
                {
                    errorProviderReview.SetError(textBoxReview, "Invalid Review");
                    textBoxReview.Focus();
                    return false;
                }
            }
            else
            {
                errorProviderReview.SetError(textBoxReview, "Field is empty!");
                textBoxReview.Focus();
                return false;
            }


            if (!string.IsNullOrEmpty(director))
            {
                if (!Regex.Match(director, @"^[A-Za-z\s]+$").Success)
                {
                    errorProviderDirector.SetError(textBoxDirector, "Invalid Director");
                    textBoxDirector.Focus();
                    return false;
                }
            }
            else
            {
                errorProviderDirector.SetError(textBoxDirector, "Field is empty!");
                textBoxDirector.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(email))
            {
                if (!Regex.Match(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$").Success)
                {
                    errorProviderEmail.SetError(textBoxEmail, "Invalid Email ID!");
                    textBoxEmail.Focus();
                    return false;
                }
            }
            else
            {
                errorProviderEmail.SetError(textBoxEmail, "Field is empty!");
                textBoxEmail.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(productionCompany))
            {
                if (!Regex.Match(productionCompany, @"^[A-Za-z\s]+$").Success)
                {
                    errorProviderProductionCompany.SetError(textBoxProductionCompany, "Invalid Production company!");
                    textBoxProductionCompany.Focus();
                    return false;
                }
            }
            else
            {
                errorProviderProductionCompany.SetError(textBoxProductionCompany, "Field is empty!");
                textBoxProductionCompany.Focus();
                return false;
            }

            return true;
        }

        private void clearFields()
        {
            textBoxMovieName.Clear();
            textBoxMovieID.Clear();
            textBoxReview.Clear();
            textBoxDirector.Clear();
            textBoxEmail.Clear();
            textBoxProductionCompany.Clear();
        }

        private void buttonAddDetails_Click(object sender, EventArgs e)
        {
            if (validateData() == true)
            {
                MessageBox.Show("Successfully Added!\n To view the details click Ok.", "Adding details to the system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (det == null || det.IsDisposed)
                {
                    det = new Details(this);
                }
                det.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in fields!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getMovieName()
        {
            return textBoxMovieName.Text;
        }

        public string getMovieID()
        {
            return textBoxMovieID.Text;
        }

        public string getReview()
        {
            return textBoxReview.Text;
        }

        public string getDirector()
        {
            return textBoxDirector.Text;
        }

        public string getEmail()
        {
            return textBoxEmail.Text;
        }

        public string getPeoductionCompany()
        {
            return textBoxProductionCompany.Text;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
