﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;

namespace Keyboard {
	/// <summary>An individual keyboard key.</summary>
	[Serializable]
	public class Key : UITypeEditor {
		[DllImport("user32.dll")]
		static extern short VkKeyScan(char ch);

		/// <summary>The virtual key associated with it.</summary>
		public Messaging.VKeys VK;
		/// <summary>The shift type (alt, ctrl, shift).</summary>
		public Messaging.ShiftType ShiftType;
		/// <summary>The shift key's virtual key code.</summary>
		public Messaging.VKeys ShiftKey;
		/// <summary>An internal counter used to count the number of attempts a button has tried to be pressed to exit after 4 attempts.</summary>
		private int buttonCounter;

		/// <summary>Default constructor</summary>
		public Key() {
			buttonCounter = 0;
			this.VK = Messaging.VKeys.NULL;
			this.ShiftKey = Messaging.VKeys.NULL;
			this.ShiftType = Messaging.ShiftType.NONE;
		}

		/// <summary>Constructor if you already have a key.</summary>
		/// <param name="vk">The main virtual key.</param>
		public Key(Messaging.VKeys vk) {
			buttonCounter = 0;
			this.VK = vk;
			this.ShiftKey = Messaging.VKeys.NULL;
			this.ShiftType = Messaging.ShiftType.NONE;
		}

		public Key(char c) {
			buttonCounter = 0;
			this.VK = (Messaging.VKeys) c;
			this.ShiftKey = Messaging.VKeys.NULL;
			this.ShiftType = Messaging.ShiftType.NONE;
		}

		/// <summary>Constructor if you have a key and a shift key.</summary>
		/// <param name="vk">Main key</param>
		/// <param name="shiftKey">The shift key</param>
		public Key(Messaging.VKeys vk, Messaging.VKeys shiftKey) {
			buttonCounter = 0;
			this.VK = vk;
			this.ShiftKey = shiftKey;
			this.ShiftType = Messaging.ShiftType.NONE;
		}

		/// <summary>Constructor if you have a key and a shift type (alt, ctrl, shift)</summary>
		/// <param name="vk">The main key</param>
		/// <param name="shiftType">The shift type to be used with the main key.</param>
		public Key(Messaging.VKeys vk, Messaging.ShiftType shiftType) {
			buttonCounter = 0;
			this.VK = vk;
			this.ShiftKey = Messaging.VKeys.NULL;
			this.ShiftType = shiftType;
		}

		/// <summary>Constructor if you already have a whole key.  Good for making a dereferenced copy.</summary>
		/// <param name="key">The already built key.</param>
		public Key(Key key) {
			buttonCounter = 0;
			this.VK = key.VK;
			this.ShiftKey = key.ShiftKey;
			this.ShiftType = key.ShiftType;
		}

		/// <summary>Emulates a keyboard key press.</summary>
		/// <param name="hWnd">The handle to the window that will receive the key press.</param>
		/// <param name="foreground">Whether it should be a foreground key press or a background key press.</param>
		/// <returns>If the press succeeded or failed.</returns>
		public bool Press(IntPtr hWnd, bool foreground) {
			if(foreground)
				return PressForeground(hWnd);

			return PressBackground(hWnd);
		}

		public bool Down(IntPtr hWnd, bool foreground) {
			bool alt = false, ctrl = false, shift = false;
			switch(this.ShiftType) {
				case Messaging.ShiftType.ALT:
					alt = true;
					break;
				case Messaging.ShiftType.CTRL:
					ctrl = true;
					break;
				case Messaging.ShiftType.NONE:
					if(foreground) {
						if(!Messaging.ForegroundKeyDown(hWnd, this)) {
							buttonCounter++;
							if(buttonCounter == 2) {
								buttonCounter = 0;
								return false;
							}
							Down(hWnd, foreground);
						}
					} else {
						if(!Messaging.SendMessageDown(hWnd, this, true)) {
							buttonCounter++;
							if(buttonCounter == 2) {
								buttonCounter = 0;
								return false;
							}
							Down(hWnd, foreground);
						}
					}
					return true;
				case Messaging.ShiftType.SHIFT:
					shift = true;
					break;
			}
			return true;
		}

