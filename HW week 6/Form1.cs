using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_week_6
{
    public partial class Form1 : Form
    {
        DataTable tabelKiri = new DataTable();
        DataTable tabelKanan = new DataTable();
        DataTable hasilFilter = new DataTable();
        string inputProduct = "";
        int check = 0;
        int check2;
        string IDProduct;
        bool cekCat = false;
        int tabelCategory = 5;
        string remCat;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FILTER_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = true;
        }

        private void btn_ALL_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = false;
            dgv_Product.DataSource = tabelKiri;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabelKiri.Columns.Add("ID Product");
            tabelKiri.Columns.Add("Nama Product");
            tabelKiri.Columns.Add("Harga");
            tabelKiri.Columns.Add("Stock");
            tabelKiri.Columns.Add("ID Category");
            tabelKiri.Rows.Add("J001", "Jas Maroon", "500000", "15", "C1");
            tabelKiri.Rows.Add("S001", "Sepatu Heels", "200000", "10", "C2");
            tabelKiri.Rows.Add("S002", "Sepatu Booth", "600000", "15", "C2");
            tabelKiri.Rows.Add("K001", "Kaos Polos", "150000", "20", "C3");
            tabelKiri.Rows.Add("K002", "Kaos Berkera", "250000", "10", "C3");
            tabelKiri.Rows.Add("J002", "Jeans Hitam", "200000", "20", "C4");
            tabelKiri.Rows.Add("J003", "Jaket Kulit", "500000", "30", "C5");
            tabelKiri.Rows.Add("J004", "Jaket Jeans", "400000", "30", "C5");
            dgv_Product.DataSource = tabelKiri;
            tabelKanan.Columns.Add("ID Category");
            tabelKanan.Columns.Add("Nama Category");
            tabelKanan.Rows.Add("C1", "Jas");
            tabelKanan.Rows.Add("C2", "Sepatu");
            tabelKanan.Rows.Add("C3", "Kaos");
            tabelKanan.Rows.Add("C4", "Jeans");
            tabelKanan.Rows.Add("C5", "Jaket");
            dgv_Category.DataSource = tabelKanan;
            hasilFilter = tabelKiri.Copy();
        }

        private void comboBox_Filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hasilFilter.Rows.Clear();
            foreach (DataRow filter in tabelKanan.Rows)
            {
                if (comboBox_Filter.SelectedItem.ToString() == filter[1].ToString())
                {
                    foreach(DataRow pilihan in tabelKiri.Rows)
                    {
                        if (filter[0] == pilihan[4])
                        {
                            hasilFilter.Rows.Add(pilihan[0], pilihan[1], pilihan[2], pilihan[3], pilihan[4]);
                        }
                    }
                }
            }
            dgv_Product.DataSource = hasilFilter;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (txtBox_DetNama.Text == "" && txtBox_Harga.Text == "" && txtBox_Stock.Text == "" && comboBox_Category.Text == "")
            {
                MessageBox.Show("Please input the text box !");
            }
            else
            {
                foreach (DataRow cek in tabelKanan.Rows)
                {
                    if (comboBox_Category.Text == cek[1].ToString())
                    {
                        inputProduct = cek[0].ToString();
                    }
                }
                foreach (DataRow cek1 in tabelKiri.Rows)
                {
                    if (txtBox_DetNama.Text[0].ToString().ToUpper() == cek1[0].ToString()[0].ToString())
                    {
                        check = Convert.ToInt32(cek1[0].ToString().Substring(1));
                        if (check>=check2)
                        {
                            check2 = check;
                        }
                    }
                }
                check2 += 1;
                IDProduct = txtBox_DetNama.Text[0].ToString().ToUpper();
                for (int i = check2.ToString().Length;i < 3;i++)
                {
                    IDProduct += "0";
                }
                IDProduct += Convert.ToString(check2);
                tabelKiri.Rows.Add(IDProduct, txtBox_DetNama.Text, txtBox_Harga.Text, txtBox_Stock.Text, inputProduct);
            }
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_DetNama.Text = dgv_Product.SelectedCells[1].Value.ToString();
            txtBox_Harga.Text = dgv_Product.SelectedCells[2].Value.ToString();
            txtBox_Stock.Text = dgv_Product.SelectedCells[3].Value.ToString();
            foreach (DataRow cek in tabelKanan.Rows)
            {
                if (dgv_Product.SelectedCells[4].Value.ToString() == cek[0].ToString())
                {
                    comboBox_Category.Text = cek[1].ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBox_Stock.Text == "0")
            {
                tabelKiri.Rows.RemoveAt(dgv_Product.SelectedRows[0].Index);
            }
            else
            {
                tabelKiri.Rows[dgv_Product.SelectedRows[0].Index][1] = txtBox_DetNama.Text;
                tabelKiri.Rows[dgv_Product.SelectedRows[0].Index][2] = txtBox_Harga.Text;
                tabelKiri.Rows[dgv_Product.SelectedRows[0].Index][3] = txtBox_Stock.Text;
                foreach (DataRow cek1 in tabelKiri.Rows)
                {
                    if (txtBox_DetNama.Text[0].ToString().ToUpper() == cek1[0].ToString()[0].ToString())
                    {
                        check = Convert.ToInt32(cek1[0].ToString().Substring(1));
                        if (check >= check2)
                        {
                            check2 = check;
                        }
                    }
                }
                check2 += 1;
                IDProduct = txtBox_DetNama.Text[0].ToString().ToUpper();
                for (int i = check2.ToString().Length; i < 3; i++)
                {
                    IDProduct += "0";
                }
                IDProduct += Convert.ToString(check2);
                tabelKiri.Rows[dgv_Product.SelectedRows[0].Index][0] = IDProduct;
                foreach (DataRow cek in tabelKanan.Rows)
                {
                    if (comboBox_Category.Text == cek[1].ToString())
                    {
                        tabelKiri.Rows[dgv_Product.SelectedRows[0].Index][4] = cek[0].ToString();
                        break;
                    }
                }
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            foreach(DataRow cek in tabelKiri.Rows)
            {
                if (dgv_Product.SelectedCells[1].Value.ToString() == cek[1].ToString())
                {
                    tabelKiri.Rows.Remove(cek);
                    break;
                }
            }
        }

        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            if (txtBox_CatNama.Text == "")
            {
                MessageBox.Show("Please INPUT !");
            }
            else
            {
                foreach (DataRow cek in tabelKanan.Rows)
                {
                    if (cek[1].ToString() == txtBox_CatNama.Text)
                    {
                        cekCat = true;
                    }
                }
                if (cekCat == true)
                {
                    MessageBox.Show("Can't same input");
                }
                else
                {
                    tabelCategory++;
                    tabelKanan.Rows.Add(("C" + tabelCategory), txtBox_CatNama.Text);
                    comboBox_Filter.Items.Add(txtBox_CatNama.Text);
                    comboBox_Category.Items.Add(txtBox_CatNama.Text);

                }
            }
        }

        private void btn_RemoveCat_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Items.Remove(dgv_Category.SelectedCells[1].Value.ToString());
            comboBox_Category.Items.Remove(dgv_Category.SelectedCells[1].Value.ToString());
            remCat = dgv_Category.SelectedCells[0].Value.ToString();
            foreach (DataRow cek in tabelKanan.Rows)
            {
                if (cek[1].ToString() == dgv_Category.SelectedCells[1].Value.ToString())
                {
                    tabelKanan.Rows.Remove(cek);
                    break;
                }
            }
            for (int i = tabelKiri.Rows.Count-1; i >= 0; i--)
            {
                if (remCat == tabelKiri.Rows[i][4].ToString())
                {
                    tabelKiri.Rows.RemoveAt(i);
                }
            }
        }
    }
}
