using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ADDED REFERENCE LIBRARIES
using System.Net.Sockets;          //Network communication sockets for TCP/IP
//using System.Text;                 //Receive and send InfoBytes. Dats bytes
using System.Net.NetworkInformation;
//using System;
using System.IO;
using System.Net;
using System.Drawing.Imaging;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        //G:OBALES

        TcpClient TCPCliente;
        int iPuerto = 9999;
        string fileSelected = "";
        private const int BufferSize = 1024;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            IPAddress address;
            string sIP = "";
            
            if (TxtIPServer.Text == "")
            {
                sIP = "10.0.0.2";
                TxtIPServer.Text = sIP;

            } else if (IPAddress.TryParse(TxtIPServer.Text, out address))
            {
                sIP = address.ToString();
            } else
            {
                sIP = "10.0.0.2";
                TxtIPServer.Text = sIP;
            }

            if (TxtPuerto.Text == "" || !Int32.TryParse(TxtPuerto.Text, out iPuerto))
            {
                iPuerto = 1220;
            }

            if (iPuerto >= 65535 && iPuerto <= 1024)
            {
                iPuerto = 1220;
            }

            try
            {
                //Conectar al Servior
                TCPCliente = new TcpClient(sIP, iPuerto);
               //TCPCliente.Connect(sIP, iPuerto); //connect to server

                //
                if (TCPCliente.Connected)
                {
                    LblEstado.Text = "Conectado";
                }
            }
            catch(Exception error){
                Console.WriteLine("Error => " + error.ToString());
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("No se pudo conectar al servidor, intentelo màs tarde.", "Error de Conexiòn",buttons);
            }
        }

        public String VerSiHayMensajes()
        {
            String Mensaje = "";
            try {
                System.Net.Sockets.NetworkStream stream = TCPCliente.GetStream();

                //Data reciving mechanism
                //Corrigue este metodo para que siempre este en escuchar y cuando llegue un mensaje lo puedas ver inmediatamente.
                if (stream.CanRead) //Preguntamos si es posible leer
                {
                    if (stream.DataAvailable) //Preguntamos si hay algo por leer
                    {
                        Byte[] data = new Byte[TCPCliente.ReceiveBufferSize];       //Buffer del tamaño de lo que se recibio
                        string responseData = "";  //String to store the response ASCII representation

                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                        //concatenamos los bytes en la variable mensaje para armar el mensaje
                        Mensaje += "Received " + responseData;
                    }
                }
            }
            catch (Exception ex){
                //ex nunca se usa.. contiene el errorde que no hay mensajes de clientes ya que no se eonctraron clientes.
                //no hay clientes conectados al servidor, asi que no hacemos nada.
            }
            //regresamos el mensaje que se construyo anteriormente
            return Mensaje;


        }

        private void BtnRecibir_Click(object sender, EventArgs e)
        {
            System.Net.Sockets.NetworkStream stream = TCPCliente.GetStream();

            //Data reciving mechanism
			//Corrigue este metodo para que siempre este en escuchar y cuando llegue un mensaje lo puedas ver inmediatamente.
            if (stream.CanRead) //Preguntamos si es posible leer
            {
                if (stream.DataAvailable) //Preguntamos si hay algo por leer
                {
                    Byte[] data = new Byte[TCPCliente.ReceiveBufferSize];       //Buffer del tamaño de lo que se recibio
                    string responseData = "";  //String to store the response ASCII representation

                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    textBox2.Text += "Received " + responseData;
                }
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            

            if (txtsend.Text.Trim() != "")
            {
                try
                {
                    // Data sending mechanism
                    //local constructor
                    System.Net.Sockets.NetworkStream InfoBytes;
                    InfoBytes = TCPCliente.GetStream();
                    Byte[] TempOutStringData; // = new Byte();
                    TempOutStringData = System.Text.Encoding.ASCII.GetBytes(txtsend.Text + "\r\n");
                    InfoBytes.Write(TempOutStringData, 0, TempOutStringData.Length);
                    //Borra el contenido de textbox
                    txtsend.Text = "";
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error => " + error.ToString());
                }
            }  


            //enviar imagen
            try
            {
                byte[] SendingBuffer = null;
                System.Net.Sockets.NetworkStream netstream;
                netstream = TCPCliente.GetStream();
                FileStream Fs = new FileStream(fileSelected, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32
             (Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                for (int i = 0; i < NoOfPackets; i++)
                {

                    CurrentPacketLength = TotalLength;
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);

                }
                Fs.Close();
                netstream.Flush();
                pictureBox1.Image = null;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        
        }

        //manda esta variable como cualquier texto
        string base64 = null;
        private void sendImg_Click(object sender, EventArgs e)
        {
            //char[] delimiter = image_splitter.ToCharArray();
            var fileContent = string.Empty;
            var filePath = string.Empty;
            //Abre un cuadro de dialogo para seleccionar una imagen
            using (OpenFileDialog openFile = new OpenFileDialog()) {
                openFile.InitialDirectory = "../Imágen";
                openFile.Filter = "images Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                openFile.FilterIndex = 2;
                openFile.RestoreDirectory = true;

                if (openFile.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    filePath = openFile.FileName;

                    
                    using (Bitmap bmp = new Bitmap(openFile.FileName))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, ImageFormat.Jpeg);
                            base64 = Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
               //esto ira en el server
                using (MemoryStream mss = new MemoryStream(Convert.FromBase64String(base64)))
                {
                    pictureBox1.Image = Image.FromStream(mss);
                    pictureBox1.SizeMode= PictureBoxSizeMode.StretchImage;
                }
                MessageBox.Show(base64);
                
            }

            
        }

        private void timerBuscarMensajes_Tick(object sender, EventArgs e)
        {
            //llamamos a la funcion VerSiHayMensajes que nos retorna una cadena con el ultimo mensaje enviado por el servidor
            //
            String mensaje = VerSiHayMensajes();
            //obtenermos el texto actual que tenemos en los mensajes recibidos por el servidor
            String textoActual = textBox2.Text;
            //si hay mensaje recibido por el servidor
            if (mensaje.Trim() != "")
            {
                //y si NO es la primer vez que el servidor nos envia mensaje
                if (textoActual != "") {
                    //agregamos un salto de linea para mostrar el nuevo mensaje recibido en linea nueva
                    textBox2.AppendText(Environment.NewLine);
                }
                //escribimos en la nueva linea el mensaje recibido
                textBox2.AppendText(mensaje.Trim());
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)

                return;

            System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog1.FileName);

            string strFileName = fInfo.Name;

            string strFilePath = fInfo.DirectoryName;

            fileSelected = strFilePath + "\\" + strFileName;
            string ext = Path.GetExtension(fileSelected);

            byte[] send = File.ReadAllBytes(fileSelected);
            switch (ext) { 
                case ".jpg":
                        System.Drawing.Image img =
              System.Drawing.Image.FromFile(fileSelected, true);
                        pictureBox1.Image = img;
                break;
                case ".png":
                    System.Drawing.Image png =
          System.Drawing.Image.FromFile(fileSelected, true);
                    pictureBox1.Image = png;
                    break;
                case ".pdf":
                    pictureBox1.Image = TCPClient.Properties.Resources.pdfIcon.ToBitmap();
                    break;
            }

        }

      
    }
}