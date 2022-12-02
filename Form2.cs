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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.autoDataSet.Заказы);

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.заказыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);
        }
    }
}
