using System.Runtime.CompilerServices;

namespace CD_Management_System
{
    partial class Form1
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
            dgvAlbumList = new DataGridView();
            dgvSongList = new DataGridView();
            label1 = new Label();
            txtAlbumName = new TextBox();
            label2 = new Label();
            intReleaseYear = new TextBox();
            txtAuthor = new TextBox();
            txtAlbumGerne = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dblPrice = new TextBox();
            intQuantity = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDescription = new RichTextBox();
            create = new Button();
            update = new Button();
            delete = new Button();
            cancel = new Button();
            label9 = new Label();
            txtSongName = new TextBox();
            label10 = new Label();
            txtDuration = new TextBox();
            label11 = new Label();
            intAlbumID = new TextBox();
            label12 = new Label();
            intSongID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSongList).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbumList
            // 
            dgvAlbumList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumList.Location = new Point(11, 12);
            dgvAlbumList.Name = "dgvAlbumList";
            dgvAlbumList.RowHeadersWidth = 51;
            dgvAlbumList.RowTemplate.Height = 29;
            dgvAlbumList.Size = new Size(599, 219);
            dgvAlbumList.TabIndex = 0;
            dgvAlbumList.CellClick += getSongList;
            // 
            // dgvSongList
            // 
            dgvSongList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSongList.Location = new Point(11, 251);
            dgvSongList.Name = "dgvSongList";
            dgvSongList.RowHeadersWidth = 51;
            dgvSongList.RowTemplate.Height = 29;
            dgvSongList.Size = new Size(599, 219);
            dgvSongList.TabIndex = 1;
            dgvSongList.CellClick += chooseSong;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Album Name";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(710, 12);
            txtAlbumName.Margin = new Padding(3, 4, 3, 4);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(159, 27);
            txtAlbumName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 55);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Release Year";
            // 
            // intReleaseYear
            // 
            intReleaseYear.Location = new Point(710, 51);
            intReleaseYear.Margin = new Padding(3, 4, 3, 4);
            intReleaseYear.Name = "intReleaseYear";
            intReleaseYear.Size = new Size(159, 27);
            intReleaseYear.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(710, 89);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(159, 27);
            txtAuthor.TabIndex = 6;
            // 
            // txtAlbumGerne
            // 
            txtAlbumGerne.Location = new Point(710, 128);
            txtAlbumGerne.Margin = new Padding(3, 4, 3, 4);
            txtAlbumGerne.Name = "txtAlbumGerne";
            txtAlbumGerne.Size = new Size(159, 27);
            txtAlbumGerne.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 93);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 8;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 132);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Gerne";
            // 
            // dblPrice
            // 
            dblPrice.Location = new Point(710, 167);
            dblPrice.Margin = new Padding(3, 4, 3, 4);
            dblPrice.Name = "dblPrice";
            dblPrice.Size = new Size(159, 27);
            dblPrice.TabIndex = 10;
            // 
            // intQuantity
            // 
            intQuantity.Location = new Point(710, 205);
            intQuantity.Margin = new Padding(3, 4, 3, 4);
            intQuantity.Name = "intQuantity";
            intQuantity.Size = new Size(159, 27);
            intQuantity.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 171);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(617, 209);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(617, 171);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 14;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(902, 16);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(902, 40);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 195);
            txtDescription.TabIndex = 16;
            txtDescription.Text = "";
            // 
            // create
            // 
            create.Location = new Point(1137, 39);
            create.Margin = new Padding(3, 4, 3, 4);
            create.Name = "create";
            create.Size = new Size(86, 31);
            create.TabIndex = 17;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += operation;
            // 
            // update
            // 
            update.Location = new Point(1137, 77);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(86, 31);
            update.TabIndex = 18;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += operation;
            // 
            // delete
            // 
            delete.Location = new Point(1138, 116);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(86, 31);
            delete.TabIndex = 19;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += operation;
            // 
            // cancel
            // 
            cancel.Location = new Point(1138, 155);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(86, 31);
            cancel.TabIndex = 20;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += operation;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(617, 248);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 21;
            label9.Text = "Song Name";
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(710, 244);
            txtSongName.Margin = new Padding(3, 4, 3, 4);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new Size(159, 27);
            txtSongName.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(617, 288);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 23;
            label10.Text = "Duration";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(710, 283);
            txtDuration.Margin = new Padding(3, 4, 3, 4);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(159, 27);
            txtDuration.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(617, 443);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 25;
            label11.Text = "Album ID";
            // 
            // intAlbumID
            // 
            intAlbumID.Location = new Point(710, 439);
            intAlbumID.Margin = new Padding(3, 4, 3, 4);
            intAlbumID.Name = "intAlbumID";
            intAlbumID.Size = new Size(159, 27);
            intAlbumID.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(617, 407);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 27;
            label12.Text = "Song ID";
            // 
            // intSongID
            // 
            intSongID.Location = new Point(710, 404);
            intSongID.Margin = new Padding(3, 4, 3, 4);
            intSongID.Name = "intSongID";
            intSongID.Size = new Size(159, 27);
            intSongID.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 481);
            Controls.Add(intSongID);
            Controls.Add(label12);
            Controls.Add(intAlbumID);
            Controls.Add(label11);
            Controls.Add(txtDuration);
            Controls.Add(label10);
            Controls.Add(txtSongName);
            Controls.Add(label9);
            Controls.Add(cancel);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(create);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(intQuantity);
            Controls.Add(dblPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAlbumGerne);
            Controls.Add(txtAuthor);
            Controls.Add(intReleaseYear);
            Controls.Add(label2);
            Controls.Add(txtAlbumName);
            Controls.Add(label1);
            Controls.Add(dgvSongList);
            Controls.Add(dgvAlbumList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAlbumList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSongList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlbumList;
        private DataGridView dgvSongList;
        private Label label1;
        private TextBox txtAlbumName;
        private Label label2;
        private TextBox intReleaseYear;
        private TextBox txtAuthor;
        private TextBox txtAlbumGerne;
        private Label label3;
        private Label label4;
        private TextBox dblPrice;
        private TextBox intQuantity;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RichTextBox txtDescription;
        private Button create;
        private Button update;
        private Button delete;
        private Button cancel;
        private Label label9;
        private TextBox txtSongName;
        private Label label10;
        private TextBox txtDuration;
        private Label label11;
        private TextBox intAlbumID;
        private Label label12;
        private TextBox intSongID;
    }
}