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
    public partial class frmLureShop : Form
    {

        LureDataLayer dataHandler = new LureDataLayer();
        List<Lure> theLures = new List<Lure>();

        Lure currentLure;
        Lure aLure;
        bool addingNew = false;
        int bookmark = 0;

        public frmLureShop()
        {
            InitializeComponent();
        }

        private void frmLureShop_Load(object sender, EventArgs e)
        {
            theLures = dataHandler.getLuresFromDatabase();
            lureBindingSource.DataSource = theLures;
        }

        private void enableControls()
        {
            lureManufacturerTextBox.ReadOnly = false;
            lureNameTextBox.ReadOnly = false;
            lureTypeTextBox.ReadOnly = false;
            lureLengthTextBox.ReadOnly = false;
            lureWeightTextBox.ReadOnly = false;
            lureColorTextBox.ReadOnly = false;
            lurePriceTextBox.ReadOnly = false;
            lureDescriptionTextBox.ReadOnly = false;
            pictureNameTextBox.ReadOnly = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void disableControls()
        {
            lureManufacturerTextBox.ReadOnly = true;
            lureNameTextBox.ReadOnly = true;
            lureTypeTextBox.ReadOnly = true;
            lureLengthTextBox.ReadOnly = true;
            lureWeightTextBox.ReadOnly = true;
            lureColorTextBox.ReadOnly = true;
            lurePriceTextBox.ReadOnly = true;
            lureDescriptionTextBox.ReadOnly = true;
            pictureNameTextBox.ReadOnly = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            lureBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lureBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lureBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lureBindingSource.MoveLast();
        }
        
        private void lureBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            currentLure = (Lure)lureBindingSource.Current;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addingNew)
            {
                currentLure.LureManufacturer = lureManufacturerTextBox.Text;
                currentLure.LureName = lureNameTextBox.Text;
                currentLure.LureType = lureTypeTextBox.Text;
                currentLure.LureLength = lureLengthTextBox.Text;
                currentLure.LureWeight = lureWeightTextBox.Text;
                currentLure.LureColor = lureColorTextBox.Text;
                currentLure.LurePrice = lurePriceTextBox.Text;
                currentLure.LureDescription = lureDescriptionTextBox.Text;
                
                string[] stringParts = openFileDialog1.FileName.Split('\\');
                string pic = stringParts[stringParts.GetUpperBound(0)];
                currentLure.PictureName = pic;

                dataHandler.addNewLureToDatabase(currentLure);

                lureIDTextBox.Text = dataHandler.getNewRecordID();

                lureBindingSource.MovePrevious();
                lureBindingSource.MoveNext();
                
                addingNew = false;
            }
            else
            {
                currentLure.LureManufacturer = lureManufacturerTextBox.Text;
                currentLure.LureName = lureNameTextBox.Text;
                currentLure.LureType = lureTypeTextBox.Text;
                currentLure.LureLength = lureLengthTextBox.Text;
                currentLure.LureWeight = lureWeightTextBox.Text;
                currentLure.LureColor = lureColorTextBox.Text;
                currentLure.LurePrice = lurePriceTextBox.Text;
                currentLure.LureDescription = lureDescriptionTextBox.Text;
                currentLure.PictureName = pictureNameTextBox.Text;

                dataHandler.editLure(currentLure);
            }

            disableControls();
            btnViewPhoto.Text = "View Photo";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (addingNew)
            {
                theLures.RemoveAt(theLures.Count - 1);
                lureBindingSource.Position = bookmark;
                addingNew = false;
            }
            else
            {
                lureIDTextBox.Text = aLure.LureID;
                lureManufacturerTextBox.Text = aLure.LureManufacturer;
                lureNameTextBox.Text = aLure.LureName;
                lureTypeTextBox.Text = aLure.LureType;
                lureLengthTextBox.Text = aLure.LureLength;
                lureWeightTextBox.Text = aLure.LureWeight;
                lureColorTextBox.Text = aLure.LureColor;
                lurePriceTextBox.Text = aLure.LurePrice;
                lureDescriptionTextBox.Text = aLure.LureDescription;
                pictureNameTextBox.Text = aLure.PictureName;
            }

            disableControls();
            btnViewPhoto.Text = "View Photo";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lure newLure = new Lure();
            theLures.Add(newLure);
            lureBindingSource.MoveLast();
            addingNew = true;
            btnViewPhoto.Text = "Add Photo";

            enableControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            aLure = new Lure(lureIDTextBox.Text, lureManufacturerTextBox.Text, lureNameTextBox.Text, lureTypeTextBox.Text, lureLengthTextBox.Text, lureWeightTextBox.Text, lureColorTextBox.Text, lurePriceTextBox.Text, lureDescriptionTextBox.Text, pictureNameTextBox.Text);
            
            enableControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            currentLure.LureID = lureIDTextBox.Text;

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                dataHandler.deleteLureFromDatabase(currentLure);
                lureBindingSource.RemoveCurrent();
            }
        }

        private void btnViewPhoto_Click(object sender, EventArgs e)
        {
            frmLurePhoto photoForm = new frmLurePhoto(pictureNameTextBox.Text);

            if (addingNew)
            {
                openFileDialog1.ShowDialog();
            }
            else
            {
                photoForm.Show();
            }
        }

    }
}
