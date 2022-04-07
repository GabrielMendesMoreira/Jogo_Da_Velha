using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03_181828
{
    public partial class Form1 : Form
    {
        int rodadas = 1;
        int jogador1g = 0;
        int jogador2g = 0;
        int empat = 0;

        public Form1()
        {
            InitializeComponent();
        }




        #region Botoes
        private void bt13_Click(object sender, EventArgs e)
        {
            if (bt13.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt13.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt13.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
           
      
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            if (bt11.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt11.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt11.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            if (bt12.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt12.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt12.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            if (bt21.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt21.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt21.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt22_Click(object sender, EventArgs e)
        {
            if (bt22.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt22.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt22.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt23_Click(object sender, EventArgs e)
        {
            if (bt23.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt23.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt23.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt31_Click(object sender, EventArgs e)
        {
            if (bt31.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt31.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt31.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt32_Click(object sender, EventArgs e)
        {
            if (bt32.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt32.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt32.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }

        private void bt33_Click(object sender, EventArgs e)
        {
            if (bt33.Text == "")
            {
                if (rodadas == 1 || rodadas == 3 || rodadas == 5 || rodadas == 7 || rodadas == 9)
                {
                    bt33.Text = "X";
                    rodadas++;
                    jogadorvez.Text = "2";
                    verificar();
                }
                else
                {
                    bt33.Text = "O";
                    rodadas++;
                    jogadorvez.Text = "1";
                    verificar();
                }
            }
        }
        #endregion

        #region Reiniciar
        private void button1_Click(object sender, EventArgs e)
        {

                string pergunta = "Deseja reiniciar o jogo?";
                string sair = "REINICIAR O JOGO";
                MessageBoxButtons botao = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
                if (MessageBox.Show(pergunta, sair, botao, icon, Default) == DialogResult.Yes)
                {
                bt11.Text = "";
                bt12.Text = "";
                bt13.Text = "";
                bt21.Text = "";
                bt22.Text = "";
                bt23.Text = "";
                bt31.Text = "";
                bt32.Text = "";
                bt33.Text = "";
                JOGADOR1PLACAR.Text = "0";
                JOGADOR2PLACAR.Text = "0";
                empate.Text = "0";
                jogadorvez.Text = "1";
                rodadas = 1;
                empat = 0;
                jogador1g = 0;
                jogador2g = 0;


                 }
            }
        #endregion;

        #region Fechar
        private void Fechar_Click(object sender, EventArgs e)
        {
                string pergunta = "Deseja sair do programa?";
                string sair = "SAIR DO PROGRAMA";
                MessageBoxButtons botao = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
                if (MessageBox.Show(pergunta, sair, botao, icon, Default) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        #endregion

        #region Verificar
        public void verificar()
        {

            if (bt11.Text == bt12.Text && bt12.Text == bt13.Text)
            {
                if (bt11.Text == "X")
                {
                    MessageBox.Show("JOGADOR 1 GANHOU");
                    jogador1g++;
                    jogadorvez.Text = "1";
                    rodadas = 1;
                    JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                    JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                    empate.Text = Convert.ToString(empat);
                    bt11.Text = "";
                    bt12.Text = "";
                    bt13.Text = "";
                    bt21.Text = "";
                    bt22.Text = "";
                    bt23.Text = "";
                    bt31.Text = "";
                    bt32.Text = "";
                    bt33.Text = "";

                }
                if (bt11.Text == "O")
                {
                    MessageBox.Show("JOGADOR 2 GANHOU");
                    jogador2g++;
                    JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                    JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                    empate.Text = Convert.ToString(empat);
                    bt11.Text = "";
                    bt12.Text = "";
                    bt13.Text = "";
                    bt21.Text = "";
                    bt22.Text = "";
                    bt23.Text = "";
                    bt31.Text = "";
                    bt32.Text = "";
                    bt33.Text = "";
                    jogadorvez.Text = "1";
                    rodadas = 1;

                }
            }
                if (bt21.Text == bt22.Text && bt22.Text == bt23.Text)
                {
                    if (bt21.Text == "X")
                    {
                        MessageBox.Show("JOGADOR 1 GANHOU");
                        jogador1g++;
                        jogadorvez.Text = "1";
                        rodadas = 1;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";

                    }
                    if (bt21.Text == "O")
                    {
                        MessageBox.Show("JOGADOR 2 GANHOU");
                        jogador2g++;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";
                        jogadorvez.Text = "1";
                        rodadas = 1;

                    }
                }
            

                if (bt31.Text == bt32.Text && bt32.Text == bt33.Text)
                {
                    if (bt31.Text == "X")
                    {
                        MessageBox.Show("JOGADOR 1 GANHOU");
                        jogador1g++;
                        jogadorvez.Text = "1";
                        rodadas = 1;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";

                    }
                    if (bt31.Text == "O")
                    {
                        MessageBox.Show("JOGADOR 2 GANHOU");
                        jogador2g++;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";
                        jogadorvez.Text = "1";
                        rodadas = 1;

                    }
                }
            if (rodadas==10)
            {
                MessageBox.Show("EMPATE!");
                empat++;
                jogadorvez.Text = "1";
                rodadas = 1;
                JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                empate.Text = Convert.ToString(empat);
                bt11.Text = "";
                bt12.Text = "";
                bt13.Text = "";
                bt21.Text = "";
                bt22.Text = "";
                bt23.Text = "";
                bt31.Text = "";
                bt32.Text = "";
                bt33.Text = "";

            }

            if (bt21.Text == bt11.Text && bt11.Text == bt31.Text)
            {
                if (bt11.Text == "X")
                {
                    MessageBox.Show("JOGADOR 1 GANHOU");
                    jogador1g++;
                    jogadorvez.Text = "1";
                    rodadas = 1;
                    JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                    JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                    empate.Text = Convert.ToString(empat);
                    bt11.Text = "";
                    bt12.Text = "";
                    bt13.Text = "";
                    bt21.Text = "";
                    bt22.Text = "";
                    bt23.Text = "";
                    bt31.Text = "";
                    bt32.Text = "";
                    bt33.Text = "";

                }
                if (bt11.Text == "O")
                {
                    MessageBox.Show("JOGADOR 2 GANHOU");
                    jogador2g++;
                    JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                    JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                    empate.Text = Convert.ToString(empat);
                    bt11.Text = "";
                    bt12.Text = "";
                    bt13.Text = "";
                    bt21.Text = "";
                    bt22.Text = "";
                    bt23.Text = "";
                    bt31.Text = "";
                    bt32.Text = "";
                    bt33.Text = "";
                    jogadorvez.Text = "1";
                    rodadas = 1;

                }
            }

                if (bt12.Text == bt22.Text && bt12.Text == bt32.Text)
                {
                    if (bt12.Text == "X")
                    {
                        MessageBox.Show("JOGADOR 1 GANHOU");
                        jogador1g++;
                        jogadorvez.Text = "1";
                        rodadas = 1;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";

                    }
                    if (bt12.Text == "O")
                    {
                        MessageBox.Show("JOGADOR 2 GANHOU");
                        jogador2g++;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";
                        jogadorvez.Text = "1";
                        rodadas = 1;

                    }
                }

                if (bt13.Text == bt23.Text && bt23.Text == bt33.Text)
                {
                    if (bt13.Text == "X")
                    {
                        MessageBox.Show("JOGADOR 1 GANHOU");
                        jogador1g++;
                        jogadorvez.Text = "1";
                        rodadas = 1;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";

                    }
                    if (bt13.Text == "O")
                    {
                        MessageBox.Show("JOGADOR 2 GANHOU");
                        jogador2g++;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";
                        jogadorvez.Text = "1";
                        rodadas = 1;

                    }
                }

                if (bt11.Text == bt22.Text && bt22.Text == bt33.Text)
                {
                if (bt11.Text == "X")
                {
                    MessageBox.Show("JOGADOR 1 GANHOU");
                    jogador1g++;
                    jogadorvez.Text = "1";
                    rodadas = 1;
                    JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                    JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                    empate.Text = Convert.ToString(empat);
                    bt11.Text = "";
                    bt12.Text = "";
                    bt13.Text = "";
                    bt21.Text = "";
                    bt22.Text = "";
                    bt23.Text = "";
                    bt31.Text = "";
                    bt32.Text = "";
                    bt33.Text = "";
                
                    }
                    if (bt11.Text == "O")
                    {
                        MessageBox.Show("JOGADOR 2 GANHOU");
                        jogador2g++;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";
                        jogadorvez.Text = "1";
                        rodadas = 1;

                    }
                }

                if (bt31.Text == bt22.Text && bt22.Text == bt13.Text)
                {
                    if (bt13.Text == "X")
                    {
                        MessageBox.Show("JOGADOR 1 GANHOU");
                        jogador1g++;
                        jogadorvez.Text = "1";
                        rodadas = 1;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";

                    }
                    if (bt13.Text == "O")
                    {
                        MessageBox.Show("JOGADOR 2 GANHOU");
                        jogador2g++;
                        JOGADOR1PLACAR.Text = Convert.ToString(jogador1g);
                        JOGADOR2PLACAR.Text = Convert.ToString(jogador2g);
                        empate.Text = Convert.ToString(empat);
                        bt11.Text = "";
                        bt12.Text = "";
                        bt13.Text = "";
                        bt21.Text = "";
                        bt22.Text = "";
                        bt23.Text = "";
                        bt31.Text = "";
                        bt32.Text = "";
                        bt33.Text = "";
                        jogadorvez.Text = "1";
                        rodadas = 1;

                    }
                }
            }
        

        #endregion

        #region Lixo

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void JOGADOR1PLACAR_Click(object sender, EventArgs e)
        {

        }

        private void empate_Click(object sender, EventArgs e)
        {

        }

        private void jogadorvez_Click(object sender, EventArgs e)
        {

        }

        #endregion
 
    }
}
  



