using System;
using System.Windows.Forms;
using TCC_GestaoFinanceira.Mapeador;

namespace TCC_GestaoFinanceira
{
    public partial class Form1 : Form
    {
        readonly daoFireBird Conexao = new daoFireBird();
        TratamentoDeCampos _MascaraDinheiro = new TratamentoDeCampos();

        public Form1()
        {
            InitializeComponent();
            AplicarMascara(txtInsiraSalarioBruto);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        public void AplicarMascara(TextBox txt)
        {
            txt.KeyPress += _MascaraDinheiro.ApenasValorNumerico;
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = Conexao.acessoFBSingleton();
        }
    }
}
