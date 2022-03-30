using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracSiparisProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            switch (cmbMarka.Text)
            {
                case "VOLKSWAGEN":
                    cmbModel.Items.Add("JETTA");
                    cmbModel.Items.Add("PASSAT");
                    cmbModel.Items.Add("GOLF");
                    break;
                case "AUDI":
                    cmbModel.Items.Add("A7");
                    cmbModel.Items.Add("Q7");
                    cmbModel.Items.Add("R8");
                    break;
                case "RENAULT":
                    cmbModel.Items.Add("CLIO");
                    cmbModel.Items.Add("LAGUNA");
                    cmbModel.Items.Add("SYMBOL");
                    break;
                case "HYUNDAI":
                    cmbModel.Items.Add("ACCENT");
                    cmbModel.Items.Add("I 30");
                    cmbModel.Items.Add("IX 35");
                    break;
                case "HONDA":
                    cmbModel.Items.Add("CIVIC");
                    cmbModel.Items.Add("CITY");
                    cmbModel.Items.Add("CR-V");
                    break;
                case "BMW":
                    cmbModel.Items.Add("M6 COUPE");
                    cmbModel.Items.Add("X6");
                    cmbModel.Items.Add("5.25");
                    break;
                case "MERCEDES":
                    cmbModel.Items.Add("200 AMG");
                    cmbModel.Items.Add("E 250");
                    cmbModel.Items.Add("CLA 300");
                    break;
                default:
                    break;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;

            lvi.Text = cmbMarka.Text;
            lvi.SubItems.Add(cmbModel.Text);
            lvi.SubItems.Add(cmbYakitTipi.Text);
            lvi.SubItems.Add(cmbKasaTipi.Text);
            lvi.SubItems.Add(cmbVitesTipi.Text);
            lvi.SubItems.Add(cmbMotorTipi.Text);
            lvi.SubItems.Add(string.Empty);
            lvi.SubItems[6].BackColor = btnRenk.BackColor;
            lvi.SubItems.Add(dtpYil.Text);
            listView1.Items.Add(lvi);

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is Button)
                {
                    Button btn = (Button)item;
                    if (btn.Name == "btnRenk")
                    {
                        btn.BackColor = Color.Empty;
                    }
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        ListViewItem secili;
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kaydı seçiniz!");
                return;
            }

            secili = listView1.SelectedItems[0];
            cmbMarka.Text = secili.Text;
            cmbModel.Text = secili.SubItems[1].Text;
            cmbYakitTipi.Text = secili.SubItems[2].Text;
            cmbKasaTipi.Text = secili.SubItems[3].Text;
            cmbVitesTipi.Text = secili.SubItems[4].Text;
            cmbMotorTipi.Text = secili.SubItems[5].Text;
            btnRenk.BackColor = secili.SubItems[6].BackColor;
            dtpYil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secili.SubItems[7].Text));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secili.SubItems[0].Text = cmbMarka.Text;
            secili.SubItems[1].Text = cmbModel.Text;
            secili.SubItems[2].Text = cmbYakitTipi.Text;
            secili.SubItems[3].Text = cmbKasaTipi.Text;
            secili.SubItems[4].Text = cmbVitesTipi.Text;
            secili.SubItems[5].Text = cmbMotorTipi.Text;
            secili.SubItems[6].BackColor = btnRenk.BackColor;
            secili.SubItems[7].Text = dtpYil.Text;

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is Button)
                {
                    Button btn = (Button)item;
                    if (btn.Name == "btnRenk")
                    {
                        btn.BackColor = Color.Empty;
                    }
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kaydı seçiniz!");
                return;
            }

            secili = listView1.SelectedItems[0];
            cmbMarka.Text = secili.Text;
            cmbModel.Text = secili.SubItems[1].Text;
            cmbYakitTipi.Text = secili.SubItems[2].Text;
            cmbKasaTipi.Text = secili.SubItems[3].Text;
            cmbVitesTipi.Text = secili.SubItems[4].Text;
            cmbMotorTipi.Text = secili.SubItems[5].Text;
            btnRenk.BackColor = secili.SubItems[6].BackColor;
            dtpYil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secili.SubItems[7].Text));
        }
    }
}
