using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO.Ports;
using System.Drawing.Imaging;

namespace lidar
{
    public partial class Form1 : Form

    {
        System.IO.Ports.SerialPort com;
        Bitmap bitmap;
        RoomVisualize visualization = new RoomVisualize();
        Boolean portStatus = false;
        float degree = 0;
        float distance = 0;
        Boolean isClcked = false;
        Boolean isStartScan = false;
        static int callAmount = 0;
        Boolean calculatSurface = false;





        public Form1()
        {
            InitializeComponent();

            board.Height = 400;
            board.Width = 600;
            bitmap = new Bitmap(board.Width, board.Height);
            Graphics.FromImage(bitmap).Clear(Color.FromArgb(41, 44, 51));
            com = new System.IO.Ports.SerialPort();
            com.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            com.DtrEnable = true;    // Data-terminal-ready
            com.RtsEnable = true;

        }


        private void parser(String data)
        {

            var list = data.Split('i');
            if (list.Length == 3)
            {
                int i = int.Parse(list[1]);
                list[0] = list[0].Replace('.', ',');
                float f = float.Parse(list[0]);
                distance = f;
                degree = i;

            }

        }

        protected float calculateAngle()
        {
            return  degree * 360.0f / 800.0f;
        }


        private void connectoToComPort_Click(object sender, EventArgs e)
        {
            try
            {

                    if (!com.IsOpen)
                    {
                        com.BaudRate = 9600;
                        string[] ports = SerialPort.GetPortNames();
                        foreach (string portCom in ports)
                            com.PortName = portCom;
                        com.Open();
                    }

                    System.Threading.Thread.Sleep(3000);
                    if (sendMesssage(4, 8, 16))
                    {
                        connection.Text = "Connection complete. Port is ready to be used.";
                        portStatus = true;
                        //port.createConnetion( "0", 4, 8, 8);
                        isClcked = true;
                        diodstate.BackColor = Color.FromArgb(127, 127, 0);
                    }
                    else
                    {
                        connection.Text = "Not connected. Try once again ";
                        portStatus = false;

                    }
            }
            catch 
            {
                connection.Text = "There was no avaiable port. ";
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if(com.IsOpen)
            {
                sendMesssage(4, 8, 8); //false
                com.Close();
                connection.Text = " Connection close.";
                diodstate.BackColor = Color.Red;
                ClearImage();
                board.Refresh();
                visualization.DeleteValues();
                isClcked = false;
                isStartScan = false;
                calculatSurface = false;
                callAmount = 0;
                panel1.Visible = false;
                return;
            }
               // connection.Text = " There was a problem with close connetion with port COM.";
        }

        public void ClearImage()
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.FromArgb(41, 44, 51));
        }

        private void startScan_Click(object sender, EventArgs e)
        {
            //sendMesssage(4, 8, 8); //true
                sendMesssage(4, 8, 32);
                isStartScan = true;
        }

        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            System.IO.Ports.SerialPort serialport = (System.IO.Ports.SerialPort)sender;
            string message = serialport.ReadLine();

            if(isClcked)
            {
                if(message == "handshake")
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        startScan.Enabled = true; //synchrinizacja watka 
                                                  //add code to store data permanently 
                    
                    }));
                  
                }
            }

            if (isStartScan)
            {
                diodstate.BackColor = Color.Green;
                float angle = 0;
                if (message.IndexOf("i") != -1)
                {
                    try
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            parser(message);
                            angle = calculateAngle();  //kąt
                            visualization.calculatePoints(distance, angle);
                            visualization.drawPoints(bitmap, board);
                            board.Invalidate();
                            callAmount++;
                        }));
                    }
                    catch
                    { }
                }
                
                // assign to textbox by marshalling to UI thread
                this.Invoke(new MethodInvoker(delegate ()
                 {

                    meter.Text = message;
                     if (callAmount == 800) panel1.Visible = true;
                    //add code to store data permanently 
                }));
            }
        }

        public bool sendMesssage( byte param1, byte param2, byte param3)
        {
            byte[] bufer = new byte[4];
            bufer[0] = (param1);
            bufer[1] = (param2);
            bufer[2] = (param3);
            bufer[3] = (Convert.ToByte('\n'));
            try
            {
                if (!com.IsOpen)
                {
                    return false;
                }
                com.Write(bufer, 0, 3);
                return true;
            }
            catch { }
            return false;

        }

        private void board_Paint_1(object sender, PaintEventArgs e)
        {
    
            e.Graphics.DrawImageUnscaled(bitmap, new Point(0, 0));
            this.DoubleBuffered = true;

        }

        private void SaveSurface_Click(object sender, EventArgs e)
        {
            string path;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Choose directory";
                dialog.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    path = dialog.FileName;
                    bitmap.Save(path, ImageFormat.Jpeg);
                }
            }
        }

        private void LoadSurface_Click(object sender, EventArgs e)
        {
            string path;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Wybierz bitmape";
                dialog.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    path = dialog.FileName; 
                    bitmap = (Bitmap)Image.FromFile(path, true);
                }
                board.Invalidate(true);
            }
        }


        private void Form1_Load(object sender, EventArgs e) { }
  
        private void PrintResults()
        {
            result.Visible = true;
            panel3.Visible = true;
            getHeight.Text = "Height   " + visualization.getHeight();
            width.Text = "Width   " + visualization.getWidth();
            visualization.calculateSurfaceArea();
            area.Text = "Area surface  " + visualization.getArea().ToString();
            //  area.Text += calculatSurface ? visualization.getArea().ToString() : "Still processing...";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           if(callAmount >= 800)
            {
                PrintResults();
            }
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            PrintResults();
            callAmount = 0;
        }
    }
}
