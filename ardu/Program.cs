using System;
using System.IO.Ports;
using System.Threading;
namespace Program
{
    class Program
    {
        static SerialPort _serialPort;
        public static void Main()
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            Console.WriteLine("Вкажіть номер порту підключення: ");
            _serialPort.PortName = "COM" + Console.ReadLine().ToString();
            _serialPort.Open();
            while (true)
            {
                string a = _serialPort.ReadExisting();
                Console.WriteLine(a);
                Thread.Sleep(120);
            }
        }
    }
}