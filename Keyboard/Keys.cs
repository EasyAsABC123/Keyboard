using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Keyboard {
	[Serializable]
	public class Keys {
		public Key LootKey {
			get;
			set;
		}
		public Key FindMobKey {
			get;
			set;
		}
		public Key RestKey {
			get;
			set;
		}
		public Key RotateKey {
			get;
			set;
		}
		public Key EscKey {
			get;
			set;
		}
		public Key TargetSelf {
			get;
			set;
		}
		public Key StartStop {
			get;
			set;
		}
		public Key AttackKey {
			get;
			set;
		}
		public Key ReturnToTownKey {
			get;
			set;
		}
		public Key Forward {
			get;
			set;
		}
		public Key Backwards {
			get;
			set;
		}
		public Key Left {
			get;
			set;
		}
		public Key Right {
			get;
			set;
		}
		public Key StrafeLeft {
			get;
			set;
		}
		public Key StrafeRight {
			get;
			set;
		}

		public Keys() {
			this.AttackKey = new Key(Messaging.VKeys.KEY_1, Messaging.ShiftType.NONE);
			this.StartStop = new Key(Messaging.VKeys.KEY_ESCAPE, Messaging.ShiftType.ALT_CTRL);
			this.EscKey = new Key(Messaging.VKeys.KEY_ESCAPE);
			this.LootKey = new Key(Messaging.VKeys.KEY_PLUS);
			this.FindMobKey = new Key(Messaging.VKeys.KEY_TAB);
			this.RestKey = new Key(Messaging.VKeys.KEY_COMMA);
			this.RotateKey = new Key(Messaging.VKeys.KEY_MBUTTON);
			this.TargetSelf = new Key(Messaging.VKeys.KEY_F1);
			this.ReturnToTownKey = new Key(Messaging.VKeys.KEY_PLUS, Messaging.ShiftType.ALT);
			this.Forward = new Key(Messaging.VKeys.KEY_W);
			this.Backwards = new Key(Messaging.VKeys.KEY_S);
			this.Left = new Key(Messaging.VKeys.KEY_A);
			this.Right = new Key(Messaging.VKeys.KEY_D);
			this.StrafeLeft = new Key(Messaging.VKeys.KEY_Q);
			this.StrafeRight = new Key(Messaging.VKeys.KEY_E);
		}

		public static void Serialize(string path, Keys keys) {
			XmlSerializer serializer = new XmlSerializer(typeof(Keys));
			FileStream xmlStream = new FileStream(path, FileMode.Create, FileAccess.Write);
			serializer.Serialize(xmlStream, keys);
			xmlStream.Close();
		}

		public static void Serialize(Stream stream, Keys keys) {
			XmlSerializer serializer = new XmlSerializer(typeof(Keys));
			Stream xmlStream = stream;
			serializer.Serialize(xmlStream, keys);
			xmlStream.Close();
		}

		public static Keys Deserialize(string path) {
			try {
				Keys keys = new Keys();
				XmlSerializer serializer = new XmlSerializer(typeof(Keys));
				FileStream xmlStream = new FileStream(path, FileMode.Open, FileAccess.Read);
				keys = serializer.Deserialize(xmlStream) as Keys;
				xmlStream.Close();
				return keys;
			} catch {
				return new Keys();
			}
		}

		public static Keys Deserialize(Stream stream) {
			Keys keys = new Keys();
			XmlSerializer serializer = new XmlSerializer(typeof(Keys));
			keys = serializer.Deserialize(stream) as Keys;
			stream.Close();
			return keys;
		}
	}
}
