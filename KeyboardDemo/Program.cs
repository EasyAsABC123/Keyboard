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
			var p = new Process {StartInfo = {FileName = "notepad.exe"}};

			p.Start();

			try
			{
				List<Key> keys = "Hello world".Select(c => new Key(c)).ToList();
				//exclamation mark - shift+1
				keys.Add(new Key(Messaging.VKeys.KEY_1, Messaging.VKeys.KEY_SHIFT, Messaging.ShiftType.SHIFT));
				var procId = p.Id;
				Console.WriteLine("ID: " + procId);
				Console.WriteLine("Sending background keypresses to write \"hello world\"");
				p.WaitForInputIdle();
				foreach (var key in keys)
				{
					key.PressForeground(p.MainWindowHandle);
                }

			}
			catch (InvalidOperationException)
			{
			}
		}
	}
}
