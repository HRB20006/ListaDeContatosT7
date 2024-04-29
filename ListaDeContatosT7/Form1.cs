using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] contatos = new Contato[1];
        
        private void Escrever(Contato contato)
        {
            StreamWriter streamWriter = new StreamWriter("contatos.txt");
            streamWriter.WriteLine(contatos.Length + 1);
            streamWriter.WriteLine(contato.Nome);
            streamWriter.WriteLine(contato.Sobrenome);
            streamWriter.WriteLine(contato.Telefone);

            for (int h = 0; h < contatos.Length; h++)
            {
                streamWriter.WriteLine(contatos[h].Nome);
                streamWriter.WriteLine(contatos[h].Sobrenome);
                streamWriter.WriteLine(contatos[h].Telefone);
            }
            streamWriter.Close();
        }

        private void Ler()
        {
            StreamReader streamReader = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(streamReader.ReadLine())];

            for (int h = 0;h < contatos.Length;h++)
            {
                contatos[h] = new Contato();
                contatos[h].Nome = streamReader.ReadLine();
                contatos[h].Sobrenome = streamReader.ReadLine();
                contatos[h].Telefone = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        private void Exibir()
        {
           listBoxContatos.Items.Clear();
            for (int h = 0; h < contatos.Length; h++)
            {
                listBoxContatos.Items.Add(contatos[h].ToString());
            } 
        }

        private void LimparFormulário()
        {
            textBoxNome.Text = String.Empty;
            textBoxSobre.Text = String.Empty;
            textBoxTel.Text = String.Empty;    
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobre.Text;
            contato.Telefone = textBoxTel.Text;
            
            //listBoxContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Exibir();
            LimparFormulário();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }
    }
}
