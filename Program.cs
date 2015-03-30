/*
 * Copyright (c) 2012 - Petros Kyladitis
 * This file is part of SubnetCalculator project, and is distributed under the FreeBSD License.
 * Please see license.txt for the FreeBSD License in its entire length
 */
 
using System;
using System.Windows.Forms;

namespace SubnetCalculator{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
