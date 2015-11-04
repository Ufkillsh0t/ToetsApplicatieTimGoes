using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToetsApplicatie
{
    public partial class Form1 : Form
    {
        private Administratie admin;

        public Form1()
        {
            InitializeComponent();
            admin = new Administratie();
        }

        private void btnNieuweVerhuringToevoegen_Click(object sender, EventArgs e)
        {
            if (cbNieuweVerhuring.SelectedItem != null)
            {
                if (cbNieuweVerhuring.SelectedItem.ToString() == "Feestzaal")
                {
                    admin.Voegtoe(new Feestzaal(dtpNieuweVerhuringTijdstip.Value, Convert.ToInt32(nudNieuweVerhuringUren.Value)));
                }
                if (cbNieuweVerhuring.SelectedItem.ToString() == "Sportzaal")
                {
                    admin.Voegtoe(new Sportzaal(dtpNieuweVerhuringTijdstip.Value, Convert.ToInt32(nudNieuweVerhuringUren.Value)));
                }
                if (cbNieuweVerhuring.SelectedItem.ToString() == "Vergaderzaal")
                {
                    admin.Voegtoe(new Vergaderzaal(dtpNieuweVerhuringTijdstip.Value, Convert.ToInt32(nudNieuweVerhuringUren.Value)));
                }
                RefreshVerhuurBox(); 
            }
            else
            {
                MessageBox.Show("Er is niets in de combobox gevult");
            }
        }

        private void RefreshVerhuurBox()
        {
            lbVerhuringen.Items.Clear();
            foreach (Verhuur v in admin.verhuringen)
            {
                lbVerhuringen.Items.Add(v.ToString());
            }
        }

        private void btnNieuweVerkoopToevoegen_Click(object sender, EventArgs e)
        {
            if (cbNieuweVerkoop.SelectedItem != null)
            {
                if (cbNieuweVerkoop.SelectedItem.ToString() == "Frisdrank")
                {
                    admin.Voegtoe(new Frisdrank(Convert.ToInt32(nudNieuweVerkoopAantal.Value)));
                }
                if (cbNieuweVerkoop.SelectedItem.ToString() == "Snack")
                {
                    admin.Voegtoe(new Snack(Convert.ToInt32(nudNieuweVerkoopAantal.Value)));
                }
                if (cbNieuweVerkoop.SelectedItem.ToString() == "Sterkedrank")
                {
                    admin.Voegtoe(new Sterkedrank(Convert.ToInt32(nudNieuweVerkoopAantal.Value)));
                }
                RefreshVerkoopBox();
            }
            else
            {
                MessageBox.Show("Er is niets in de combobox gevult");
            }
        }

        private void RefreshVerkoopBox()
        {
            lbVerkopen.Items.Clear();
            foreach (Verkoop v in admin.verkopen)
            {
                lbVerkopen.Items.Add(v.ToString());
            }
        }
    }
}
