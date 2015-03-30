/*
 * Copyright (c) 2012 - Petros Kyladitis
 * This file is part of SubnetCalculator project, and is distributed under the FreeBSD License.
 * Please see license.txt for the FreeBSD License in its entire length
 */
 
namespace SubnetCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNetmask = new System.Windows.Forms.TextBox();
			this.textBoxNetprefix = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxBroadcast = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNetmaskLength = new System.Windows.Forms.TextBox();
			this.textBoxNetCapacity = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxHihostIP = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxLowHostIP = new System.Windows.Forms.TextBox();
			this.radioButtonNetmask = new System.Windows.Forms.RadioButton();
			this.radioButtonNetmaskLength = new System.Windows.Forms.RadioButton();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxIP
			// 
			this.textBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxIP.Location = new System.Drawing.Point(148, 27);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(150, 26);
			this.textBoxIP.TabIndex = 0;
			this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.Location = new System.Drawing.Point(9, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "IP";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label2.Location = new System.Drawing.Point(9, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Netmask";
			// 
			// textBoxNetmask
			// 
			this.textBoxNetmask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxNetmask.Location = new System.Drawing.Point(148, 59);
			this.textBoxNetmask.Name = "textBoxNetmask";
			this.textBoxNetmask.Size = new System.Drawing.Size(150, 26);
			this.textBoxNetmask.TabIndex = 1;
			this.textBoxNetmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxNetprefix
			// 
			this.textBoxNetprefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxNetprefix.Location = new System.Drawing.Point(148, 123);
			this.textBoxNetprefix.Name = "textBoxNetprefix";
			this.textBoxNetprefix.ReadOnly = true;
			this.textBoxNetprefix.Size = new System.Drawing.Size(150, 26);
			this.textBoxNetprefix.TabIndex = 5;
			this.textBoxNetprefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label4.Location = new System.Drawing.Point(9, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Net Prefix";
			// 
			// textBoxBroadcast
			// 
			this.textBoxBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxBroadcast.Location = new System.Drawing.Point(148, 159);
			this.textBoxBroadcast.Name = "textBoxBroadcast";
			this.textBoxBroadcast.ReadOnly = true;
			this.textBoxBroadcast.Size = new System.Drawing.Size(150, 26);
			this.textBoxBroadcast.TabIndex = 6;
			this.textBoxBroadcast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label5.Location = new System.Drawing.Point(9, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 27);
			this.label5.TabIndex = 9;
			this.label5.Text = "Net Broadcast";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label3.Location = new System.Drawing.Point(9, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 27);
			this.label3.TabIndex = 17;
			this.label3.Text = "Netmask Length";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label6.Location = new System.Drawing.Point(9, 192);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 24);
			this.label6.TabIndex = 16;
			this.label6.Text = "Network capacity";
			// 
			// textBoxNetmaskLength
			// 
			this.textBoxNetmaskLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxNetmaskLength.Location = new System.Drawing.Point(148, 91);
			this.textBoxNetmaskLength.Name = "textBoxNetmaskLength";
			this.textBoxNetmaskLength.ReadOnly = true;
			this.textBoxNetmaskLength.Size = new System.Drawing.Size(150, 26);
			this.textBoxNetmaskLength.TabIndex = 2;
			this.textBoxNetmaskLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxNetCapacity
			// 
			this.textBoxNetCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxNetCapacity.Location = new System.Drawing.Point(148, 190);
			this.textBoxNetCapacity.Name = "textBoxNetCapacity";
			this.textBoxNetCapacity.ReadOnly = true;
			this.textBoxNetCapacity.Size = new System.Drawing.Size(150, 26);
			this.textBoxNetCapacity.TabIndex = 7;
			this.textBoxNetCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label7.Location = new System.Drawing.Point(9, 258);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 24);
			this.label7.TabIndex = 13;
			this.label7.Text = "Highet Host IP";
			// 
			// textBoxHihostIP
			// 
			this.textBoxHihostIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxHihostIP.Location = new System.Drawing.Point(148, 256);
			this.textBoxHihostIP.Name = "textBoxHihostIP";
			this.textBoxHihostIP.ReadOnly = true;
			this.textBoxHihostIP.Size = new System.Drawing.Size(150, 26);
			this.textBoxHihostIP.TabIndex = 9;
			this.textBoxHihostIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label8.Location = new System.Drawing.Point(9, 227);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Lowest Host IP";
			// 
			// textBoxLowHostIP
			// 
			this.textBoxLowHostIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxLowHostIP.Location = new System.Drawing.Point(148, 224);
			this.textBoxLowHostIP.Name = "textBoxLowHostIP";
			this.textBoxLowHostIP.ReadOnly = true;
			this.textBoxLowHostIP.Size = new System.Drawing.Size(150, 26);
			this.textBoxLowHostIP.TabIndex = 8;
			this.textBoxLowHostIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// radioButtonNetmask
			// 
			this.radioButtonNetmask.Checked = true;
			this.radioButtonNetmask.Location = new System.Drawing.Point(304, 59);
			this.radioButtonNetmask.Name = "radioButtonNetmask";
			this.radioButtonNetmask.Size = new System.Drawing.Size(20, 24);
			this.radioButtonNetmask.TabIndex = 3;
			this.radioButtonNetmask.TabStop = true;
			this.radioButtonNetmask.UseVisualStyleBackColor = true;
			this.radioButtonNetmask.CheckedChanged += new System.EventHandler(this.RadioButtonNetmaskCheckedChanged);
			// 
			// radioButtonNetmaskLength
			// 
			this.radioButtonNetmaskLength.Location = new System.Drawing.Point(304, 91);
			this.radioButtonNetmaskLength.Name = "radioButtonNetmaskLength";
			this.radioButtonNetmaskLength.Size = new System.Drawing.Size(20, 24);
			this.radioButtonNetmaskLength.TabIndex = 4;
			this.radioButtonNetmaskLength.UseVisualStyleBackColor = true;
			this.radioButtonNetmaskLength.CheckedChanged += new System.EventHandler(this.RadioButtonNetmaskLengthCheckedChanged);
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.buttonCalculate.Location = new System.Drawing.Point(80, 296);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(162, 34);
			this.buttonCalculate.TabIndex = 10;
			this.buttonCalculate.Text = "Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
			// 
			// menuStripTop
			// 
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(325, 24);
			this.menuStripTop.TabIndex = 21;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveToolStripMenuItem,
									this.copyAllToolStripMenuItem,
									this.clearAllToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// copyAllToolStripMenuItem
			// 
			this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
			this.copyAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.copyAllToolStripMenuItem.Text = "&Copy All to Clipboard";
			this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.CopyAllToolStripMenuItemClick);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.clearAllToolStripMenuItem.Text = "Clea&r All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 342);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.radioButtonNetmaskLength);
			this.Controls.Add(this.radioButtonNetmask);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxNetmaskLength);
			this.Controls.Add(this.textBoxNetCapacity);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxHihostIP);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxLowHostIP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxBroadcast);
			this.Controls.Add(this.textBoxNetprefix);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNetmask);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxIP);
			this.Controls.Add(this.menuStripTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripTop;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SubnetCalculator";
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.TextBox textBoxIP;
		private System.Windows.Forms.TextBox textBoxNetmask;
		private System.Windows.Forms.TextBox textBoxNetprefix;
		private System.Windows.Forms.TextBox textBoxBroadcast;
		private System.Windows.Forms.TextBox textBoxNetmaskLength;
		private System.Windows.Forms.TextBox textBoxNetCapacity;
		private System.Windows.Forms.TextBox textBoxHihostIP;
		private System.Windows.Forms.TextBox textBoxLowHostIP;
		private System.Windows.Forms.RadioButton radioButtonNetmask;
		private System.Windows.Forms.RadioButton radioButtonNetmaskLength;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		

	}
}
