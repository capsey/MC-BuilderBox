using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_BuilderBox
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/capsey/MC-BuilderBox/");
            Process.Start(sInfo);
        }

        private void githubProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/capsey/");
            Process.Start(sInfo);
        }

        private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.gnu.org/licenses/gpl-3.0.html");
            Process.Start(sInfo);
        }

        private void creditLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.nuget.org/packages/NonInvasiveKeyboardHookLibrary/");
            Process.Start(sInfo);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.nuget.org/packages/Costura.Fody/");
            Process.Start(sInfo);
        }
    }
}
