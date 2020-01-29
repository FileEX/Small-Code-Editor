/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 07.06.2019
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MTA_Code_Editor
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveWithEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uTF8WithBOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cłoseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fullPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nameOfFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.directoryNameOfFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.goToLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showTabsSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textFromLeftToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.syntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lUAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hLSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runLUACodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.base64EncodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.base64DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compileToLUACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMTACodeEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.editInfo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.searchToolStripMenuItem,
			this.viewToolStripMenuItem,
			this.syntaxToolStripMenuItem,
			this.runToolStripMenuItem,
			this.toolsToolStripMenuItem,
			this.settingsToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(519, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.newToolStripMenuItem,
			this.saveToolStripMenuItem,
			this.saveAsToolStripMenuItem,
			this.saveWithEncodingToolStripMenuItem,
			this.printToolStripMenuItem,
			this.closeToolStripMenuItem,
			this.closeToolStripMenuItem1,
			this.cłoseAllToolStripMenuItem,
			this.closeAllButThisToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.openToolStripMenuItem.Text = "New File...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.newToolStripMenuItem.Text = "Open File...";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.saveToolStripMenuItem.Text = "Open Folder...";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.saveAsToolStripMenuItem.Text = "Save";
			// 
			// saveWithEncodingToolStripMenuItem
			// 
			this.saveWithEncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.uTF8ToolStripMenuItem,
			this.uTF8WithBOMToolStripMenuItem});
			this.saveWithEncodingToolStripMenuItem.Name = "saveWithEncodingToolStripMenuItem";
			this.saveWithEncodingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.saveWithEncodingToolStripMenuItem.Text = "Save With Encoding";
			// 
			// uTF8ToolStripMenuItem
			// 
			this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
			this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.uTF8ToolStripMenuItem.Text = "UTF-8";
			// 
			// uTF8WithBOMToolStripMenuItem
			// 
			this.uTF8WithBOMToolStripMenuItem.Name = "uTF8WithBOMToolStripMenuItem";
			this.uTF8WithBOMToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.uTF8WithBOMToolStripMenuItem.Text = "UTF-8 with BOM";
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.printToolStripMenuItem.Text = "Save As";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.closeToolStripMenuItem.Text = "Save All";
			// 
			// closeToolStripMenuItem1
			// 
			this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
			this.closeToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
			this.closeToolStripMenuItem1.Text = "Close";
			// 
			// cłoseAllToolStripMenuItem
			// 
			this.cłoseAllToolStripMenuItem.Name = "cłoseAllToolStripMenuItem";
			this.cłoseAllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.cłoseAllToolStripMenuItem.Text = "Cłose All";
			// 
			// closeAllButThisToolStripMenuItem
			// 
			this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
			this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.closeAllButThisToolStripMenuItem.Text = "Close All But This";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.undoToolStripMenuItem,
			this.redoToolStripMenuItem,
			this.cutToolStripMenuItem,
			this.copyToolStripMenuItem,
			this.pasteToolStripMenuItem,
			this.copyToClipboardToolStripMenuItem,
			this.indentToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.redoToolStripMenuItem.Text = "Redo";
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fullPathToolStripMenuItem,
			this.nameOfFileToolStripMenuItem,
			this.directoryNameOfFileToolStripMenuItem});
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
			// 
			// fullPathToolStripMenuItem
			// 
			this.fullPathToolStripMenuItem.Name = "fullPathToolStripMenuItem";
			this.fullPathToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.fullPathToolStripMenuItem.Text = "Full path of file";
			// 
			// nameOfFileToolStripMenuItem
			// 
			this.nameOfFileToolStripMenuItem.Name = "nameOfFileToolStripMenuItem";
			this.nameOfFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.nameOfFileToolStripMenuItem.Text = "Name of file";
			// 
			// directoryNameOfFileToolStripMenuItem
			// 
			this.directoryNameOfFileToolStripMenuItem.Name = "directoryNameOfFileToolStripMenuItem";
			this.directoryNameOfFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.directoryNameOfFileToolStripMenuItem.Text = "Directory name of file";
			// 
			// indentToolStripMenuItem
			// 
			this.indentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.insertIndentToolStripMenuItem});
			this.indentToolStripMenuItem.Name = "indentToolStripMenuItem";
			this.indentToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.indentToolStripMenuItem.Text = "Indent";
			// 
			// insertIndentToolStripMenuItem
			// 
			this.insertIndentToolStripMenuItem.Name = "insertIndentToolStripMenuItem";
			this.insertIndentToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.insertIndentToolStripMenuItem.Text = "Insert indent";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.findToolStripMenuItem,
			this.findNextToolStripMenuItem,
			this.goToLineToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.searchToolStripMenuItem.Text = "Search";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.findToolStripMenuItem.Text = "Find";
			// 
			// findNextToolStripMenuItem
			// 
			this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
			this.findNextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.findNextToolStripMenuItem.Text = "Find Next";
			// 
			// goToLineToolStripMenuItem
			// 
			this.goToLineToolStripMenuItem.Name = "goToLineToolStripMenuItem";
			this.goToLineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.goToLineToolStripMenuItem.Text = "Go to line";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fullScreenToolStripMenuItem,
			this.themeToolStripMenuItem,
			this.fontToolStripMenuItem,
			this.showTabsSpacesToolStripMenuItem,
			this.textFromLeftToRightToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// fullScreenToolStripMenuItem
			// 
			this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
			this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.fullScreenToolStripMenuItem.Text = "FullScreen";
			this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.FullScreenToolStripMenuItemClick);
			// 
			// themeToolStripMenuItem
			// 
			this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
			this.themeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.themeToolStripMenuItem.Text = "Theme";
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.fontToolStripMenuItem.Text = "Font";
			// 
			// showTabsSpacesToolStripMenuItem
			// 
			this.showTabsSpacesToolStripMenuItem.Name = "showTabsSpacesToolStripMenuItem";
			this.showTabsSpacesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.showTabsSpacesToolStripMenuItem.Text = "Show Tabs/Spaces";
			this.showTabsSpacesToolStripMenuItem.Click += new System.EventHandler(this.ShowTabsSpacesToolStripMenuItemClick);
			// 
			// textFromLeftToRightToolStripMenuItem
			// 
			this.textFromLeftToRightToolStripMenuItem.Name = "textFromLeftToRightToolStripMenuItem";
			this.textFromLeftToRightToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.textFromLeftToRightToolStripMenuItem.Text = "Text From Left To Right";
			this.textFromLeftToRightToolStripMenuItem.Click += new System.EventHandler(this.TextFromLeftToRightToolStripMenuItemClick);
			// 
			// syntaxToolStripMenuItem
			// 
			this.syntaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lUAToolStripMenuItem,
			this.hTMLToolStripMenuItem,
			this.cSSToolStripMenuItem,
			this.javaScriptToolStripMenuItem,
			this.hLSLToolStripMenuItem,
			this.sQLToolStripMenuItem,
			this.xMLToolStripMenuItem});
			this.syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
			this.syntaxToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.syntaxToolStripMenuItem.Text = "Syntax";
			// 
			// lUAToolStripMenuItem
			// 
			this.lUAToolStripMenuItem.Name = "lUAToolStripMenuItem";
			this.lUAToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.lUAToolStripMenuItem.Text = "LUA";
			// 
			// hTMLToolStripMenuItem
			// 
			this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
			this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.hTMLToolStripMenuItem.Text = "HTML";
			// 
			// cSSToolStripMenuItem
			// 
			this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
			this.cSSToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.cSSToolStripMenuItem.Text = "CSS";
			// 
			// javaScriptToolStripMenuItem
			// 
			this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
			this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.javaScriptToolStripMenuItem.Text = "JavaScript";
			// 
			// hLSLToolStripMenuItem
			// 
			this.hLSLToolStripMenuItem.Name = "hLSLToolStripMenuItem";
			this.hLSLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.hLSLToolStripMenuItem.Text = "HLSL";
			// 
			// sQLToolStripMenuItem
			// 
			this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
			this.sQLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.sQLToolStripMenuItem.Text = "SQL";
			// 
			// xMLToolStripMenuItem
			// 
			this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
			this.xMLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.xMLToolStripMenuItem.Text = "XML";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.runLUACodeToolStripMenuItem});
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.runToolStripMenuItem.Text = "Run";
			// 
			// runLUACodeToolStripMenuItem
			// 
			this.runLUACodeToolStripMenuItem.Name = "runLUACodeToolStripMenuItem";
			this.runLUACodeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.runLUACodeToolStripMenuItem.Text = "Run LUA Code";
			this.runLUACodeToolStripMenuItem.Click += new System.EventHandler(this.RunLUACodeToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.base64EncodeToolStripMenuItem,
			this.base64DecodeToolStripMenuItem,
			this.compileToLUACToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// base64EncodeToolStripMenuItem
			// 
			this.base64EncodeToolStripMenuItem.Name = "base64EncodeToolStripMenuItem";
			this.base64EncodeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.base64EncodeToolStripMenuItem.Text = "Base64Encode";
			this.base64EncodeToolStripMenuItem.Click += new System.EventHandler(this.Base64EncodeToolStripMenuItemClick);
			// 
			// base64DecodeToolStripMenuItem
			// 
			this.base64DecodeToolStripMenuItem.Name = "base64DecodeToolStripMenuItem";
			this.base64DecodeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.base64DecodeToolStripMenuItem.Text = "Base64Decode";
			this.base64DecodeToolStripMenuItem.Click += new System.EventHandler(this.Base64DecodeToolStripMenuItemClick);
			// 
			// compileToLUACToolStripMenuItem
			// 
			this.compileToLUACToolStripMenuItem.Name = "compileToLUACToolStripMenuItem";
			this.compileToLUACToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.compileToLUACToolStripMenuItem.Text = "Compile to LUAC";
			this.compileToLUACToolStripMenuItem.Click += new System.EventHandler(this.CompileToLUACToolStripMenuItemClick);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.preferenceToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// preferenceToolStripMenuItem
			// 
			this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
			this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.preferenceToolStripMenuItem.Text = "Preference";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutMTACodeEditorToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutMTACodeEditorToolStripMenuItem
			// 
			this.aboutMTACodeEditorToolStripMenuItem.Name = "aboutMTACodeEditorToolStripMenuItem";
			this.aboutMTACodeEditorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.aboutMTACodeEditorToolStripMenuItem.Text = "About MTA Code Editor";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Location = new System.Drawing.Point(104, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 455);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 5;
			// 
			// editInfo
			// 
			this.editInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.editInfo.Location = new System.Drawing.Point(762, 4);
			this.editInfo.Name = "editInfo";
			this.editInfo.Size = new System.Drawing.Size(142, 21);
			this.editInfo.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.editInfo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 509);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(930, 33);
			this.panel1.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(930, 542);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "MTA Code Editor";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label editInfo;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripMenuItem aboutMTACodeEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compileToLUACToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem base64DecodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem base64EncodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runLUACodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hLSLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cSSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lUAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem syntaxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textFromLeftToRightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showTabsSpacesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem goToLineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertIndentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem directoryNameOfFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nameOfFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fullPathToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cłoseAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem uTF8WithBOMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveWithEncodingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
