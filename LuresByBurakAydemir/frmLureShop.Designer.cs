namespace burakAydemirFinalProject
{
    partial class frmLureShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lureColorLabel;
            System.Windows.Forms.Label lureDescriptionLabel;
            System.Windows.Forms.Label lureIDLabel;
            System.Windows.Forms.Label lureLengthLabel;
            System.Windows.Forms.Label lureManufacturerLabel;
            System.Windows.Forms.Label lureNameLabel;
            System.Windows.Forms.Label lurePriceLabel;
            System.Windows.Forms.Label lureTypeLabel;
            System.Windows.Forms.Label lureWeightLabel;
            System.Windows.Forms.Label pictureNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLureShop));
            this.lureColorTextBox = new System.Windows.Forms.TextBox();
            this.lureDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.lureIDTextBox = new System.Windows.Forms.TextBox();
            this.lureLengthTextBox = new System.Windows.Forms.TextBox();
            this.lureManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.lureNameTextBox = new System.Windows.Forms.TextBox();
            this.lurePriceTextBox = new System.Windows.Forms.TextBox();
            this.lureTypeTextBox = new System.Windows.Forms.TextBox();
            this.lureWeightTextBox = new System.Windows.Forms.TextBox();
            this.pictureNameTextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnViewPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lureColorLabel = new System.Windows.Forms.Label();
            lureDescriptionLabel = new System.Windows.Forms.Label();
            lureIDLabel = new System.Windows.Forms.Label();
            lureLengthLabel = new System.Windows.Forms.Label();
            lureManufacturerLabel = new System.Windows.Forms.Label();
            lureNameLabel = new System.Windows.Forms.Label();
            lurePriceLabel = new System.Windows.Forms.Label();
            lureTypeLabel = new System.Windows.Forms.Label();
            lureWeightLabel = new System.Windows.Forms.Label();
            pictureNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lureColorLabel
            // 
            lureColorLabel.AutoSize = true;
            lureColorLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureColorLabel.Location = new System.Drawing.Point(80, 217);
            lureColorLabel.Name = "lureColorLabel";
            lureColorLabel.Size = new System.Drawing.Size(40, 14);
            lureColorLabel.TabIndex = 15;
            lureColorLabel.Text = "Color:";
            // 
            // lureDescriptionLabel
            // 
            lureDescriptionLabel.AutoSize = true;
            lureDescriptionLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureDescriptionLabel.Location = new System.Drawing.Point(18, 269);
            lureDescriptionLabel.Name = "lureDescriptionLabel";
            lureDescriptionLabel.Size = new System.Drawing.Size(102, 14);
            lureDescriptionLabel.TabIndex = 19;
            lureDescriptionLabel.Text = "Lure Description:";
            // 
            // lureIDLabel
            // 
            lureIDLabel.AutoSize = true;
            lureIDLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureIDLabel.Location = new System.Drawing.Point(71, 60);
            lureIDLabel.Name = "lureIDLabel";
            lureIDLabel.Size = new System.Drawing.Size(49, 14);
            lureIDLabel.TabIndex = 3;
            lureIDLabel.Text = "Lure ID:";
            // 
            // lureLengthLabel
            // 
            lureLengthLabel.AutoSize = true;
            lureLengthLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureLengthLabel.Location = new System.Drawing.Point(71, 164);
            lureLengthLabel.Name = "lureLengthLabel";
            lureLengthLabel.Size = new System.Drawing.Size(49, 14);
            lureLengthLabel.TabIndex = 11;
            lureLengthLabel.Text = "Length:";
            // 
            // lureManufacturerLabel
            // 
            lureManufacturerLabel.AutoSize = true;
            lureManufacturerLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureManufacturerLabel.Location = new System.Drawing.Point(36, 86);
            lureManufacturerLabel.Name = "lureManufacturerLabel";
            lureManufacturerLabel.Size = new System.Drawing.Size(84, 14);
            lureManufacturerLabel.TabIndex = 5;
            lureManufacturerLabel.Text = "Manufacturer:";
            // 
            // lureNameLabel
            // 
            lureNameLabel.AutoSize = true;
            lureNameLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureNameLabel.Location = new System.Drawing.Point(50, 112);
            lureNameLabel.Name = "lureNameLabel";
            lureNameLabel.Size = new System.Drawing.Size(70, 14);
            lureNameLabel.TabIndex = 7;
            lureNameLabel.Text = "Lure Name:";
            // 
            // lurePriceLabel
            // 
            lurePriceLabel.AutoSize = true;
            lurePriceLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lurePriceLabel.Location = new System.Drawing.Point(82, 243);
            lurePriceLabel.Name = "lurePriceLabel";
            lurePriceLabel.Size = new System.Drawing.Size(38, 14);
            lurePriceLabel.TabIndex = 17;
            lurePriceLabel.Text = "Price:";
            // 
            // lureTypeLabel
            // 
            lureTypeLabel.AutoSize = true;
            lureTypeLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureTypeLabel.Location = new System.Drawing.Point(55, 138);
            lureTypeLabel.Name = "lureTypeLabel";
            lureTypeLabel.Size = new System.Drawing.Size(65, 14);
            lureTypeLabel.TabIndex = 9;
            lureTypeLabel.Text = "Lure Type:";
            // 
            // lureWeightLabel
            // 
            lureWeightLabel.AutoSize = true;
            lureWeightLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lureWeightLabel.Location = new System.Drawing.Point(72, 190);
            lureWeightLabel.Name = "lureWeightLabel";
            lureWeightLabel.Size = new System.Drawing.Size(48, 14);
            lureWeightLabel.TabIndex = 13;
            lureWeightLabel.Text = "Weight:";
            // 
            // pictureNameLabel
            // 
            pictureNameLabel.AutoSize = true;
            pictureNameLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pictureNameLabel.Location = new System.Drawing.Point(37, 341);
            pictureNameLabel.Name = "pictureNameLabel";
            pictureNameLabel.Size = new System.Drawing.Size(83, 14);
            pictureNameLabel.TabIndex = 21;
            pictureNameLabel.Text = "Picture Name:";
            // 
            // lureColorTextBox
            // 
            this.lureColorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureColor", true));
            this.lureColorTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureColorTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureColorTextBox.Location = new System.Drawing.Point(124, 215);
            this.lureColorTextBox.Name = "lureColorTextBox";
            this.lureColorTextBox.ReadOnly = true;
            this.lureColorTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureColorTextBox.TabIndex = 16;
            // 
            // lureDescriptionTextBox
            // 
            this.lureDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureDescription", true));
            this.lureDescriptionTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureDescriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureDescriptionTextBox.Location = new System.Drawing.Point(124, 267);
            this.lureDescriptionTextBox.Multiline = true;
            this.lureDescriptionTextBox.Name = "lureDescriptionTextBox";
            this.lureDescriptionTextBox.ReadOnly = true;
            this.lureDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lureDescriptionTextBox.Size = new System.Drawing.Size(149, 66);
            this.lureDescriptionTextBox.TabIndex = 20;
            // 
            // lureIDTextBox
            // 
            this.lureIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureID", true));
            this.lureIDTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureIDTextBox.Location = new System.Drawing.Point(124, 58);
            this.lureIDTextBox.Name = "lureIDTextBox";
            this.lureIDTextBox.ReadOnly = true;
            this.lureIDTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureIDTextBox.TabIndex = 4;
            // 
            // lureLengthTextBox
            // 
            this.lureLengthTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureLengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureLength", true));
            this.lureLengthTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureLengthTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureLengthTextBox.Location = new System.Drawing.Point(124, 162);
            this.lureLengthTextBox.Name = "lureLengthTextBox";
            this.lureLengthTextBox.ReadOnly = true;
            this.lureLengthTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureLengthTextBox.TabIndex = 12;
            // 
            // lureManufacturerTextBox
            // 
            this.lureManufacturerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureManufacturerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureManufacturer", true));
            this.lureManufacturerTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureManufacturerTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureManufacturerTextBox.Location = new System.Drawing.Point(124, 84);
            this.lureManufacturerTextBox.Name = "lureManufacturerTextBox";
            this.lureManufacturerTextBox.ReadOnly = true;
            this.lureManufacturerTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureManufacturerTextBox.TabIndex = 6;
            // 
            // lureNameTextBox
            // 
            this.lureNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureName", true));
            this.lureNameTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureNameTextBox.Location = new System.Drawing.Point(124, 110);
            this.lureNameTextBox.Name = "lureNameTextBox";
            this.lureNameTextBox.ReadOnly = true;
            this.lureNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureNameTextBox.TabIndex = 8;
            // 
            // lurePriceTextBox
            // 
            this.lurePriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lurePriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lurePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LurePrice", true));
            this.lurePriceTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lurePriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.lurePriceTextBox.Location = new System.Drawing.Point(124, 241);
            this.lurePriceTextBox.Name = "lurePriceTextBox";
            this.lurePriceTextBox.ReadOnly = true;
            this.lurePriceTextBox.Size = new System.Drawing.Size(149, 20);
            this.lurePriceTextBox.TabIndex = 18;
            // 
            // lureTypeTextBox
            // 
            this.lureTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureType", true));
            this.lureTypeTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureTypeTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureTypeTextBox.Location = new System.Drawing.Point(124, 136);
            this.lureTypeTextBox.Name = "lureTypeTextBox";
            this.lureTypeTextBox.ReadOnly = true;
            this.lureTypeTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureTypeTextBox.TabIndex = 10;
            // 
            // lureWeightTextBox
            // 
            this.lureWeightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lureWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lureWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "LureWeight", true));
            this.lureWeightTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lureWeightTextBox.ForeColor = System.Drawing.Color.Black;
            this.lureWeightTextBox.Location = new System.Drawing.Point(124, 188);
            this.lureWeightTextBox.Name = "lureWeightTextBox";
            this.lureWeightTextBox.ReadOnly = true;
            this.lureWeightTextBox.Size = new System.Drawing.Size(149, 20);
            this.lureWeightTextBox.TabIndex = 14;
            // 
            // pictureNameTextBox
            // 
            this.pictureNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lureBindingSource, "PictureName", true));
            this.pictureNameTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.pictureNameTextBox.Location = new System.Drawing.Point(124, 339);
            this.pictureNameTextBox.Name = "pictureNameTextBox";
            this.pictureNameTextBox.ReadOnly = true;
            this.pictureNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.pictureNameTextBox.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(250, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(66, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(158, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 26);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(203, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 26);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(127, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 26);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(269, 379);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(32, 26);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(203, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 26);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(137, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 26);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(99, 379);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(32, 26);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnViewPhoto
            // 
            this.btnViewPhoto.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnViewPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnViewPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnViewPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPhoto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPhoto.Location = new System.Drawing.Point(349, 336);
            this.btnViewPhoto.Name = "btnViewPhoto";
            this.btnViewPhoto.Size = new System.Drawing.Size(90, 26);
            this.btnViewPhoto.TabIndex = 27;
            this.btnViewPhoto.Text = "View Photo";
            this.btnViewPhoto.UseVisualStyleBackColor = true;
            this.btnViewPhoto.Click += new System.EventHandler(this.btnViewPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lureBindingSource
            // 
            this.lureBindingSource.DataSource = typeof(burakAydemirFinalProject.Lure);
            this.lureBindingSource.CurrentChanged += new System.EventHandler(this.lureBindingSource_CurrentChanged);
            // 
            // frmLureShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::LuresByBurakAydemir.Properties.Resources.bass_fish;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(509, 455);
            this.Controls.Add(this.btnViewPhoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(lureColorLabel);
            this.Controls.Add(this.lureColorTextBox);
            this.Controls.Add(lureDescriptionLabel);
            this.Controls.Add(this.lureDescriptionTextBox);
            this.Controls.Add(lureIDLabel);
            this.Controls.Add(this.lureIDTextBox);
            this.Controls.Add(lureLengthLabel);
            this.Controls.Add(this.lureLengthTextBox);
            this.Controls.Add(lureManufacturerLabel);
            this.Controls.Add(this.lureManufacturerTextBox);
            this.Controls.Add(lureNameLabel);
            this.Controls.Add(this.lureNameTextBox);
            this.Controls.Add(lurePriceLabel);
            this.Controls.Add(this.lurePriceTextBox);
            this.Controls.Add(lureTypeLabel);
            this.Controls.Add(this.lureTypeTextBox);
            this.Controls.Add(lureWeightLabel);
            this.Controls.Add(this.lureWeightTextBox);
            this.Controls.Add(pictureNameLabel);
            this.Controls.Add(this.pictureNameTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLureShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Lure Shop";
            this.Load += new System.EventHandler(this.frmLureShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lureBindingSource;
        private System.Windows.Forms.TextBox lureColorTextBox;
        private System.Windows.Forms.TextBox lureDescriptionTextBox;
        private System.Windows.Forms.TextBox lureIDTextBox;
        private System.Windows.Forms.TextBox lureLengthTextBox;
        private System.Windows.Forms.TextBox lureManufacturerTextBox;
        private System.Windows.Forms.TextBox lureNameTextBox;
        private System.Windows.Forms.TextBox lurePriceTextBox;
        private System.Windows.Forms.TextBox lureTypeTextBox;
        private System.Windows.Forms.TextBox lureWeightTextBox;
        private System.Windows.Forms.TextBox pictureNameTextBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnViewPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

