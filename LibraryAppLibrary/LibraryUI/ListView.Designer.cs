
using System;

namespace LibraryUI
{
    partial class ListView
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
            this.addBtn = new MaterialSkin.Controls.MaterialButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            this.Genre = new System.Windows.Forms.ColumnHeader();
            this.titleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.genreTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.editBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addBtn.Depth = 0;
            this.addBtn.HighEmphasis = true;
            this.addBtn.Icon = null;
            this.addBtn.Location = new System.Drawing.Point(453, 89);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(93, 36);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Book";
            this.addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addBtn.UseAccentColor = false;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteBtn.Depth = 0;
            this.deleteBtn.HighEmphasis = true;
            this.deleteBtn.Icon = null;
            this.deleteBtn.Location = new System.Drawing.Point(453, 141);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(116, 36);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete Book";
            this.deleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteBtn.UseAccentColor = false;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.Genre});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(6, 276);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(859, 229);
            this.materialListView1.TabIndex = 2;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 160;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 160;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 160;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Depth = 0;
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleTextBox.LeadingIcon = null;
            this.titleTextBox.Location = new System.Drawing.Point(176, 70);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(115, 50);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.Text = "";
            this.titleTextBox.TrailingIcon = null;
            this.titleTextBox.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // authorTextBox
            // 
            this.authorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorTextBox.Depth = 0;
            this.authorTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorTextBox.LeadingIcon = null;
            this.authorTextBox.Location = new System.Drawing.Point(176, 124);
            this.authorTextBox.MaxLength = 50;
            this.authorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorTextBox.Multiline = false;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(115, 50);
            this.authorTextBox.TabIndex = 7;
            this.authorTextBox.Text = "";
            this.authorTextBox.TrailingIcon = null;
            this.authorTextBox.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // genreTextBox
            // 
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreTextBox.Depth = 0;
            this.genreTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genreTextBox.LeadingIcon = null;
            this.genreTextBox.Location = new System.Drawing.Point(176, 174);
            this.genreTextBox.MaxLength = 50;
            this.genreTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.genreTextBox.Multiline = false;
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(115, 50);
            this.genreTextBox.TabIndex = 8;
            this.genreTextBox.Text = "";
            this.genreTextBox.TrailingIcon = null;
            this.genreTextBox.TextChanged += new System.EventHandler(this.materialTextBox3_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(36, 89);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 30);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Title";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(36, 143);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(77, 30);
            this.authorLabel.TabIndex = 10;
            this.authorLabel.Text = "Author";
            this.authorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(36, 194);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(69, 30);
            this.genreLabel.TabIndex = 11;
            this.genreLabel.Text = "Genre";
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editBtn.Depth = 0;
            this.editBtn.HighEmphasis = true;
            this.editBtn.Icon = null;
            this.editBtn.Location = new System.Drawing.Point(453, 194);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(64, 36);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Edit";
            this.editBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editBtn.UseAccentColor = false;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 561);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListView";
            this.Text = "LibraryApp";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton addBtn;
        private MaterialSkin.Controls.MaterialButton deleteBtn;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Genre;
        private MaterialSkin.Controls.MaterialTextBox titleTextBox;
        private MaterialSkin.Controls.MaterialTextBox authorTextBox;
        private MaterialSkin.Controls.MaterialTextBox genreTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label genreLabel;
        private MaterialSkin.Controls.MaterialButton editBtn;
    }
}

