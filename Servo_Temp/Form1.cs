using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servo_Temp
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);

        public SerialPort ArduinoPort { get; }

        public Form1()
        {
            InitializeComponent();
            btndesconectar.Enabled = false;
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.btnConectar.Click += btnConectar_Click;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la temperatura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbTemp.Text = dato;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();

                if (int.TryParse(tbLimTemp.Text, out int temperaturaLimit))
                {
                    string limitString = temperaturaLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingresa un valor numérico válido en el textbox del límite de temperatura");
                }
                lbConection.Text = "Conexion OK";
                lbConection.ForeColor = System.Drawing.Color.Lime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. " + ex.Message);
            }

            btndesconectar.Enabled = true;
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = true;
            btndesconectar.Enabled = false;

            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();

            lbConection.Text = "Desconectado";
            lbConection.ForeColor = System.Drawing.Color.Red;
        }
    }
}
