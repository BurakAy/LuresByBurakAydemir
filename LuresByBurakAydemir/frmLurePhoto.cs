//Burak Aydemir

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burakAydemirFinalProject
{
    public partial class frmLurePhoto : Form
    {
        string picture;

        public frmLurePhoto()
        {
            InitializeComponent();
        }

        public frmLurePhoto(string photo)
        {
            picture = photo;

            InitializeComponent();
        }

        private void frmLurePhoto_Load_1(object sender, EventArgs e)
        {
            try
            {
                pbLure.Image = Image.FromFile(picture);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
