using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS5
{
    public partial class FrmSistema : Form
    {
        #region Declaração de Variaveis
        string texto = "Deseja sair do sistema?";
        string Titulo = "<<<<FINALIZANDO>>>>";
        MessageBoxButtons botao = MessageBoxButtons.YesNo;
        MessageBoxIcon icone = MessageBoxIcon.Question;
        object resposta;
        #endregion

        public FrmSistema()
        {
            InitializeComponent();
        }

        public void Sair()
        {
            this.resposta = MessageBox.Show(this.texto,
                                            this.Titulo,
                                            this.botao,
                                            this.icone);
            if (resposta.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            stpData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            stpHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            process1.Start();
        }

        private void microsoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";
            process1.Start();
        }

        private void microsoftPowerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE";
            process1.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Windows\System32\calc.exe";
            process1.Start();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void verificarNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_Exemplo0122.FrmExemplo01 vn = new Win_Exemplo0122.FrmExemplo01();
            vn.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win_EX290822.Form1 PB = new Win_EX290822.Form1();
            PB.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATV2_0509.Form1 LB = new ATV2_0509.Form1();
            LB.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATV3_0509.Form1 Tm = new ATV3_0509.Form1();
            Tm.ShowDialog();
        }

        private void dateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATV4_0509.Form1 Dt = new ATV4_0509.Form1();
            Dt.ShowDialog();
        }
    }
}
