using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository
{
    public partial class FormGlavna : Form
    {
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void izaberiteTipPutovanjaToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string opcija = e.ClickedItem.Text;
            if (opcija.Equals("Letovanje"))
            {
                FormSvaLetovanja fsl = new FormSvaLetovanja();
                fsl.Show();

            }

            else if (opcija.Equals("Zimovanje"))
            {
                FormSvaZimovanja fsz = new FormSvaZimovanja();
                fsz.Show();

            }

            else if (opcija.Equals("Wellness&Spa"))
            {
                FormSviSpa fss = new FormSviSpa();
                fss.Show();
            }
            else if (opcija.Equals("Ekskurzija"))
            {
                FormSveEkskurzije fss = new FormSveEkskurzije();
                fss.Show();
            }
        }

        private void administratorToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FormAdministrator adminForm = new FormAdministrator();
            adminForm.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
