using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro.Produto_3B
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.precoAq = Convert.ToDouble(tx_precoAq.Text);
            p.lucro = Convert.ToDouble(tx_lucro.Text);
            p.codigo = tx_codigo.Text;
            p.descricao = tx_descricao.Text;
            lb_valorVenda.Text = Convert.ToString (p.ValorLucro(p.precoAq, p.lucro));
            produtos.Add(p);
            dataGridView1.DataSource = produtos;
            /*
            foreach (Produto pa in produtos)
            {
                MessageBox.Show(pa.descricao+" "+pa.codigo);
            }
            */

        }
    }
}
