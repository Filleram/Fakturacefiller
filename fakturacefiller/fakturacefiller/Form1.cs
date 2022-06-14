using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturacefiller
{
    public partial class Form1 : Form

    {

        List<Faktura> faktury;
        SqlRepository sqlRepository = new SqlRepository();
        public Form1()
        {
            InitializeComponent();
            faktury = sqlRepository.GetFaktura();
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            LvData.Items.Clear();
            foreach (Faktura faktura in faktury)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    faktura.id + "",
                    faktura.datum.ToString("dd.MM.yyyy"),
                    faktura.cislo + "",
                    faktura.odberatel + "",
                    faktura.nazev + "",
                    faktura.pocet + " ks",
                    faktura.cena1 + " Kč",
                    faktura.cenacelkem + " Kč",
                    faktura.DPH + "%",
                    faktura.cenasDPH + " Kč"

                });
                LvData.Items.Add(listViewItem);
            }
        }


    }
}
