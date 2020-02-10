/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 07.06.2019
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using System.Timers;
using System.Text;
using MoonSharp.Interpreter;

namespace MTA_Code_Editor
{	
	public partial class MainForm : Form
	{
		ThemesParser themeLoader = new ThemesParser();
		Settings settingsManager = new Settings();
		LanguageManager lanManager = new LanguageManager();
		ListView listView1;
		
		OrderedDictionary tabsData = new OrderedDictionary();
		
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
				var textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
				textEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
				
				Color ebgClr = ConvertColor(data[0]);
				Color edgClr = ConvertColor(data[3]);
				
				var bgColor = new HighlightColor(Color.Black, ebgClr, false, false);
				var dgColor = new HighlightColor(Color.Black, edgClr, false, false);
				
				var highlightingStrategy = textEditor.Document.HighlightingStrategy as DefaultHighlightingStrategy;
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
				var textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
				textEditor.SetHighlighting("Lua_" + theme);
			}
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			string theme = settingsManager.getSettingValue("Theme");
			
			ApplySyntax();
			
			themeLoader.LoadTheme(theme);
			
			InitalizeTheme(themeLoader.GetData());
			
			string ln = settingsManager.getSettingValue("language");
			lanManager.setLanguage(ln);
					
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
				var textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
			
				int col = textEditor.ActiveTextAreaControl.Caret.Column;
				int line = textEditor.ActiveTextAreaControl.Caret.Line + 1;
				
