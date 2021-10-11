using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;
using System.Windows;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace lidar
{
    class Port
    {
        private string comName;
        private int baudRate;

        public System.IO.Ports.SerialPort com;
        public Dictionary<int, float> distance = new Dictionary<int, float>();
        public float dist;



        public Port(string comName, int baudRate)
        {

            this.comName = comName;
            this.baudRate = baudRate;
            //com = new SerialPort();
            //com.PortName = comName;
            //com.BaudRate = baudRate;
            com = new SerialPort(comName, baudRate);

        }

        public bool sendMesssage(String handShake, byte param1, byte param2, byte param3)
        {
            byte[] bufer = new byte[3];
            bufer[0] = (param1);
            bufer[1] = (param2);
            bufer[2] = (param3);
            try
            {
                if (!com.IsOpen)
                {

                    com.Open();
                    com.DtrEnable = true;    // Data-terminal-ready
                    com.RtsEnable = true;
                }

                com.Write(bufer, 0, 3);
                //Thread.Sleep(200);
                int isReady = com.BytesToRead;
                string returnMessage = "";
                
                returnMessage = com.ReadLine();
              

                if (returnMessage.Contains(handShake))
                {
                    return true;
                }
            }
            catch
            {
               
            }
            return false;

        }


        public Boolean disconnectPort()
        {
            
            if (com != null && com.IsOpen)
            {
                com.Close();
                return true;
            }
            else return false;
          
          
        }


        public string getDistance(byte param1, byte param2, byte param3, System.IO.Ports.SerialPort port)
        {
            try
            {

                 byte[] bufer = new byte[3];
                 bufer[0] = Convert.ToByte(param1);
                 bufer[1] = Convert.ToByte(param2);
                 bufer[2] = Convert.ToByte(param3);
                 com.Write(bufer, 0, 3);
                 string message = port.ReadLine();

                return message;

            }
            catch (Exception e)
            {
                return "Error with getting a message";
            }
        }
  
    }
}
