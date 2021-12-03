using Janaka_Ayya_Software.Contact_Person_related_Views;
using System;
using System.Windows.Forms;

namespace Janaka_Ayya_Software
{
    public partial class FormHomeView : Form
    {
        public FormHomeView()
        {
            InitializeComponent();
        }

        private void btnGeneralPublicView_Click(object sender, EventArgs e)
        {
            Form publicView = new FormGeneralPublicView(this);
            publicView.Show();
            this.Hide();
        }

        private void btnContactPersonView_Click(object sender, EventArgs e)
        {
            Form contactPersonView = new FormContactPersonView(this);
            contactPersonView.Show();
            this.Hide();
        }
    }
}
