using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComBox2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedIndex))
            {
                case 1:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Janeiro";
                    break;
                case 2:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Fevereiro";
                    break;
                case 3:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + ", você nasceu em Março";
                    break;
                case 4:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "< você nasceu em Abril";
                    break;
                case 5:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Maio";
                    break;

                case 6:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Junho";
                    break;

                case 7:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Julho";
                    break;

                case 8:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Agosto";
                    break;

                case 9:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Setembro";
                    break;

                case 10:
                    lblMensagem.Text = "olá " + textBoxNome.Text + " você Nasceu em Outubro";
                    break;

                case 11:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Novembro ";
                    break;

                case 12:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Dezembro";
                    break;

                default:
                    lblMensagem.Text = "Por favor escolha uma opção de números; MÊS NÃO encontrado";
                    break;
            }
        }
        }
    }
}
