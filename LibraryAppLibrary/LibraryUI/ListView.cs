using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class ListView : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public ListView()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            b.addAuthor(titleTextBox.Text);
            b.addTitle(authorTextBox.Text);
            b.addGenre(genreTextBox.Text);
            
            ListViewItem item = new ListViewItem(new String[] {b.getTitle(), b.getAuthor(), b.getGenre() });
            materialListView1.Items.Add(item);
            titleTextBox.Clear();
            authorTextBox.Clear();
            genreTextBox.Clear();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (materialListView1.Items.Count > 0)
                materialListView1.Items.Remove(materialListView1.SelectedItems[0]);
            else return;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (materialListView1.Items.Count > 0)
            {
                materialListView1.SelectedItems[0].SubItems[1].Text = titleTextBox.Text;
                materialListView1.SelectedItems[0].SubItems[0].Text = authorTextBox.Text;
                materialListView1.SelectedItems[0].SubItems[2].Text = genreTextBox.Text;
            }

            else return;          
            
        }

        private void ListView_Load(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
