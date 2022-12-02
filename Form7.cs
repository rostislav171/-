using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

       

        private void покупкиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.autoDataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn5;
                    break;

            }
            if (radioButton1.Checked)
            {
                заказыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                заказыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = string.Format(" [Дата] = '{0:dd.MM.yyyy}'", dateTimePicker1.Value.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < заказыDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < заказыDataGridView.RowCount - 1; j++)
                {
                    заказыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    заказыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < заказыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < заказыDataGridView.RowCount; j++)
                {
                    var value = заказыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            заказыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            заказыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
