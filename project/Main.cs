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
            randomizerForm = new Randomizer();
            randomizerForm.Show(this);

            randomizer.Enabled = false;
            randomizerForm.FormClosed += (s, args) => {
                randomizer.Enabled = true;
            };
        }

        private void bookWriter_Click(object sender, EventArgs e)
        {
            bookWriterForm = new BookWriter();
            bookWriterForm.Show(this);

            bookWriter.Enabled = false;
            bookWriterForm.FormClosed += (s, args) => {
                bookWriter.Enabled = true;
            };
        }

        private void about_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.Show(this);

            about.Enabled = false;
            aboutForm.FormClosed += (s, args) => {
                about.Enabled = true;
            };
        }
    }
}
