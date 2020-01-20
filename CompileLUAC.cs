/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 10.06.2019
 * Time: 16:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MTA_Code_Editor
{
	/// <summary>
	/// Description of CompileLUAC.
	/// </summary>
	public partial class CompileLUAC : Form
	{
		FolderBrowserDialog savePath = new FolderBrowserDialog();
		
		public CompileLUAC()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (savePath.ShowDialog() == DialogResult.OK)
			{
				savePath.RootFolder = Environment.SpecialFolder.Desktop;
				savePath.Description = "Select path to save luac file";
				
				textBox1.Text = savePath.SelectedPath;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked || radioButton2.Checked)
			{
				if (textBox1.Text.Length > 0)
				{
					string level = radioButton1.Checked ? "e1" : "e2";
					
					string path = System.AppDomain.CurrentDomain.BaseDirectory + @"\templuac.cmd";
					FileInfo tempFile = new FileInfo(path);
					
					string curName = "\\dupa";
					string curPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\fujara.lua";
					
					using (StreamWriter strW = tempFile.CreateText())
					{
						strW.WriteLine("luac_mta.exe -" + level + " -o \"" + textBox1.Text + curName + ".luac\" \"" + curPath + "\"");
					}
					
					Process.Start(path);
					
					System.Threading.Thread.Sleep(1000);
					tempFile.Delete();
				}
			}
		}
	}
}
