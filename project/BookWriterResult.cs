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
    public partial class BookWriterResult : Form
    {
        Page[] pages;
        int currentPage;

        public BookWriterResult(Page[] result)
        {
            InitializeComponent();

            pages = result;

            currentPage = 0;
            UpdatePage();
        }

        private void UpdatePage()
        {
            counter.Text = (currentPage + 1) + " / " + pages.Length;
            pageText.Text = pages[currentPage].GetText();

            const int padding = 5;

            pageText.SelectAll();
            pageText.SelectionIndent += padding;
            pageText.SelectionRightIndent += padding;
            pageText.DeselectAll();

            prevPage.Enabled = currentPage > 0;
            nextPage.Enabled = currentPage < pages.Length - 1;
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            UpdatePage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            UpdatePage();
        }
    }
}