				editInfo.Text = "Line: " + line + "      Column: " + col;
			}
		}
		
		private void setPageData(int page, string data)
		{
			if (tabsData.Contains(page)) {
				tabsData[page] = data;
			} else {
				tabsData.Add(page, data);
			}
		}
		
		private void addNewTab(string name)
		{
			var page = new TabPage(Path.GetFileName(name));
			tabControl1.TabPages.Add(page);
					
			var textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();

			textEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
					
			page.Controls.Add(textEditorControl1);
					
			textEditorControl1.Size = new Size(new Point(tabControl1.Size.Width - 6, 339 - 24));
				
			ApplySyntax(ref textEditorControl1);
			InitalizeTheme(themeLoader.GetData());
					
			textEditorControl1.Refresh();
			
			// Console
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
					
			listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
				
			page.Controls.Add(listView1);
			
			tabControl1.SelectedTab = page;
			
			setPageData(tabControl1.SelectedTab.TabIndex, name);
		}
		
		//File
		private void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			var newFile = new SaveFileDialog();
			newFile.Filter = "LUA (*.lua)|*.lua|XML (*.xml)|*.xml|FX (*.fx)|*.fx|All Files (*.*)|*.*";
			newFile.FileName = "Untitled";
			
			if (newFile.ShowDialog() == DialogResult.OK)
			{
				Stream fileStream;
				
				if ((fileStream = newFile.OpenFile()) != null)
				{
					fileStream.Close();
					fileStream.Dispose();
					
					addNewTab(newFile.FileName);
				}
			}
		}
		
		private void saveFileWithEncoding(Encoding encoding)
		{
			if (tabControl1.TabPages.Count > 0)
			{
				int i = tabControl1.SelectedTab.TabIndex;
				
				File.WriteAllText(tabsData[i].ToString(), tabControl1.TabPages[i].Controls[0].Text, encoding);
				
				MessageBox.Show("Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		private void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			var file = new OpenFileDialog();
			file.Filter = "LUA (*.lua)|*.lua|XML (*.xml)|*.xml|FX (*.fx)|*.fx|All Files (*.*)|*.*";
			
			if (file.ShowDialog() == DialogResult.OK)
			{
				var stream = new FileStream(file.FileName, FileMode.Open, FileAccess.ReadWrite);
				var reader = new StreamReader(stream);
				
				addNewTab(file.FileName);
				
				int i = tabControl1.SelectedTab.TabIndex;
				
				tabControl1.TabPages[i].Controls[0].Text = reader.ReadToEnd();
				
				stream.Close();
				stream.Dispose();
				reader.Close();
				reader.Dispose();
			}
		}
		
		// Encodings
		private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.Default);
		}
		
		private void ANSIIToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.Default);
		}
		
		private void UTF8ToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.UTF8);
		}
		
		private void UTF8WithBOMToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding((Encoding) new UTF8Encoding(false));
		}
		
		private void UnicodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.Unicode);
		}
		
		private void BigIndianUnicodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.BigEndianUnicode);
		}
		
		private void UTF32ToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.UTF32);
		}
		
		private void UTF7ToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileWithEncoding(Encoding.UTF7);
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
		
		private void Base64DecodeToolStripMenuItemClick(object sender, EventArgs e)
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
				string[] arr = new String[3];
				
				var debugger = (ListView)tabControl1.TabPages[i].Controls[1];
				ListViewItem item;
				
				try
				{
					var buff = new Script();
					buff.Options.UseLuaErrorLocations = true;
					
					buff.DoString(tabControl1.TabPages[i].Controls[0].Text);
					
					arr[0] = "";
					arr[1] = "Script executed succesfully!";
					arr[2] = "";
					
					item = new ListViewItem(arr);
					debugger.Items.Add(item);
					
					return;
				}
				catch (Exception ex)
				{
					if (ex is ScriptRuntimeException || ex is SyntaxErrorException)
					{
						var scp = ex as ScriptRuntimeException;
						var excp = ex as SyntaxErrorException;
						
						String decMsg;
						
						if (scp != null) {
							decMsg = scp.DecoratedMessage;
						} else if (excp != null) {
							decMsg = excp.DecoratedMessage;
						} else {
							throw;
						}
						
						var msg = System.Text.RegularExpressions.Regex.Match(decMsg, "\\b(\\d+)\\b");
						
						arr[0] = (debugger.Items.Count + 1).ToString();
						arr[1] = ex.Message;
						arr[2] = msg.ToString();
						
						item = new ListViewItem(arr);
						debugger.Items.Add(item);
						
						return;
					}
					
					throw;
				}
			}
		}
		
		//View
		private void TextFromLeftToRightToolStripMenuItemClick(object sender, EventArgs e)
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
		
		private void ShowTabsSpacesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0) {
				string tabs = settingsManager.getSettingValue("tabsSpaces");
				int i = tabControl1.SelectedTab.TabIndex;
				var textEditor = (ICSharpCode.TextEditor.TextEditorControl)tabControl1.TabPages[i].Controls[0];
				
				textEditor.ShowTabs = tabs == "hide" ? true : false;
				textEditor.ShowSpaces = tabs == "hide" ? true : false;
				
				this.showTabsSpacesToolStripMenuItem.Checked = tabs == "hide";
				
				settingsManager.setSettingValue("tabsSpaces", tabs == "hide" ? "show" : "hide");
			}
		}
		
		private void FullScreenToolStripMenuItemClick(object sender, EventArgs e)
		{
			string fScreen = settingsManager.getSettingValue("fullscreen");
			
			this.FormBorderStyle = (fScreen == "yes" ? FormBorderStyle.Sizable : FormBorderStyle.None);
			this.WindowState = (fScreen == "yes" ? FormWindowState.Normal : FormWindowState.Maximized);
			
			this.fullScreenToolStripMenuItem.Checked = fScreen == "no";
			
			settingsManager.setSettingValue("fullscreen", fScreen == "yes" ? "no" : "yes");
		}
		
		//Edit
		private void FullPathToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0) {
				int i = tabControl1.SelectedTab.TabIndex;
				
				Clipboard.SetText(tabsData[i].ToString());
				
				MessageBox.Show("Copioed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		private void NameOfFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0) {
				int i = tabControl1.SelectedTab.TabIndex;
				
				Clipboard.SetText(Path.GetFileName(tabsData[i].ToString()));
				
				MessageBox.Show("Copioed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		private void DirectoryNameOfFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.TabPages.Count > 0) {
				int i = tabControl1.SelectedTab.TabIndex;
				
				Clipboard.SetText(Path.GetDirectoryName(tabsData[i].ToString()));
				
				MessageBox.Show("Copioed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
