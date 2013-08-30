﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyboard;

namespace NotePadTest {
	public partial class Form1 : Form {
		private Process notepad;
		private string binaryPath = @"C:\Program Files (x86)\Notepad++\notepad++.exe";
		public Form1() {
			InitializeComponent();
			notepad = Process.Start(binaryPath);
			notepad.WaitForInputIdle();
			SetParent(notepad.MainWindowHandle, panel1.Handle);
			Key f11 = new Key(Messaging.VKeys.KEY_F11); // Full screen
			Messaging.ForegroundKeyPress(notepad.MainWindowHandle, f11);
		}

		private void close(object sender, FormClosedEventArgs e) {
			
		}

		[DllImport("user32.dll")]
		static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}
}
