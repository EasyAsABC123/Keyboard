using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyboard;

namespace KeyboardDemo
{
	class Program
	{
		static void Main(string[] args)
		{
            // var p = new Process {StartInfo = {FileName = "notepad.exe"}};
            var p = new Process();
            p.StartInfo.FileName = "mstsc.exe";
            p.StartInfo.Arguments = "C:\\Users\\Freddie\\Desktop\\DellDektop.rdp";

            p.Start();

            System.Threading.Thread.Sleep(5000);

			try
			{
				//List<Key> keys = "\n".Select(c => new Key(c)).ToList();
				var procId = p.Id;
				Console.WriteLine("ID: " + procId);
				Console.WriteLine("Sending background keypresses to write \"hello world\"");
				p.WaitForInputIdle();

                //foreach (var key in keys)				{					key.PressForeground(p.MainWindowHandle);				}
                var enter = new Key(Messaging.VKeys.KEY_RETURN);
                enter.PressForeground(p.MainWindowHandle);

			}
			catch (InvalidOperationException)
			{
			}
		}
	}
}
