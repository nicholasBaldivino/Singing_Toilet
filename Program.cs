using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ArduinoTOTO
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM6";//set as the same com that is listed on the arduino
            myport.Open();

            var myPlayer = new System.Media.SoundPlayer();

            while(true)
            {
                string dataRx = myport.ReadLine();
                Console.WriteLine(dataRx);

                if (dataRx == "On\r")
                {
                    myPlayer.SoundLocation = @"C:\Users\nickb\OneDrive\Desktop\ontivacom-africa-hq_2Hkp3AvD.wav";//input location of .wav file
                    myPlayer.PlaySync();
                }
                else
                {

                }
                
            }
        }
    }
}
