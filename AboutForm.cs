/*
 * Copyright (c) 2012 - Petros Kyladitis
 * This file is part of SubnetCalculator project, and is distributed under the FreeBSD License.
 * Please see license.txt for the FreeBSD License in its entire length
 */
 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SubnetCalculator{
	public partial class AboutForm : Form{
		public AboutForm(){
			InitializeComponent();
		}
		
		void ButtonOKClick(object sender, EventArgs e){
			this.DialogResult = DialogResult.OK ;
		}
	}
}
