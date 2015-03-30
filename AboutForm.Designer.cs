/*
 * Copyright (c) 2012 - Petros Kyladitis
 * This file is part of SubnetCalculator project, and is distributed under the FreeBSD License.
 * Please see license.txt for the FreeBSD License in its entire length
 */
 
namespace SubnetCalculator
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelCredits = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
			this.labelAbout = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxLiscense = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(11, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(429, 1);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// labelCredits
			// 
			this.labelCredits.Location = new System.Drawing.Point(114, 70);
			this.labelCredits.Name = "labelCredits";
			this.labelCredits.Size = new System.Drawing.Size(329, 41);
			this.labelCredits.TabIndex = 11;
			this.labelCredits.Text = "Uses Multipetros.SubnettingCalcs library to perform calculations\r\nIcon art by Oxy" +
			"gen Team  <http://www.oxygen-icons.org/>";
			this.labelCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelInfo
			// 
			this.labelInfo.Location = new System.Drawing.Point(13, 129);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(430, 41);
			this.labelInfo.TabIndex = 10;
			this.labelInfo.Text = "This subnetting calculator provide info about network hosts capacity, netmask len" +
			"gth, netmask, network prefix, lowest (first) host IP, highest (last) host IP && " +
			"broadcast address.";
			// 
			// labelAbout
			// 
			this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelAbout.Location = new System.Drawing.Point(115, 12);
			this.labelAbout.Name = "labelAbout";
			this.labelAbout.Size = new System.Drawing.Size(328, 58);
			this.labelAbout.TabIndex = 9;
			this.labelAbout.Text = "SubnetCalculator - Version 1.0\r\nA simple subnetting calculator\r\nCopyright (c) 201" +
			"2, Petros Kyladitis";
			this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(9, 343);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(428, 1);
			this.label2.TabIndex = 14;
			this.label2.Text = "label2";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(341, 356);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(96, 34);
			this.buttonOK.TabIndex = 13;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// textBoxLiscense
			// 
			this.textBoxLiscense.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxLiscense.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLiscense.Location = new System.Drawing.Point(13, 177);
			this.textBoxLiscense.Multiline = true;
			this.textBoxLiscense.Name = "textBoxLiscense";
			this.textBoxLiscense.ReadOnly = true;
			this.textBoxLiscense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLiscense.Size = new System.Drawing.Size(424, 153);
			this.textBoxLiscense.TabIndex = 12;
			this.textBoxLiscense.TabStop = false;
			this.textBoxLiscense.Text = resources.GetString("textBoxLiscense.Text");
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 400);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBoxLiscense);
			this.Controls.Add(this.labelCredits);
			this.Controls.Add(this.labelInfo);
			this.Controls.Add(this.labelAbout);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "About SubnetCalculator";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBoxLiscense;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAbout;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.Label labelCredits;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
