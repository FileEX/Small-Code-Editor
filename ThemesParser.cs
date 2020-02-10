/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 07.06.2019
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace MTA_Code_Editor
{	
	public class ThemesParser
	{
		public ThemesParser()
		{
		}
		
		public string theme = "Default_Light";
		private List<string> data;
		
		public void LoadTheme(string name)
		{
			//data.Clear();
			
			string path = Application.StartupPath + "\\Data\\Themes\\" + name + "\\Theme-" + name + ".xml";
			if (File.Exists(path))
			{
				XDocument themeData = XDocument.Load(path);
				XElement themeSettings = themeData.Root;
				XNamespace ns = themeSettings.GetDefaultNamespace();
				
				theme = themeSettings.Element("themeData").Attribute("name").Value.ToString();
				
				var bgRoot = themeSettings.Element("themeData").Element("backgrounds");
				var fgRoot = themeSettings.Element("themeData").Element("colors");
				
				var result = new List<string>() {
					bgRoot.Element("editorBackground").Value.Replace("#","0x"),
					bgRoot.Element("windowBackground").Value.Replace("#","0x"),
					
					fgRoot.Element("textColor").Value.Replace("#", "0x"),
					fgRoot.Element("digitsColor").Value.Replace("#","0x"),
				};
								
				data = result;
				
				// Clear Memory
				themeData = null;
				themeSettings = null;
				ns = null;
				bgRoot = null;
				fgRoot = null;
				
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
			else
			{
				// Load default theme
				DialogResult result = MessageBox.Show("\u0027 Theme" + path + "\u0027" + "doesn't exist. The default theme has been loaded.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.OK)
				{
					LoadTheme("Default_Light");
				}
				else if (result == DialogResult.Cancel) // Default theme also doesn't exist.
				{
					Application.Exit();
				}
			}
		}
		
		public List<string> GetData()
		{
			return data;
		}
	}
}
