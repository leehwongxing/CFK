using GTranslator.Services;
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

        public API_SignIn()
        {
            People = new People();

            InitializeComponent();
        }

        private void API_SignIn_Shown(object sender, System.EventArgs e)
        {
            People.SignIn();

            var person = People.RequestProfile();

            FullName = person.Names[0].DisplayName;
            //Residence = person.Residences
            //    .Where(x => x.Current == true)
            //    .Select(x => x.Value)
            //    .Single();

            Avatar = person.Photos[0].Url;
        }

        private void TX_FullName_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
