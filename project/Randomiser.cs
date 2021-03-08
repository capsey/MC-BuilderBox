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
    public partial class Randomiser : Form
    {
        Random rand = new Random();
        string selected;

        public Randomiser()
        {
            InitializeComponent();
        }

        private void interval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)interval.Value;
        }

        private void startButton_CheckedChanged(object sender, EventArgs e)
        {
            if(startButton.Checked)
            {
                selected = "";
                if (hotbar1.Checked) selected += hotbar1.Text;
                if (hotbar2.Checked) selected += hotbar2.Text;
                if (hotbar3.Checked) selected += hotbar3.Text;
                if (hotbar4.Checked) selected += hotbar4.Text;
                if (hotbar5.Checked) selected += hotbar5.Text;
                if (hotbar6.Checked) selected += hotbar6.Text;
                if (hotbar7.Checked) selected += hotbar7.Text;
                if (hotbar8.Checked) selected += hotbar8.Text;
                if (hotbar9.Checked) selected += hotbar9.Text;

                if (selected.Length < 2)
                {
                    startButton.Checked = false;
                    MessageBox.Show("You should choose at least 2 hotbar items to randomiser work properly.", "Error!");
                }
            }

            startButton.Text = startButton.Checked ? "Stop" : "Start";
            timer.Enabled = startButton.Checked;
            interval.Enabled = !startButton.Checked;

            hotbar1.Enabled = !startButton.Checked;
            hotbar2.Enabled = !startButton.Checked;
            hotbar3.Enabled = !startButton.Checked;
            hotbar4.Enabled = !startButton.Checked;
            hotbar5.Enabled = !startButton.Checked;
            hotbar6.Enabled = !startButton.Checked;
            hotbar7.Enabled = !startButton.Checked;
            hotbar8.Enabled = !startButton.Checked;
            hotbar9.Enabled = !startButton.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Form.ActiveForm == this)
                return;

            string keyToPress = selected[rand.Next(selected.Length)].ToString();
            SendKeys.SendWait(keyToPress);
        }
    }
}
