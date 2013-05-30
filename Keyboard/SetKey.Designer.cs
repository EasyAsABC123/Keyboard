namespace Keyboard
{
	partial class SetKey
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetKey));
			this.keyChoices = new System.Windows.Forms.ComboBox();
			this.altChkBox = new System.Windows.Forms.CheckBox();
			this.shiftChkBox = new System.Windows.Forms.CheckBox();
			this.ctrlChkBox = new System.Windows.Forms.CheckBox();
			this.acceptBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.shiftKeys = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// keyChoices
			// 
			this.keyChoices.FormattingEnabled = true;
			this.keyChoices.Location = new System.Drawing.Point(12, 12);
			this.keyChoices.Name = "keyChoices";
			this.keyChoices.Size = new System.Drawing.Size(207, 21);
			this.keyChoices.TabIndex = 0;
			this.keyChoices.SelectedIndexChanged += new System.EventHandler(this.keyChoices_SelectedIndexChanged);
			this.keyChoices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyChoices_KeyDown);
			// 
			// altChkBox
			// 
			this.altChkBox.AutoSize = true;
			this.altChkBox.Location = new System.Drawing.Point(12, 39);
			this.altChkBox.Name = "altChkBox";
			this.altChkBox.Size = new System.Drawing.Size(38, 17);
			this.altChkBox.TabIndex = 2;
			this.altChkBox.Text = "Alt";
			this.altChkBox.UseVisualStyleBackColor = true;
			this.altChkBox.CheckedChanged += new System.EventHandler(this.altChkBox_CheckedChanged);
			this.altChkBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyChoices_KeyDown);
			// 
			// shiftChkBox
			// 
			this.shiftChkBox.AutoSize = true;
			this.shiftChkBox.Location = new System.Drawing.Point(101, 39);
			this.shiftChkBox.Name = "shiftChkBox";
			this.shiftChkBox.Size = new System.Drawing.Size(47, 17);
			this.shiftChkBox.TabIndex = 3;
			this.shiftChkBox.Text = "Shift";
			this.shiftChkBox.UseVisualStyleBackColor = true;
			this.shiftChkBox.CheckedChanged += new System.EventHandler(this.shiftChkBox_CheckedChanged);
			this.shiftChkBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyChoices_KeyDown);
			// 
			// ctrlChkBox
			// 
			this.ctrlChkBox.AutoSize = true;
			this.ctrlChkBox.Location = new System.Drawing.Point(56, 39);
			this.ctrlChkBox.Name = "ctrlChkBox";
			this.ctrlChkBox.Size = new System.Drawing.Size(41, 17);
			this.ctrlChkBox.TabIndex = 4;
			this.ctrlChkBox.Text = "Ctrl";
			this.ctrlChkBox.UseVisualStyleBackColor = true;
			this.ctrlChkBox.CheckedChanged += new System.EventHandler(this.ctrlChkBox_CheckedChanged);
			this.ctrlChkBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyChoices_KeyDown);
			// 
			// acceptBtn
			// 
			this.acceptBtn.Location = new System.Drawing.Point(12, 62);
			this.acceptBtn.Name = "acceptBtn";
			this.acceptBtn.Size = new System.Drawing.Size(62, 23);
			this.acceptBtn.TabIndex = 5;
			this.acceptBtn.Text = "Accept";
			this.acceptBtn.UseVisualStyleBackColor = true;
			this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(157, 62);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(62, 23);
			this.cancelBtn.TabIndex = 6;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// shiftKeys
			// 
			this.shiftKeys.Enabled = false;
			this.shiftKeys.FormattingEnabled = true;
			this.shiftKeys.Location = new System.Drawing.Point(155, 35);
			this.shiftKeys.Name = "shiftKeys";
			this.shiftKeys.Size = new System.Drawing.Size(64, 21);
			this.shiftKeys.TabIndex = 7;
			this.shiftKeys.SelectedIndexChanged += new System.EventHandler(this.shiftKeys_SelectedIndexChanged);
			this.shiftKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shiftKeys_KeyDown);
			// 
			// SetKey
			// 
			this.AcceptButton = this.acceptBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(231, 97);
			this.Controls.Add(this.shiftKeys);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.acceptBtn);
			this.Controls.Add(this.ctrlChkBox);
			this.Controls.Add(this.shiftChkBox);
			this.Controls.Add(this.altChkBox);
			this.Controls.Add(this.keyChoices);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SetKey";
			this.Text = "Set Key";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox keyChoices;
		private System.Windows.Forms.CheckBox altChkBox;
		private System.Windows.Forms.CheckBox shiftChkBox;
		private System.Windows.Forms.CheckBox ctrlChkBox;
		private System.Windows.Forms.Button acceptBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ComboBox shiftKeys;
	}
}