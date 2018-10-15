using GTranslator.Services;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GTranslator.Views
{
    public partial class API_SignIn : Form
    {
        private People People { get; set; }

        private string FullName { get { return TX_FullName.Text; } set { TX_FullName.Text = value; } }

        private string Residence { get { return TX_Residence.Text; } set { TX_Residence.Text = value; } }

        private string Avatar { get { return ""; } set { PB_Avatar.Load(value); } }

        private BackgroundWorker Wee { get; set; }

        private System.Timers.Timer SignInTimer { get; set; }

        public API_SignIn()
        {
            Wee = new BackgroundWorker();
            Wee.RunWorkerCompleted += Wee_RunWorkerCompleted;

            SignInTimer = new System.Timers.Timer
            {
                Interval = 16000,
                Enabled = false,
                AutoReset = false
            };

            SignInTimer.Elapsed += new System.Timers.ElapsedEventHandler(SignInTimeOut);
            SignInTimer.Start();

            People = new People();
            People.SignIn();

            InitializeComponent();
            SignInTimer.Stop();
        }

        private void Wee_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispose();
        }

        private void SignInTimeOut(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("That takes a bit too long. Are you sure to continue?", "Man, that takes some time...", MessageBoxButtons.YesNo);
            if (Result != DialogResult.Yes) Wee.RunWorkerAsync();
        }

        private void API_SignIn_Shown(object sender, System.EventArgs e)
        {
            People.SignIn();

            var person = People.RequestProfile();

            FullName = person.Names[0].DisplayName;
            Residence = (person.Residences == null)
                ? "Unknown Residence"
                : person.Residences
                    .Where(x => x.Current == true)
                    .Select(x => x.Value)
                    .FirstOrDefault();
            Avatar = person.Photos[0].Url;
        }

        private void BT_SignOff_Click(object sender, EventArgs e)
        {
            People.SignOut();
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }
    }
}