		public bool Up(IntPtr hWnd, bool foreground) {
			bool alt = false, ctrl = false, shift = false;
			switch(this.ShiftType) {
				case Messaging.ShiftType.ALT:
					alt = true;
					break;
				case Messaging.ShiftType.CTRL:
					ctrl = true;
					break;
				case Messaging.ShiftType.NONE:
					if(foreground) {
						if(!Messaging.ForegroundKeyUp(hWnd, this)) {
							buttonCounter++;
							if(buttonCounter == 2) {
								buttonCounter = 0;
								return false;
							}
							Up(hWnd, foreground);
						}
					} else {
						if(!Messaging.SendMessageUp(hWnd, this, true)) {
							buttonCounter++;
							if(buttonCounter == 2) {
								buttonCounter = 0;
								return false;
							}
							Up(hWnd, foreground);
						}
					}
					return true;
				case Messaging.ShiftType.SHIFT:
					shift = true;
					break;
			}
			return true;
		}

		public bool PressForeground() {
			bool alt = false, ctrl = false, shift = false;
			switch(this.ShiftType) {
				case Messaging.ShiftType.ALT:
					alt = true;
					break;
				case Messaging.ShiftType.CTRL:
					ctrl = true;
					break;
				case Messaging.ShiftType.NONE:
					if(!Messaging.ForegroundKeyPress(this)) {
						buttonCounter++;
						if(buttonCounter == 2) {
							buttonCounter = 0;
							return false;
						}
						PressForeground();
					}
					return true;
				case Messaging.ShiftType.SHIFT:
					shift = true;
					break;
			}
			return true;
		}

		/// <summary>Emulates a background keyboard key press.</summary>
		/// <param name="hWnd">The handle to the window that will receive the key press.</param>
		/// <returns>If the key press succeeded or failed.</returns>
		public bool PressBackground(IntPtr hWnd) {
			bool alt = false, ctrl = false, shift = false;
			switch(this.ShiftType) {
				case Messaging.ShiftType.ALT:
					alt = true;
					break;
				case Messaging.ShiftType.CTRL:
					ctrl = true;
					break;
				case Messaging.ShiftType.NONE:
					if(!Messaging.SendMessage(hWnd, this, true)) {
						buttonCounter++;
						if(buttonCounter == 2) {
							buttonCounter = 0;
							return false;
						}
						PressBackground(hWnd);
					}
					return true;
				case Messaging.ShiftType.SHIFT:
					shift = true;
					break;
			}
			if(!Messaging.SendMessageAll(hWnd, this, alt, ctrl, shift)) {
				buttonCounter++;
				if(buttonCounter == 2) {
					buttonCounter = 0;
					return false;
				}
				PressBackground(hWnd);
			}
			return true;
		}

		/// <summary>Emulates a foreground key press.</summary>
		/// <param name="hWnd">The handle to the window that will receive the key press.</param>
		/// <returns>Returns whether the key succeeded to be pressed or not.</returns>
		public bool PressForeground(IntPtr hWnd) {
			bool alt = false, ctrl = false, shift = false;
			switch(this.ShiftType) {
				case Messaging.ShiftType.ALT:
					alt = true;
					break;
				case Messaging.ShiftType.CTRL:
					ctrl = true;
					break;
				case Messaging.ShiftType.NONE:
					if(!Messaging.ForegroundKeyPress(hWnd, this)) {
						buttonCounter++;
						if(buttonCounter == 2) {
							buttonCounter = 0;
							return false;
						}
						PressForeground(hWnd);
					}
					return true;
				case Messaging.ShiftType.SHIFT:
					shift = true;
					break;
			}
			if(!Messaging.ForegroundKeyPressAll(hWnd, this, alt, ctrl, shift)) {
				buttonCounter++;
				if(buttonCounter == 2) {
					buttonCounter = 0;
					return false;
				}
				PressForeground(hWnd);
			}
			return true;
		}

		/// <summary>Allows the property grid edit form.</summary>
		/// <param name="context">The style the editor takes.</param>
		/// <returns>The drop down style.</returns>
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
			return UITypeEditorEditStyle.DropDown;
		}

		/// <summary>Allows the property grid drop down.</summary>
		/// <param name="context">The context for the type.</param>
		/// <param name="provider">The service provider.</param>
		/// <param name="value">The value that the object has.</param>
		/// <returns></returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
			IWindowsFormsEditorService wfes = provider.GetService(
				typeof(IWindowsFormsEditorService)) as
				IWindowsFormsEditorService;

			if(wfes != null) {
				SetKey setKey = new SetKey((Key) value);

				wfes.DropDownControl(setKey);
				value = setKey.Key;

			}
			return value;
		}

		/// <summary>Override to return the key's string</summary>
		/// <returns>Returns the proper string.</returns>
		public override string ToString() {
			return string.Format("{0} {1}", this.ShiftType.ToString(), this.VK.ToString());
		}
	}
}
