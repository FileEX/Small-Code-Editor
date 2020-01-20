/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 07.06.2019
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using System.Timers;
using MoonSharp.Interpreter;

namespace MTA_Code_Editor
{	
	public partial class MainForm : Form
	{
		ThemesParser themeLoader = new ThemesParser();
		Settings settingsManager = new Settings();
		ListView listView1;
		
		public MainForm()
		{
			InitializeComponent();
		
			string str = Application.StartupPath + "\\Data\\Themes\\" + themeLoader.theme + "\\Syntax";
				if (!Directory.Exists(str))
					return;
				HighlightingManager.Manager.AddSyntaxModeFileProvider(new FileSyntaxModeProvider(str));
		}
		
		private void InitalizeTheme(List<string> data)
		{	
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				ICSharpCode.TextEditor.TextEditorControl textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
				
				Color ebgClr = ConvertColor(data[0]);
				Color edgClr = ConvertColor(data[3]);
				
				HighlightColor bgColor = new HighlightColor(Color.Black, ebgClr, false, false);
				HighlightColor dgColor = new HighlightColor(Color.Black, edgClr, false, false);
				
				DefaultHighlightingStrategy highlightingStrategy = textEditor.Document.HighlightingStrategy as DefaultHighlightingStrategy;
				highlightingStrategy.SetColorFor("Default", bgColor);
				highlightingStrategy.SetColorFor("Digits", dgColor);
				
				textEditor.Refresh();
			}
			
			this.BackColor = ConvertColor(data[1]);
		}
		
		private void ApplySyntax(ref ICSharpCode.TextEditor.TextEditorControl editorSource)
		{
			string theme = settingsManager.getSettingValue("Theme");
			
			if (tabControl1.TabPages.Count > 0)
			{
				editorSource.SetHighlighting("Lua_" + theme);
			}
		}
		
		private void ApplySyntax()
		{
			string theme = settingsManager.getSettingValue("Theme");
			
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				ICSharpCode.TextEditor.TextEditorControl textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
				textEditor.SetHighlighting("Lua_" + theme);
			}
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			string theme = settingsManager.getSettingValue("Theme");
			
			ApplySyntax();
			
			themeLoader.LoadTheme(theme);
			
			InitalizeTheme(themeLoader.GetData());
					
			// Install timer
			var updTimer = new System.Timers.Timer(550);
			updTimer.Enabled = true;
			updTimer.AutoReset = true;
			updTimer.Elapsed += OnTimeEvent;
		}
		
		private Color ConvertColor(string color)
		{
			Color temp = Color.FromArgb((int)Convert.ToInt32(color, 16));
			Color final = Color.FromArgb(temp.R, temp.G, temp.B);
			
			return final;
		}
		
		private bool isOpened(string name)
		{
			FormCollection formColl = Application.OpenForms;
			
			foreach(Form itForm in formColl)
			{
				if (itForm.Text == name)
				{
					return true;
				}
			}
			return false;
		}
		
		private void OnTimeEvent(Object sender, ElapsedEventArgs e)
		{
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				ICSharpCode.TextEditor.TextEditorControl textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
			
				int col = textEditor.ActiveTextAreaControl.Caret.Column;
				int line = textEditor.ActiveTextAreaControl.Caret.Line + 1;
				
				editInfo.Text = "Line: " + line + "      Column: " + col;
			}
		}
		
		//File
		private void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog newFile = new SaveFileDialog();
			newFile.Filter = "LUA (*.lua)|*.lua|XML (*.xml)|*.xml|FX (*.fx)|*.fx|All Files (*.*)|*.*";
			newFile.FileName = "Untitled";
			
			if (newFile.ShowDialog() == DialogResult.OK)
			{
				Stream fileStream;
				
				if ((fileStream = newFile.OpenFile()) != null)
				{
					fileStream.Close();
					
					TabPage page = new TabPage(Path.GetFileName(newFile.FileName));
					tabControl1.TabPages.Add(page);
					
					ICSharpCode.TextEditor.TextEditorControl textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
					//textEditorControl1.Dock = DockStyle.Fill;
					
					page.Controls.Add(textEditorControl1);
					
					textEditorControl1.Size = new Size(new Point(tabControl1.Size.Width - 6, 339 - 24));
				
					ApplySyntax(ref textEditorControl1);
					InitalizeTheme(themeLoader.GetData());
					
					textEditorControl1.Refresh();
					
					listView1 = new ListView();
					
					listView1.Location = new Point(0, 320);
					listView1.Name = "listView1";
					listView1.Size = new Size(785, 100);
					listView1.TabIndex = 7;
					listView1.UseCompatibleStateImageBehavior = false;
					
					listView1.View = View.Details;
					listView1.GridLines = true;
					listView1.FullRowSelect = true;
			
					listView1.Columns.Add("#",20);
					listView1.Columns.Add("Value", 450, HorizontalAlignment.Center);
					listView1.Columns.Add("Line", 280, HorizontalAlignment.Center);
				
					page.Controls.Add(listView1);
				}
			}
		}
		
		//Tools
		private void Base64EncodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				tabControl1.TabPages[i].Controls[0].Text = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(tabControl1.TabPages[i].Controls[0].Text));
			}
		}
		
		void Base64DecodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				tabControl1.TabPages[i].Controls[0].Text = System.Text.Encoding.Default.GetString(Convert.FromBase64String(tabControl1.TabPages[i].Controls[0].Text));
			}
		}
		
		private void CompileToLUACToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (!isOpened("CompileLUAC") && tabControl1.TabPages.Count > 0)
			{
				new CompileLUAC().Show(this);
			}
		}

		// Run
		void RunLUACodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				
				try
				{
					Script buff = new Script();
					buff.Options.UseLuaErrorLocations = true;
					
					DynValue result = buff.DoString(tabControl1.TabPages[i].Controls[0].Text);
				}
				catch (ScriptRuntimeException ex)
				{
					var msg = System.Text.RegularExpressions.Regex.Match(ex.DecoratedMessage, "\\b(\\d+)\\b");
					
					string[] arr = new String[3];
					ListViewItem item;

					ListView debugger = (ListView)tabControl1.TabPages[i].Controls[1];
					
					arr[0] = (debugger.Items.Count + 1).ToString();
					arr[1] = ex.Message;
					arr[2] = msg.ToString();
					
					item = new ListViewItem(arr);
					debugger.Items.Add(item);
				}
			}
		}
		
		void TextFromLeftToRightToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0) {
				string direction = settingsManager.getSettingValue("textDirection");
				int i = tabControl1.SelectedTab.TabIndex;
				
				if (direction == "lToR") {
					tabControl1.TabPages[i].Controls[0].RightToLeft = RightToLeft;
				} else {
					tabControl1.TabPages[i].Controls[0].ResetRightToLeft();
				}
			}
		}
		
		void ShowTabsSpacesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0) {
				string tabs = settingsManager.getSettingValue("tabsSpaces");
				int i = tabControl1.SelectedTab.TabIndex;
				ICSharpCode.TextEditor.TextEditorControl textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
				
				textEditor.ShowTabs = tabs == "hide" ? true : false;
				textEditor.ShowSpaces = tabs == "hide" ? true : false;
			}
		}
	}
}
