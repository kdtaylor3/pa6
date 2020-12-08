
using System;

namespace PA6
{
    partial class frmMain
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
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.txtCopiesData = new System.Windows.Forms.TextBox();
            this.txtISBNData = new System.Windows.Forms.TextBox();
            this.txtLengthData = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblCopesAv = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 24;
            this.lstBooks.Location = new System.Drawing.Point(12, 36);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(337, 388);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged_1);
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(379, 48);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(234, 29);
            this.txtTitleData.TabIndex = 1;
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(379, 107);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(234, 29);
            this.txtAuthorData.TabIndex = 2;
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(379, 165);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(234, 29);
            this.txtGenreData.TabIndex = 3;
            // 
            // txtCopiesData
            // 
            this.txtCopiesData.Location = new System.Drawing.Point(379, 226);
            this.txtCopiesData.Name = "txtCopiesData";
            this.txtCopiesData.Size = new System.Drawing.Size(234, 29);
            this.txtCopiesData.TabIndex = 4;
            // 
            // txtISBNData
            // 
            this.txtISBNData.Location = new System.Drawing.Point(379, 286);
            this.txtISBNData.Name = "txtISBNData";
            this.txtISBNData.Size = new System.Drawing.Size(234, 29);
            this.txtISBNData.TabIndex = 5;
            // 
            // txtLengthData
            // 
            this.txtLengthData.Location = new System.Drawing.Point(379, 349);
            this.txtLengthData.Name = "txtLengthData";
            this.txtLengthData.Size = new System.Drawing.Size(234, 29);
            this.txtLengthData.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(408, 427);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 30);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(531, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(657, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(777, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(657, 325);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(95, 78);
            this.btnRent.TabIndex = 11;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(777, 325);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 78);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(375, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(375, 80);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 24);
            this.lblAuthor.TabIndex = 14;
            this.lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(375, 138);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(63, 24);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            // 
            // lblCopesAv
            // 
            this.lblCopesAv.AutoSize = true;
            this.lblCopesAv.Location = new System.Drawing.Point(375, 199);
            this.lblCopesAv.Name = "lblCopesAv";
            this.lblCopesAv.Size = new System.Drawing.Size(150, 24);
            this.lblCopesAv.TabIndex = 16;
            this.lblCopesAv.Text = "Copies Available";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(375, 258);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 24);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "ISBN";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(375, 318);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 24);
            this.lblLength.TabIndex = 18;
            this.lblLength.Text = "Length";
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(657, 46);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(206, 248);
            this.pbCover.TabIndex = 19;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 469);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblCopesAv);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtLengthData);
            this.Controls.Add(this.txtISBNData);
            this.Controls.Add(this.txtCopiesData);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lstBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.TextBox txtCopiesData;
        private System.Windows.Forms.TextBox txtISBNData;
        private System.Windows.Forms.TextBox txtLengthData;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblCopesAv;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.PictureBox pbCover;
    }
}