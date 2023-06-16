namespace CD_Management_System
{
    partial class AlbumManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleAlbum = new Label();
            dgvAlbum = new DataGridView();
            txtAlbumName = new TextBox();
            AlbumName = new Label();
            ReleaseYear = new Label();
            txtReleaseYear = new TextBox();
            txtAuthor = new TextBox();
            Author = new Label();
            txtGenre = new TextBox();
            Genre = new Label();
            Quantity = new Label();
            txtQuantity = new TextBox();
            Description = new Label();
            txtDescription = new RichTextBox();
            txtPrice = new TextBox();
            Price = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            button4 = new Button();
            AlbumID = new Label();
            txtAlbumId = new TextBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            SuspendLayout();
            // 
            // TitleAlbum
            // 
            TitleAlbum.AutoSize = true;
            TitleAlbum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TitleAlbum.ForeColor = Color.Red;
            TitleAlbum.Location = new Point(402, 47);
            TitleAlbum.Name = "TitleAlbum";
            TitleAlbum.Size = new Size(113, 28);
            TitleAlbum.TabIndex = 0;
            TitleAlbum.Text = "Album List";
            // 
            // dgvAlbum
            // 
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(47, 93);
            dgvAlbum.Margin = new Padding(3, 4, 3, 4);
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.RowHeadersWidth = 51;
            dgvAlbum.RowTemplate.Height = 25;
            dgvAlbum.Size = new Size(832, 223);
            dgvAlbum.TabIndex = 1;
            dgvAlbum.CellContentClick += dgvAlbum_CellContentClick;
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(193, 393);
            txtAlbumName.Margin = new Padding(3, 4, 3, 4);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(266, 27);
            txtAlbumName.TabIndex = 2;
            // 
            // AlbumName
            // 
            AlbumName.AutoSize = true;
            AlbumName.Location = new Point(57, 397);
            AlbumName.Name = "AlbumName";
            AlbumName.Size = new Size(97, 20);
            AlbumName.TabIndex = 3;
            AlbumName.Text = "Album Name";
            // 
            // ReleaseYear
            // 
            ReleaseYear.AutoSize = true;
            ReleaseYear.Location = new Point(57, 449);
            ReleaseYear.Name = "ReleaseYear";
            ReleaseYear.Size = new Size(92, 20);
            ReleaseYear.TabIndex = 4;
            ReleaseYear.Text = "Release Year";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(193, 445);
            txtReleaseYear.Margin = new Padding(3, 4, 3, 4);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(266, 27);
            txtReleaseYear.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(193, 504);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(266, 27);
            txtAuthor.TabIndex = 6;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(57, 508);
            Author.Name = "Author";
            Author.Size = new Size(54, 20);
            Author.TabIndex = 7;
            Author.Text = "Author";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(633, 341);
            txtGenre.Margin = new Padding(3, 4, 3, 4);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(225, 27);
            txtGenre.TabIndex = 8;
            // 
            // Genre
            // 
            Genre.AutoSize = true;
            Genre.Location = new Point(543, 345);
            Genre.Name = "Genre";
            Genre.Size = new Size(48, 20);
            Genre.TabIndex = 9;
            Genre.Text = "Genre";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(543, 397);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(65, 20);
            Quantity.TabIndex = 10;
            Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(633, 387);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(225, 27);
            txtQuantity.TabIndex = 11;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(57, 556);
            Description.Name = "Description";
            Description.Size = new Size(85, 20);
            Description.TabIndex = 13;
            Description.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(57, 597);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(434, 116);
            txtDescription.TabIndex = 14;
            txtDescription.Text = "";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(633, 445);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(225, 27);
            txtPrice.TabIndex = 15;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(549, 449);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 16;
            Price.Text = "Price";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(549, 525);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 63);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(733, 525);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 63);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(549, 619);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 63);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button4
            // 
            button4.Location = new Point(733, 619);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(146, 63);
            button4.TabIndex = 20;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // AlbumID
            // 
            AlbumID.AutoSize = true;
            AlbumID.Location = new Point(57, 352);
            AlbumID.Name = "AlbumID";
            AlbumID.Size = new Size(72, 20);
            AlbumID.TabIndex = 21;
            AlbumID.Text = "Album ID";
            // 
            // txtAlbumId
            // 
            txtAlbumId.Location = new Point(193, 341);
            txtAlbumId.Margin = new Padding(3, 4, 3, 4);
            txtAlbumId.Name = "txtAlbumId";
            txtAlbumId.Size = new Size(266, 27);
            txtAlbumId.TabIndex = 22;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(764, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 36);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AlbumManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 753);
            Controls.Add(btnLogout);
            Controls.Add(txtAlbumId);
            Controls.Add(AlbumID);
            Controls.Add(button4);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(Price);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(Description);
            Controls.Add(txtQuantity);
            Controls.Add(Quantity);
            Controls.Add(Genre);
            Controls.Add(txtGenre);
            Controls.Add(Author);
            Controls.Add(txtAuthor);
            Controls.Add(txtReleaseYear);
            Controls.Add(ReleaseYear);
            Controls.Add(AlbumName);
            Controls.Add(txtAlbumName);
            Controls.Add(dgvAlbum);
            Controls.Add(TitleAlbum);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AlbumManagement";
            Text = "AlbumManagement";
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleAlbum;
        private DataGridView dgvAlbum;
        private TextBox txtAlbumName;
        private Label AlbumName;
        private Label ReleaseYear;
        private TextBox txtReleaseYear;
        private TextBox txtAuthor;
        private Label Author;
        private TextBox txtGenre;
        private Label Genre;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label Description;
        private RichTextBox txtDescription;
        private TextBox txtPrice;
        private Label Price;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button4;
        private Label Quantity;
        private TextBox txtQuantity;
        private Label AlbumID;
        private TextBox txtAlbumId;
        private Button btnLogout;
    }
}