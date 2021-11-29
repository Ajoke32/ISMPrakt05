using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrayOperation;
namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRand_Click(object sender, EventArgs e)
        {
            int arrLength = Convert.ToInt32(numericUpDownCoubt.Value);
            int[] arr = ArrayOp.Fix(arrLength);
            dataGridViewArr.ColumnCount = arrLength;
            dataGridViewArr.RowCount = 1;
            for (int i=0;i<arr.Length;i++)
            {
                dataGridViewArr.Columns[i].HeaderText = i.ToString();
               dataGridViewArr[i, 0].Value = arr[i];

            }
            if (Convert.ToInt32(numericUpDownCoubt.Text) == 0)
            {
                MessageBox.Show("Не корректно введено данні,заначення повинно бути >0", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelsum.Text = ArrayOp.SumNeg(arr).ToString();
                labelRes.Visible = true;
                labelsum.Visible = true;
                labelresult.Text = ArrayOp.PairedMax(arr).ToString();
                if (ArrayOp.PairedMax(arr) == -500)
                {
                    labelresult.Text = "Парнi числа вiдсутнi";
                }
                labelresult.Visible = true;
                labelMx.Visible = true;
                labelpairind.Text = ArrayOp.DobParied(arr).ToString();
                labelpairind.Visible = true;
                labelind.Visible = true;
                labelmaxid.Text = ArrayOp.IndxeMaxvalue(arr).ToString();
                labelmaxid.Visible = true;
                labelmaxindres.Visible = true;
                labelindsum.Text = ArrayOp.SumIndexPositive(arr).ToString();
                labelindsum.Visible = true;
                labelindres.Visible = true;
                labelmodulmax.Text = ArrayOp.MaxModElement(arr).ToString();
                labelmodulmax.Visible = true;
                labelmodulres.Visible = true;
                labelcount.Text = ArrayOp.numderNoPaired(arr).ToString();
                labelcount.Visible = true;
                labelcountres.Visible = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewArr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelsum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void labelmaxpair_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelresult_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelRes_Click(object sender, EventArgs e)
        {

        }
    }
}
