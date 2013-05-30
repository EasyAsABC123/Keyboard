using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keyboard
{
	/// <summary>
	/// Enumeration for virtual keys.
	/// </summary>
	public enum VirtualKeys
		: ushort
	{
		/// <summary>Left mouse button.</summary>
		LeftButton = 0x01,
		/// <summary>Right mouse button.</summary>
		RightButton = 0x02,
		/// <summary>Control-break processing.</summary>
		Cancel = 0x03,
		/// <summary>Middle mouse button (three-button mouse).</summary>
		MiddleButton = 0x04,
		/// <summary>Extra mouse button 1.</summary>
		ExtraButton1 = 0x05,
		/// <summary>Extrea mouse button 2.</summary>
		ExtraButton2 = 0x06,
		/// <summary>Backspace key.</summary>
		Back = 0x08,
		/// <summary>Tab key.</summary>
		Tab = 0x09,
		/// <summary>Clear key.</summary>
		Clear = 0x0C,
		/// <summary>Return key.</summary>
		Return = 0x0D,
		/// <summary>Shift key.</summary>
		Shift = 0x10,
		/// <summary>Control key.</summary>
		Control = 0x11,
		/// <summary>Alt key.</summary>
		Menu = 0x12,
		/// <summary>Puase key.</summary>
		Pause = 0x13,
		/// <summary>Capital key.</summary>
		Capital = 0x14,
		/// <summary>Kana key.</summary>
		Kana = 0x15,
		/// <summary>Hangeul key.</summary>
		Hangeul = 0x15,
		/// <summary>Hangul key.</summary>
		Hangul = 0x15,
		/// <summary>Junja key.</summary>
		Junja = 0x17,
		/// <summary>Final key.</summary>
		Final = 0x18,
		/// <summary>Hanja key.</summary>
		Hanja = 0x19,
		/// <summary>Kanji key.</summary>
		Kanji = 0x19,
		/// <summary>Escape key.</summary>
		Escape = 0x1B,
		/// <summary>Convert key.</summary>
		Convert = 0x1C,
		/// <summary>Non-convert key.</summary>
		NonConvert = 0x1D,
		/// <summary>Accept key.</summary>
		Accept = 0x1E,
		/// <summary>Mode change key.</summary>
		ModeChange = 0x1F,
		/// <summary>Spacebar key.</summary>
		Space = 0x20,
		/// <summary>Prior key.</summary>
		Prior = 0x21,
		/// <summary>Next key.</summary>
		Next = 0x22,
		/// <summary>End key.</summary>
		End = 0x23,
		/// <summary>Home key.</summary>
		Home = 0x24,
		/// <summary>Left key.</summary>
		Left = 0x25,
		/// <summary>Up key.</summary>
		Up = 0x26,
		/// <summary>Right key.</summary>
		Right = 0x27,
		/// <summary>Down key.</summary>
		Down = 0x28,
		/// <summary>Select key.</summary>
		Select = 0x29,
		/// <summary>Print screen key.</summary>
		Print = 0x2A,
		/// <summary>Execute key.</summary>
		Execute = 0x2B,
		/// <summary>Snapshot key.</summary>
		Snapshot = 0x2C,
		/// <summary>Insert key.</summary>
		Insert = 0x2D,
		/// <summary>Delete key.</summary>
		Delete = 0x2E,
		/// <summary>Help key.</summary>
		Help = 0x2F,
		/// <summary>Number 0 key.</summary>
		Num0 = 0x30,
		/// <summary>Number 1 key.</summary>
		Num1 = 0x31,
		/// <summary>Number 2 key.</summary>
		Num2 = 0x32,
		/// <summary>Number 3 key.</summary>
		Num3 = 0x33,
		/// <summary>Number 4 key.</summary>
		Num4 = 0x34,
		/// <summary>Number 5 key.</summary>
		Num5 = 0x35,
		/// <summary>Number 6 key.</summary>
		Num6 = 0x36,
		/// <summary>Number 7 key.</summary>
		Num7 = 0x37,
		/// <summary>Number 8 key.</summary>
		Num8 = 0x38,
		/// <summary>Number 9 key.</summary>
		Num9 = 0x39,
		/// <summary>A key.</summary>
		A = 0x41,
		/// <summary>B key.</summary>
		B = 0x42,
		/// <summary>C key.</summary>
		C = 0x43,
		/// <summary>D key.</summary>
		D = 0x44,
		/// <summary>E key.</summary>
		E = 0x45,
		/// <summary>F key.</summary>
		F = 0x46,
		/// <summary>G key.</summary>
		G = 0x47,
		/// <summary>H key.</summary>
		H = 0x48,
		/// <summary>I key.</summary>
		I = 0x49,
		/// <summary>J key.</summary>
		J = 0x4A,
		/// <summary>K key.</summary>
		K = 0x4B,
		/// <summary>L key.</summary>
		L = 0x4C,
		/// <summary>M key.</summary>
		M = 0x4D,
		/// <summary>N key.</summary>
		N = 0x4E,
		/// <summary>O key.</summary>
		O = 0x4F,
		/// <summary>P key.</summary>
		P = 0x50,
		/// <summary>Q key.</summary>
		Q = 0x51,
		/// <summary>R key.</summary>
		R = 0x52,
		/// <summary>S key.</summary>
		S = 0x53,
		/// <summary>T key.</summary>
		T = 0x54,
		/// <summary>U key.</summary>
		U = 0x55,
		/// <summary>V key.</summary>
		V = 0x56,
		/// <summary>W key.</summary>
		W = 0x57,
		/// <summary>X key.</summary>
		X = 0x58,
		/// <summary>Y key.</summary>
		Y = 0x59,
		/// <summary>Z key.</summary>
		Z = 0x5A,
		/// <summary>Left-windows key.</summary>
		LeftWindows = 0x5B,
		/// <summary>Right-windows key.</summary>
		RightWindows = 0x5C,
		/// <summary>Application key.</summary>
		Application = 0x5D,
		/// <summary>Sleep key.</summary>
		Sleep = 0x5F,
		/// <summary>Numberpad 0 key.</summary>
		Numpad0 = 0x60,
		/// <summary>Numberpad 1 key.</summary>
		Numpad1 = 0x61,
		/// <summary>Numberpad 2 key.</summary>
		Numpad2 = 0x62,
		/// <summary>Numberpad 3 key.</summary>
		Numpad3 = 0x63,
		/// <summary>Numberpad 4 key.</summary>
		Numpad4 = 0x64,
		/// <summary>Numberpad 5 key.</summary>
		Numpad5 = 0x65,
		/// <summary>Numberpad 6 key.</summary>
		Numpad6 = 0x66,
		/// <summary>Numberpad 7 key.</summary>
		Numpad7 = 0x67,
		/// <summary>Numberpad 8 key.</summary>
		Numpad8 = 0x68,
		/// <summary>Numberpad 9 key.</summary>
		Numpad9 = 0x69,
		/// <summary>Multiply key.</summary>
		Multiply = 0x6A,
		/// <summary>Add key.</summary>
		Add = 0x6B,
		/// <summary>Seperator key.</summary>
		Separator = 0x6C,
		/// <summary>Subtract key.</summary>
		Subtract = 0x6D,
		/// <summary>Decimal key.</summary>
		Decimal = 0x6E,
		/// <summary>Divide key.</summary>
		Divide = 0x6F,
		/// <summary>Function 1 key.</summary>
		F1 = 0x70,
		/// <summary>Function 2 key.</summary>
		F2 = 0x71,
		/// <summary>Function 3 key.</summary>
		F3 = 0x72,
		/// <summary>Function 4 key.</summary>
		F4 = 0x73,
		/// <summary>Function 5 key.</summary>
		F5 = 0x74,
		/// <summary>Function 6 key.</summary>
		F6 = 0x75,
		/// <summary>Function 7 key.</summary>
		F7 = 0x76,
		/// <summary>Function 8 key.</summary>
		F8 = 0x77,
		/// <summary>Function 9 key.</summary>
		F9 = 0x78,
		/// <summary>Function 10 key.</summary>
		F10 = 0x79,
		/// <summary>Function 11 key.</summary>
		F11 = 0x7A,
		/// <summary>Function 12 key.</summary>
		F12 = 0x7B,
		/// <summary>Function 13 key.</summary>
		F13 = 0x7C,
		/// <summary>Function 14 key.</summary>
		F14 = 0x7D,
		/// <summary>Function 15 key.</summary>
		F15 = 0x7E,
		/// <summary>Function 16 key.</summary>
		F16 = 0x7F,
		/// <summary>Function 17 key.</summary>
		F17 = 0x80,
		/// <summary>Function 18 key.</summary>
		F18 = 0x81,
		/// <summary>Function 19 key.</summary>
		F19 = 0x82,
		/// <summary>Function 20 key.</summary>
		F20 = 0x83,
		/// <summary>Function 21 key.</summary>
		F21 = 0x84,
		/// <summary>Function 22 key.</summary>
		F22 = 0x85,
		/// <summary>Function 23 key.</summary>
		F23 = 0x86,
		/// <summary>Function 24 key.</summary>
		F24 = 0x87,
		/// <summary>Number lock key.</summary>
		NumLock = 0x90,
		/// <summary>Scroll lock key.</summary>
		ScrollLock = 0x91,
		/// <summary>Equal key.</summary>
		NEC_Equal = 0x92,
		/// <summary>Fujitsu Jisho key.</summary>
		Fujitsu_Jisho = 0x92,
		/// <summary>Fujitsu Masshou key.</summary>
		Fujitsu_Masshou = 0x93,
		/// <summary>Fujitsu Touroku key.</summary>
		Fujitsu_Touroku = 0x94,
		/// <summary>Fujitsu Loya key.</summary>
		Fujitsu_Loya = 0x95,
		/// <summary>Fujitsu Roya key.</summary>
		Fujitsu_Roya = 0x96,
		/// <summary>Left-shift key.</summary>
		LeftShift = 0xA0,
		/// <summary>Right-shift key.</summary>
		RightShift = 0xA1,
		/// <summary>Left-control key.</summary>
		LeftControl = 0xA2,
		/// <summary>Right-control key.</summary>
		RightControl = 0xA3,
		/// <summary>Left-alt key.</summary>
		LeftMenu = 0xA4,
		/// <summary>Right-alt key.</summary>
		RightMenu = 0xA5,
		/// <summary>Browser back key.</summary>
		BrowserBack = 0xA6,
		/// <summary>Browser forward key.</summary>
		BrowserForward = 0xA7,
		/// <summary>Browser refresh key.</summary>
		BrowserRefresh = 0xA8,
		/// <summary>Browser stop key.</summary>
		BrowserStop = 0xA9,
		/// <summary>Browser search key.</summary>
		BrowserSearch = 0xAA,
		/// <summary>Browser favorites key.</summary>
		BrowserFavorites = 0xAB,
		/// <summary>Browser home key.</summary>
		BrowserHome = 0xAC,
		/// <summary></summary>
		VolumeMute = 0xAD,
		/// <summary></summary>
		VolumeDown = 0xAE,
		/// <summary></summary>
		VolumeUp = 0xAF,
		/// <summary></summary>
		MediaNextTrack = 0xB0,
		/// <summary></summary>
		MediaPrevTrack = 0xB1,
		/// <summary></summary>
		MediaStop = 0xB2,
		/// <summary></summary>
		MediaPlayPause = 0xB3,
		/// <summary></summary>
		LaunchMail = 0xB4,
		/// <summary></summary>
		LaunchMediaSelect = 0xB5,
		/// <summary></summary>
		LaunchApplication1 = 0xB6,
		/// <summary></summary>
		LaunchApplication2 = 0xB7,
		/// <summary></summary>
		OEM1 = 0xBA,
		/// <summary></summary>
		OEMPlus = 0xBB,
		/// <summary></summary>
		OEMComma = 0xBC,
		/// <summary></summary>
		OEMMinus = 0xBD,
		/// <summary></summary>
		OEMPeriod = 0xBE,
		/// <summary></summary>
		OEM2 = 0xBF,
		/// <summary></summary>
		OEM3 = 0xC0,
		/// <summary></summary>
		OEM4 = 0xDB,
		/// <summary></summary>
		OEM5 = 0xDC,
		/// <summary></summary>
		OEM6 = 0xDD,
		/// <summary></summary>
		OEM7 = 0xDE,
		/// <summary></summary>
		OEM8 = 0xDF,
		/// <summary></summary>
		OEMAX = 0xE1,
		/// <summary></summary>
		OEM102 = 0xE2,
		/// <summary></summary>
		ICOHelp = 0xE3,
		/// <summary></summary>
		ICO00 = 0xE4,
		/// <summary></summary>
		ProcessKey = 0xE5,
		/// <summary></summary>
		ICOClear = 0xE6,
		/// <summary></summary>
		Packet = 0xE7,
		/// <summary></summary>
		OEMReset = 0xE9,
		/// <summary></summary>
		OEMJump = 0xEA,
		/// <summary></summary>
		OEMPA1 = 0xEB,
		/// <summary></summary>
		OEMPA2 = 0xEC,
		/// <summary></summary>
		OEMPA3 = 0xED,
		/// <summary></summary>
		OEMWSCtrl = 0xEE,
		/// <summary></summary>
		OEMCUSel = 0xEF,
		/// <summary></summary>
		OEMATTN = 0xF0,
		/// <summary></summary>
		OEMFinish = 0xF1,
		/// <summary></summary>
		OEMCopy = 0xF2,
		/// <summary></summary>
		OEMAuto = 0xF3,
		/// <summary></summary>
		OEMENLW = 0xF4,
		/// <summary></summary>
		OEMBackTab = 0xF5,
		/// <summary></summary>
		ATTN = 0xF6,
		/// <summary></summary>
		CRSel = 0xF7,
		/// <summary></summary>
		EXSel = 0xF8,
		/// <summary></summary>
		EREOF = 0xF9,
		/// <summary></summary>
		Play = 0xFA,
		/// <summary></summary>
		Zoom = 0xFB,
		/// <summary></summary>
		Noname = 0xFC,
		/// <summary></summary>
		PA1 = 0xFD,
		/// <summary></summary>
		OEMClear = 0xFE
	}
}
