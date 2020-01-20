/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 07.06.2019
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace MTA_Code_Editor
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			
			// Init classes
			new ThemesParser();
			new Settings();
		}
		
	}
}
