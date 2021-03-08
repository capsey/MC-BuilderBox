using NonInvasiveKeyboardHookLibrary;
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
        KeyboardHookManager keyboardHookManager = new KeyboardHookManager();

        Random rand = new Random();
        string selected;

        public Randomiser()
        {
            InitializeComponent();
            mainBox.SelectedIndex = 0;

            keyboardHookManager.Start();
            keyboardHookManager.RegisterHotkey(0x31, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x32, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x33, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x34, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x35, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x36, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x37, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x38, NumKeysPressed);
            keyboardHookManager.RegisterHotkey(0x39, NumKeysPressed);
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
                if (hotbar1.Checked && mainBox.SelectedIndex != 1) selected += hotbar1.Text;
                if (hotbar2.Checked && mainBox.SelectedIndex != 2) selected += hotbar2.Text;
                if (hotbar3.Checked && mainBox.SelectedIndex != 3) selected += hotbar3.Text;
                if (hotbar4.Checked && mainBox.SelectedIndex != 4) selected += hotbar4.Text;
                if (hotbar5.Checked && mainBox.SelectedIndex != 5) selected += hotbar5.Text;
                if (hotbar6.Checked && mainBox.SelectedIndex != 6) selected += hotbar6.Text;
                if (hotbar7.Checked && mainBox.SelectedIndex != 7) selected += hotbar7.Text;
                if (hotbar8.Checked && mainBox.SelectedIndex != 8) selected += hotbar8.Text;
                if (hotbar9.Checked && mainBox.SelectedIndex != 9) selected += hotbar9.Text;

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

            string keyToPress;

            if (mainBox.SelectedIndex == 0)
                keyToPress = selected[rand.Next(selected.Length)].ToString();
            else
            {
                if (rand.Next(2) == 0) keyToPress = mainBox.SelectedIndex.ToString();
                else keyToPress = selected[rand.Next(selected.Length)].ToString();
            }

            keyboardHookManager.Stop();
            SendKeys.SendWait(keyToPress);
            keyboardHookManager.Start();
        }

        private void NumKeysPressed()
        {
            if (!startButton.Checked) return;

            Action action = () => startButton.Checked = false;
            Invoke(action);
        }
    }
}
