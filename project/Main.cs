using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_BuilderBox
{
    public partial class Main : Form
    {
        Randomizer randomizerForm;
        BookWriter bookWriterForm;
        About aboutForm;

        public Main()
        {
            InitializeComponent();
        }

        private void randomizer_Click(object sender, EventArgs e)
        {
            if (randomizerForm != null)
            {
                randomizerForm.BringToFront();
            }
            else
            {
                randomizerForm = new Randomizer();
                randomizerForm.Show();

                this.Enabled = false;
                randomizerForm.FormClosed += (s, args) => {
                    this.Enabled = true;
                    randomizerForm = null;
                };
            }
        }

        private void bookWriter_Click(object sender, EventArgs e)
        {
            if (bookWriterForm != null)
            {
                bookWriterForm.BringToFront();
            }
            else
            {
                bookWriterForm = new BookWriter();
                bookWriterForm.Show();

                this.Enabled = false;
                bookWriterForm.FormClosed += (s, args) => {
                    this.Enabled = true;
                    bookWriterForm = null;
                };
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            if (aboutForm != null)
            {
                aboutForm.BringToFront();
            }
            else
            {
                aboutForm = new About();
                aboutForm.Show();

                this.Enabled = false;
                aboutForm.FormClosed += (s, args) => {
                    this.Enabled = true;
                    aboutForm = null;
                };
            }
        }
    }
}
