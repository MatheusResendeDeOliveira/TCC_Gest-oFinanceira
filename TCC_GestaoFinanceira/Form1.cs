using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_GestaoFinanceira
{
    public partial class Form1 : Form
    {
        TratamentoDeCampos _MascaraDinheiro = new TratamentoDeCampos();

        public Form1()
        {
            InitializeComponent();
            AplicarMascara(txtInsiraSalarioBruto);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AplicarMascara(TextBox txt)
        {
            txt.KeyPress += _MascaraDinheiro.ApenasValorNumerico;
        }

        

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
    }
}
