using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SistemaLanHouse
{
    public partial class SistemaForm : Form
    {
        public SistemaForm()
        {
            InitializeComponent();
            bGWorkerHoraAtual.RunWorkerAsync();
            bGWorkerHoraMaquina1.RunWorkerAsync();
        }
        
        private void SistemaForm_Load(object sender, EventArgs e)
        {
           
           
        }

        private void PaintButton_Click(object sender, EventArgs e)
        {
            string AbrirPaint = string.Empty;
            AbrirPaint = "mspaint.exe";
            System.Diagnostics.Process.Start(AbrirPaint);
            return;
        }
        
        private void ListaTarefasTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }


 

        private void CalculadoraButton_Click(object sender, EventArgs e)
        {
            string AbrirCalculadora = string.Empty;
            AbrirCalculadora = "calc.exe";
            System.Diagnostics.Process.Start(AbrirCalculadora);
            return;
            

        }

        private void TaskBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                    while (!bGWorkerHoraAtual.CancellationPending) {
                    bGWorkerHoraAtual.ReportProgress(0,DateTime.Now.ToString("HH:mm:ss"));
                    Thread.Sleep(1000);
                }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            taskBarHoraAtualLabel.Text = e.UserState.ToString();
        }

        private void BackgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (!bGWorkerHoraMaquina1.CancellationPending)
            {
             //   bGWorkerHoraMaquina1.ReportProgress(0, tempoRestanteMaquina4Label.Text= ;);
                Thread.Sleep(5000);
                
            }
        }

        private void BGWorkerHoraMaquina1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tempoRestanteMaquina4Label.Text = e.UserState.ToString();
        }
        

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string AbrirBlocoDeNotas = string.Empty;
            AbrirBlocoDeNotas = "notepad.exe";
            System.Diagnostics.Process.Start(AbrirBlocoDeNotas);
            return;
        }



        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TempoInicialMaquina1NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void TempoFinalMaquina1NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TempoFinalMaquina1NumericUpDown_Click(object sender, EventArgs e)
        {
           
        }
        private void TempoInicialMaquina2NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void TempoFinalMaquina2NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }


        private void TempoInicialMaquina1DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TempoFinalMaquina1DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void AdicionarProgramaButton_Click(object sender, EventArgs e)
        {

        }

        private void ControleEstoqueButton_Click(object sender, EventArgs e)
        {

        }

        public void TempoRestanteMaquina1Label_Click(object sender, EventArgs e) {
            //This

            // Define two times.
            DateTime Time1 = TempoInicialMaquina1NumericUpDown.Value;
            DateTime Time2 = TempoFinalMaquina1NumericUpDown.Value;


            // Calculate the interval between the two times.
            TimeSpan Interval = Time1 - Time2;
            //int Interval = DateTime.Compare(Time2, Time1);
            //Console.WriteLine("{0} - {1} = {2}", Time2, Time1, interval.ToString());

            // Exibindo o resultado da hora
            tempoRestanteMaquina1Label.Text = Convert.ToString(Interval);
            return;

        }

        private void TempoRestanteMaquina2Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM2 = tempoInicialMaquina2DateTimePicker.Value;
            DateTime HoraFinalM2 = tempoInicialMaquina2DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM2Hora = tempoInicialMaquina2DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM2Minuto = tempoInicialMaquina2DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM2Hora = tempoFinalMaquina2DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM2Minuto = tempoFinalMaquina2DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM2Hora = Convert.ToString(HoraInicialM2Hora - HoraFinalM2Hora);
            String tempoRestanteM2Minuto = Convert.ToString(HoraInicialM2Minuto - HoraFinalM2Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora
            tempoRestanteMaquina2Label.Text = (tempoRestanteM2Hora + ":" + tempoRestanteM2Minuto);
        }

        private void TempoRestanteMaquina3Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM3 = tempoInicialMaquina3DateTimePicker.Value;
            DateTime HoraFinalM3 = tempoInicialMaquina3DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM3Hora = tempoInicialMaquina3DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM3Minuto = tempoInicialMaquina3DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM3Hora = tempoFinalMaquina3DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM3Minuto = tempoFinalMaquina3DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM3Hora = Convert.ToString(HoraInicialM3Hora - HoraFinalM3Hora);
            String tempoRestanteM3Minuto = Convert.ToString(HoraInicialM3Minuto - HoraFinalM3Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora
            tempoRestanteMaquina3Label.Text = (tempoRestanteM3Hora + ":" + tempoRestanteM3Minuto);
        }

        
        public void TempoRestanteMaquina4Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM4 = tempoInicialMaquina4DateTimePicker.Value;
            DateTime HoraFinalM4 = tempoInicialMaquina4DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM4Hora = tempoInicialMaquina4DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM4Minuto = tempoInicialMaquina4DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM4Hora = tempoFinalMaquina4DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM4Minuto = tempoFinalMaquina4DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM4Hora = Convert.ToString(HoraInicialM4Hora - HoraFinalM4Hora);
            String tempoRestanteM4Minuto = Convert.ToString(HoraInicialM4Minuto - HoraFinalM4Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora

            var terminado = (tempoRestanteM4Hora + ":" + tempoRestanteM4Minuto);
            tempoRestanteMaquina4Label.Text = terminado;
        }

        private void TempoRestanteMaquina5Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM5 = tempoInicialMaquina5DateTimePicker.Value;
            DateTime HoraFinalM5 = tempoInicialMaquina5DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM5Hora = tempoInicialMaquina5DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM5Minuto = tempoInicialMaquina5DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM5Hora = tempoFinalMaquina5DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM5Minuto = tempoFinalMaquina5DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM5Hora = Convert.ToString(HoraInicialM5Hora - HoraFinalM5Hora);
            String tempoRestanteM5Minuto = Convert.ToString(HoraFinalM5Minuto - HoraFinalM5Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora
            tempoRestanteMaquina5Label.Text = (tempoRestanteM5Hora + ":" + tempoRestanteM5Minuto);
        }

        private void TempoRestanteMaquina6Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM6 = tempoInicialMaquina6DateTimePicker.Value;
            DateTime HoraFinalM6 = tempoInicialMaquina6DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM6Hora = tempoInicialMaquina6DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM6Minuto = tempoInicialMaquina6DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM6Hora = tempoFinalMaquina6DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM6Minuto = tempoFinalMaquina6DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM6Hora = Convert.ToString(HoraInicialM6Hora - HoraFinalM6Hora);
            String tempoRestanteM6Minuto = Convert.ToString(HoraInicialM6Minuto - HoraFinalM6Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora
            tempoRestanteMaquina6Label.Text = (tempoRestanteM6Hora + ":" + tempoRestanteM6Minuto);
        }

        private void TempoRestanteMaquina7Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM7 = tempoInicialMaquina7DateTimePicker.Value;
            DateTime HoraFinalM7 = tempoInicialMaquina7DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM7Hora = tempoInicialMaquina7DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM7Minuto = tempoInicialMaquina7DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM7Hora = tempoFinalMaquina7DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM7Minuto = tempoFinalMaquina7DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM7Hora = Convert.ToString(HoraInicialM7Hora - HoraFinalM7Hora);
            String tempoRestanteM7Minuto = Convert.ToString(HoraInicialM7Minuto - HoraFinalM7Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora
            tempoRestanteMaquina7Label.Text = (tempoRestanteM7Hora + ":" + tempoRestanteM7Minuto);
        }

        private void TempoRestanteMaquina8Label_Click(object sender, EventArgs e)
        {
            // Recebendo dados da DateTime
            DateTime HoraInicialM8 = tempoInicialMaquina8DateTimePicker.Value;
            DateTime HoraFinalM8 = tempoInicialMaquina8DateTimePicker.Value;

            // Convertendo DateTima para Double - Hora Inicial
            double HoraInicialM8Hora = tempoInicialMaquina8DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraInicialM8Minuto = tempoInicialMaquina8DateTimePicker.Value.AddMinutes(00).Minute;

            // Convertendo DateTima para Double - Hora Final
            double HoraFinalM8Hora = tempoFinalMaquina8DateTimePicker.Value.AddMinutes(00).Hour;
            double HoraFinalM8Minuto = tempoFinalMaquina8DateTimePicker.Value.AddMinutes(00).Minute;

            // Fazendo Cálculo do tempo restante
            String tempoRestanteM8Hora = Convert.ToString(HoraInicialM8Hora - HoraFinalM8Hora);
            String tempoRestanteM8Minuto = Convert.ToString(HoraInicialM8Minuto - HoraFinalM8Minuto);

            /*string FormatFName = String.Format("{0:D}", tempoRestanteM2Hora);
            string FormatFName2 = String.Format("{0:N}", tempoRestanteM2Minuto);*/

            // Exibindo o resultado da hora
            tempoRestanteMaquina8Label.Text = (tempoRestanteM8Hora + ":" + tempoRestanteM8Minuto);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
                        
        }

        private void machineManagerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void machineManagerGroupBox_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

