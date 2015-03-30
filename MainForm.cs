/*
 * Copyright (c) 2012 - Petros Kyladitis
 * This file is part of SubnetCalculator project, and is distributed under the FreeBSD License.
 * Please see license.txt for the FreeBSD License in its entire length
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Multipetros ;

namespace SubnetCalculator{
	public partial class MainForm : Form{
		public MainForm(){
			InitializeComponent();
		}
		
		void RadioButtonNetmaskCheckedChanged(object sender, System.EventArgs e){
			textBoxNetmask.ReadOnly = ! radioButtonNetmask.Checked ;
			textBoxNetmaskLength.ReadOnly = ! radioButtonNetmaskLength.Checked ;
		}
		
		void RadioButtonNetmaskLengthCheckedChanged(object sender, System.EventArgs e){
			textBoxNetmask.ReadOnly = ! radioButtonNetmask.Checked ;
			textBoxNetmaskLength.ReadOnly = ! radioButtonNetmaskLength.Checked ;
		}
		
		void DoCalcs(string ip, string netmask){
			SubnettingCalcs subCalc ;
			try{
				subCalc = new SubnettingCalcs(ip, netmask) ;				
				WriteValues(subCalc) ;
			}catch(Exception exc){
				WriteErrorValues() ;
			}
		}
		
		void DoCalcs(string ip, byte netmask){
			SubnettingCalcs subCalc ;
			try{
				subCalc = new SubnettingCalcs(ip, netmask) ;
				WriteValues(subCalc) ;
			}catch(Exception exc){
				WriteErrorValues() ;
			}
		}
		
		void WriteValues(SubnettingCalcs subCalc){
			if(textBoxNetmask.ReadOnly)
				textBoxNetmask.Text = subCalc.Netmask ;
			else
				textBoxNetmaskLength.Text = subCalc.NetmaskLength.ToString() ;
			textBoxNetprefix.Text = subCalc.Netprefix ;
			textBoxBroadcast.Text = subCalc.Broadcast ;
			textBoxLowHostIP.Text = subCalc.LowHostIp ;
			textBoxHihostIP.Text = subCalc.HiHostIp ;
			textBoxNetCapacity.Text = subCalc.NetCapacity.ToString() ;
		}
		
		void WriteErrorValues(){
			string errorMsg = "Error" ;
			if(textBoxNetmask.ReadOnly)
				textBoxNetmask.Text = errorMsg ;
			else
				textBoxNetmaskLength.Text = errorMsg ;
			textBoxNetprefix.Text = errorMsg ;
			textBoxBroadcast.Text = errorMsg ;
			textBoxLowHostIP.Text = errorMsg ;
			textBoxHihostIP.Text = errorMsg ;
			textBoxNetCapacity.Text = errorMsg ;			
		}
		
		void ClearValues(){
			textBoxIP.Text = "" ;
			textBoxNetmask.Text = "" ;
			textBoxNetmaskLength.Text = "" ;
			textBoxNetprefix.Text = "" ;
			textBoxBroadcast.Text = "" ;
			textBoxLowHostIP.Text = "" ;
			textBoxHihostIP.Text = "" ;
			textBoxNetCapacity.Text = "" ;				
		}
		
		string GetAllValues(){
			string allValues =  "IP..............: " + textBoxIP.Text + 
								"\r\nNetmask.........: " + textBoxNetmask.Text + 
								"\r\nNetmask length..: " + textBoxNetmaskLength.Text + 
								"\r\nNetwork Prefix..: " + textBoxNetprefix.Text +
								"\r\nBroadcast.......: " + textBoxBroadcast.Text + 				 
								"\r\nNetwork Capacity: " + textBoxNetCapacity.Text + 
								"\r\nLowest Host IP..: " + textBoxLowHostIP.Text + 
								"\r\nHighest Host IP.: " + textBoxHihostIP.Text ;
			return allValues ;
		}
		
		void SaveToFile(){
			SaveFileDialog saveDial = new SaveFileDialog() ;
			saveDial.Filter = "Text file|*.txt|Other file|*.*" ;
			saveDial.Title = "Save values to..." ;
			saveDial.ShowDialog(this) ;
			if(saveDial.FileName != ""){
				try{
					System.IO.File.WriteAllText(saveDial.FileName, GetAllValues()) ;
				}catch(Exception exc){
					MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				}
			}
		}
		
		void ButtonCalculateClick(object sender, EventArgs e){
			if(radioButtonNetmask.Checked)
				DoCalcs(textBoxIP.Text, textBoxNetmask.Text) ;
			else{
				byte netLen ;
				Byte.TryParse(textBoxNetmaskLength.Text, out netLen) ;
				DoCalcs(textBoxIP.Text, netLen) ;
			}
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			Form about = new AboutForm() ;
			DialogResult result = about.ShowDialog() ;
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void ClearAllToolStripMenuItemClick(object sender, EventArgs e){
			ClearValues() ;
		}
		
		void CopyAllToolStripMenuItemClick(object sender, EventArgs e){
			Clipboard.SetText(GetAllValues()) ;
		}
		
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e){
			SaveToFile() ;
		}
	}
}
