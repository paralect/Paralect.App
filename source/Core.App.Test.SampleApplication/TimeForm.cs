using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace Core.App.Test.SampleApplication
{
    public partial class TimeForm : Form
    {
        [Dependency]
        public TimeService Service { get; set; }

        public TimeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            timeLabel.Text = Service.GetTime();
        }
    }
}
