using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero = "";
        Candidato alguem;
        Candidato[] lista = new Candidato[4];
        int branco = 0, nulo = 0;
        
        private void insereCandidato()
        {
            alguem= new Candidato();
            alguem.Numero = 12;
            alguem.Nome = "John Constantine";
            alguem.Turma = "1º ADS";
            alguem.Foto = "john.jpg";
            lista[0] = alguem;

            alguem = new Candidato();
            alguem.Numero = 23;
            alguem.Nome = "Mona Lisa";
            alguem.Turma = "1º ADS";
            alguem.Foto = "mona.jpg";
            lista[1] = alguem;

            alguem = new Candidato();
            alguem.Numero = 34;
            alguem.Nome = "Leandro Hassum";
            alguem.Turma = "1º ADS";
            alguem.Foto = "leandro.jpg";
            lista[2] = alguem;

            alguem = new Candidato();
            alguem.Numero = 45;
            alguem.Nome = "Dora aventureira";
            alguem.Turma = "1º ADS";
            alguem.Foto = "dora.jpg";
            lista[3] = alguem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Enabled = false; // desabilita o campo de texto
            txtNum2.Enabled = false;
            btnConfirma.Enabled = false; // desbilita o botão Confirma
            lblMensagem.Visible = false; // Panel ocultada
            insereCandidato();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("5");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("3");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("1");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("4");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("8");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("0");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tecla();
            Preenche("9");
        }

        private void tecla()
        {
            SoundPlayer som = new SoundPlayer(@"C:\Users\Aluno\Desktop\musicas\tecla.wav");
            som.Play();
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            SoundPlayer som = new SoundPlayer(@"C:\Users\Aluno\Desktop\musicas\urna.wav");
            som.Play();
            int valido = 0;
            for (int i = 0; i < 4; i++)
            {
                if (numero == "Branco")
                {
                    branco++;
                    valido = 1;
                }
                else
                {
                    if (int.Parse(numero) == lista[i].Numero)
                    {
                        lista[i].Voto++;
                        valido = 1;
                    }
                }

            } 
           
                if (valido == 0)
                {
                    nulo++;
                }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tecla();
            numero = "Branco";
            lblMensagem.Visible = true;
            btnConfirma.Enabled = true;
            lblCandidato.Text = "VOTO EM BRANCO";
          

        }
        private void corrige()
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
            lblCandidato.Text = null;
            lblTurma.Text = null;
            lblMensagem.Visible = false;
            btnConfirma.Enabled = false;
            numero="";
            pxFoto.Image  = null;

        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            corrige();
        }

        private void Preenche(string n)
        {
            if (numero.Length == 0)
            {
                txtNum1.Text = n;
                numero += n; // numero=numero+n 
            }
            else
            {
              txtNum2.Text = n;
              numero += n; // numero=numero+n 
                for (int i = 0; i < 4; i++)
                {
                    if (int.Parse(numero) == lista[i].Numero)
                    {
                        lblCandidato.Text = lista[i].Nome;
                        lblTurma.Text = lista[i].Turma;
                        pxFoto.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\candidatos\" + lista[i].Foto);
                        i = 3;
                    }
                    else
                    {
                        lblCandidato.Text = "VOTO NULO";
                    }
                    lblMensagem.Visible = true;
                    btnConfirma.Enabled = true;
                }

            }

        }
    }
}
