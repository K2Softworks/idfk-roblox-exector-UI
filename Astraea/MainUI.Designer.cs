
namespace Astraea
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Functions = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SettingsButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AttachButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ScriptHubButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ScriptListButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ClearEditorButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SaveFileButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.OpenFileButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ExecuteFileButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ExecuteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Minimize = new Siticone.Desktop.UI.WinForms.SiticoneTileButton();
            this.Close = new Siticone.Desktop.UI.WinForms.SiticoneTileButton();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.ScriptListRounder = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.FunctionsRounder = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.ScriptSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.MainUIRounder = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.ScriptSearchRounder = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.AceEditor = new System.Windows.Forms.WebBrowser();
            this.AceEditorRounder = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.MainUIDragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.LaucherHeader = new System.Windows.Forms.Label();
            this.Functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Functions
            // 
            this.Functions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Functions.BorderColor = System.Drawing.Color.Transparent;
            this.Functions.Controls.Add(this.SettingsButton);
            this.Functions.Controls.Add(this.AttachButton);
            this.Functions.Controls.Add(this.ScriptHubButton);
            this.Functions.Controls.Add(this.ScriptListButton);
            this.Functions.Controls.Add(this.ClearEditorButton);
            this.Functions.Controls.Add(this.SaveFileButton);
            this.Functions.Controls.Add(this.OpenFileButton);
            this.Functions.Controls.Add(this.ExecuteFileButton);
            this.Functions.Controls.Add(this.ExecuteButton);
            this.Functions.Location = new System.Drawing.Point(11, 22);
            this.Functions.Name = "Functions";
            this.Functions.ShadowDecoration.Parent = this.Functions;
            this.Functions.Size = new System.Drawing.Size(150, 326);
            this.Functions.TabIndex = 3;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BorderRadius = 6;
            this.SettingsButton.CheckedState.Parent = this.SettingsButton;
            this.SettingsButton.CustomImages.Parent = this.SettingsButton;
            this.SettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingsButton.DisabledState.Parent = this.SettingsButton;
            this.SettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.HoverState.Parent = this.SettingsButton;
            this.SettingsButton.Location = new System.Drawing.Point(21, 227);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.ShadowDecoration.Parent = this.SettingsButton;
            this.SettingsButton.Size = new System.Drawing.Size(111, 26);
            this.SettingsButton.TabIndex = 11;
            this.SettingsButton.Text = "Settings";
            // 
            // AttachButton
            // 
            this.AttachButton.BorderRadius = 6;
            this.AttachButton.CheckedState.Parent = this.AttachButton;
            this.AttachButton.CustomImages.Parent = this.AttachButton;
            this.AttachButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AttachButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttachButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AttachButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AttachButton.DisabledState.Parent = this.AttachButton;
            this.AttachButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AttachButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttachButton.ForeColor = System.Drawing.Color.White;
            this.AttachButton.HoverState.Parent = this.AttachButton;
            this.AttachButton.Location = new System.Drawing.Point(21, 173);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.ShadowDecoration.Parent = this.AttachButton;
            this.AttachButton.Size = new System.Drawing.Size(111, 26);
            this.AttachButton.TabIndex = 10;
            this.AttachButton.Text = "Attach";
            // 
            // ScriptHubButton
            // 
            this.ScriptHubButton.BorderRadius = 6;
            this.ScriptHubButton.CheckedState.Parent = this.ScriptHubButton;
            this.ScriptHubButton.CustomImages.Parent = this.ScriptHubButton;
            this.ScriptHubButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ScriptHubButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ScriptHubButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ScriptHubButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ScriptHubButton.DisabledState.Parent = this.ScriptHubButton;
            this.ScriptHubButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ScriptHubButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScriptHubButton.ForeColor = System.Drawing.Color.White;
            this.ScriptHubButton.HoverState.Parent = this.ScriptHubButton;
            this.ScriptHubButton.Location = new System.Drawing.Point(21, 259);
            this.ScriptHubButton.Name = "ScriptHubButton";
            this.ScriptHubButton.ShadowDecoration.Parent = this.ScriptHubButton;
            this.ScriptHubButton.Size = new System.Drawing.Size(111, 26);
            this.ScriptHubButton.TabIndex = 9;
            this.ScriptHubButton.Text = "Script Hub";
            // 
            // ScriptListButton
            // 
            this.ScriptListButton.BorderRadius = 6;
            this.ScriptListButton.CheckedState.Parent = this.ScriptListButton;
            this.ScriptListButton.CustomImages.Parent = this.ScriptListButton;
            this.ScriptListButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ScriptListButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ScriptListButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ScriptListButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ScriptListButton.DisabledState.Parent = this.ScriptListButton;
            this.ScriptListButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ScriptListButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScriptListButton.ForeColor = System.Drawing.Color.White;
            this.ScriptListButton.HoverState.Parent = this.ScriptListButton;
            this.ScriptListButton.Location = new System.Drawing.Point(21, 291);
            this.ScriptListButton.Name = "ScriptListButton";
            this.ScriptListButton.ShadowDecoration.Parent = this.ScriptListButton;
            this.ScriptListButton.Size = new System.Drawing.Size(111, 26);
            this.ScriptListButton.TabIndex = 8;
            this.ScriptListButton.Text = "Script List";
            // 
            // ClearEditorButton
            // 
            this.ClearEditorButton.BorderRadius = 6;
            this.ClearEditorButton.CheckedState.Parent = this.ClearEditorButton;
            this.ClearEditorButton.CustomImages.Parent = this.ClearEditorButton;
            this.ClearEditorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearEditorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearEditorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearEditorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearEditorButton.DisabledState.Parent = this.ClearEditorButton;
            this.ClearEditorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearEditorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearEditorButton.ForeColor = System.Drawing.Color.White;
            this.ClearEditorButton.HoverState.Parent = this.ClearEditorButton;
            this.ClearEditorButton.Location = new System.Drawing.Point(21, 141);
            this.ClearEditorButton.Name = "ClearEditorButton";
            this.ClearEditorButton.ShadowDecoration.Parent = this.ClearEditorButton;
            this.ClearEditorButton.Size = new System.Drawing.Size(111, 26);
            this.ClearEditorButton.TabIndex = 7;
            this.ClearEditorButton.Text = "Clear";
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BorderRadius = 6;
            this.SaveFileButton.CheckedState.Parent = this.SaveFileButton;
            this.SaveFileButton.CustomImages.Parent = this.SaveFileButton;
            this.SaveFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveFileButton.DisabledState.Parent = this.SaveFileButton;
            this.SaveFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SaveFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileButton.HoverState.Parent = this.SaveFileButton;
            this.SaveFileButton.Location = new System.Drawing.Point(21, 109);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.ShadowDecoration.Parent = this.SaveFileButton;
            this.SaveFileButton.Size = new System.Drawing.Size(111, 26);
            this.SaveFileButton.TabIndex = 6;
            this.SaveFileButton.Text = "Save FIle";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BorderRadius = 6;
            this.OpenFileButton.CheckedState.Parent = this.OpenFileButton;
            this.OpenFileButton.CustomImages.Parent = this.OpenFileButton;
            this.OpenFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenFileButton.DisabledState.Parent = this.OpenFileButton;
            this.OpenFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenFileButton.HoverState.Parent = this.OpenFileButton;
            this.OpenFileButton.Location = new System.Drawing.Point(21, 77);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.ShadowDecoration.Parent = this.OpenFileButton;
            this.OpenFileButton.Size = new System.Drawing.Size(111, 26);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Open File";
            // 
            // ExecuteFileButton
            // 
            this.ExecuteFileButton.BorderRadius = 6;
            this.ExecuteFileButton.CheckedState.Parent = this.ExecuteFileButton;
            this.ExecuteFileButton.CustomImages.Parent = this.ExecuteFileButton;
            this.ExecuteFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExecuteFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExecuteFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExecuteFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExecuteFileButton.DisabledState.Parent = this.ExecuteFileButton;
            this.ExecuteFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExecuteFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuteFileButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteFileButton.HoverState.Parent = this.ExecuteFileButton;
            this.ExecuteFileButton.Location = new System.Drawing.Point(21, 45);
            this.ExecuteFileButton.Name = "ExecuteFileButton";
            this.ExecuteFileButton.ShadowDecoration.Parent = this.ExecuteFileButton;
            this.ExecuteFileButton.Size = new System.Drawing.Size(111, 26);
            this.ExecuteFileButton.TabIndex = 4;
            this.ExecuteFileButton.Text = "Execute File";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BorderRadius = 6;
            this.ExecuteButton.CheckedState.Parent = this.ExecuteButton;
            this.ExecuteButton.CustomImages.Parent = this.ExecuteButton;
            this.ExecuteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExecuteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExecuteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExecuteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExecuteButton.DisabledState.Parent = this.ExecuteButton;
            this.ExecuteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.HoverState.Parent = this.ExecuteButton;
            this.ExecuteButton.Location = new System.Drawing.Point(21, 13);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShadowDecoration.Parent = this.ExecuteButton;
            this.ExecuteButton.Size = new System.Drawing.Size(111, 26);
            this.ExecuteButton.TabIndex = 3;
            this.ExecuteButton.Text = "Execute";
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BorderRadius = 5;
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.DisabledState.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Minimize.Font = new System.Drawing.Font("Verdana", 14F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(681, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(32, 30);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "_";
            this.Minimize.TextOffset = new System.Drawing.Point(1, -2);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BorderRadius = 5;
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.DisabledState.Parent = this.Close;
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Close.Font = new System.Drawing.Font("Verdana", 12F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(716, 2);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(32, 30);
            this.Close.TabIndex = 5;
            this.Close.Text = "X";
            this.Close.TextOffset = new System.Drawing.Point(2, 1);
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.Location = new System.Drawing.Point(608, 68);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(141, 286);
            this.ScriptList.TabIndex = 6;
            // 
            // ScriptListRounder
            // 
            this.ScriptListRounder.BorderRadius = 12;
            this.ScriptListRounder.TargetControl = this.ScriptList;
            // 
            // FunctionsRounder
            // 
            this.FunctionsRounder.BorderRadius = 12;
            this.FunctionsRounder.TargetControl = this.Functions;
            // 
            // ScriptSearch
            // 
            this.ScriptSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ScriptSearch.BorderRadius = 12;
            this.ScriptSearch.BorderThickness = 0;
            this.ScriptSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptSearch.DefaultText = "Search";
            this.ScriptSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ScriptSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ScriptSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScriptSearch.DisabledState.Parent = this.ScriptSearch;
            this.ScriptSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScriptSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ScriptSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScriptSearch.FocusedState.Parent = this.ScriptSearch;
            this.ScriptSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScriptSearch.ForeColor = System.Drawing.Color.White;
            this.ScriptSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScriptSearch.HoverState.Parent = this.ScriptSearch;
            this.ScriptSearch.Location = new System.Drawing.Point(608, 34);
            this.ScriptSearch.Name = "ScriptSearch";
            this.ScriptSearch.PasswordChar = '\0';
            this.ScriptSearch.PlaceholderText = "";
            this.ScriptSearch.SelectedText = "";
            this.ScriptSearch.SelectionStart = 6;
            this.ScriptSearch.ShadowDecoration.Parent = this.ScriptSearch;
            this.ScriptSearch.Size = new System.Drawing.Size(141, 31);
            this.ScriptSearch.TabIndex = 8;
            // 
            // MainUIRounder
            // 
            this.MainUIRounder.BorderRadius = 16;
            this.MainUIRounder.TargetControl = this;
            // 
            // ScriptSearchRounder
            // 
            this.ScriptSearchRounder.TargetControl = this.ScriptSearch;
            // 
            // AceEditor
            // 
            this.AceEditor.Location = new System.Drawing.Point(168, 42);
            this.AceEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.AceEditor.Name = "AceEditor";
            this.AceEditor.Size = new System.Drawing.Size(434, 306);
            this.AceEditor.TabIndex = 9;
            // 
            // AceEditorRounder
            // 
            this.AceEditorRounder.TargetControl = this.AceEditor;
            // 
            // MainUIDragControl
            // 
            this.MainUIDragControl.TargetControl = this;
            // 
            // LaucherHeader
            // 
            this.LaucherHeader.AutoSize = true;
            this.LaucherHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaucherHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.LaucherHeader.Location = new System.Drawing.Point(359, 2);
            this.LaucherHeader.Name = "LaucherHeader";
            this.LaucherHeader.Size = new System.Drawing.Size(103, 29);
            this.LaucherHeader.TabIndex = 10;
            this.LaucherHeader.Text = "Astraea";
            this.LaucherHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(752, 358);
            this.Controls.Add(this.LaucherHeader);
            this.Controls.Add(this.AceEditor);
            this.Controls.Add(this.ScriptSearch);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Functions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUI";
            this.Text = "UI";
            this.Functions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel Functions;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SettingsButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AttachButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ScriptHubButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ScriptListButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ClearEditorButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveFileButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton OpenFileButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ExecuteFileButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ExecuteButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTileButton Minimize;
        private Siticone.Desktop.UI.WinForms.SiticoneTileButton Close;
        private System.Windows.Forms.ListBox ScriptList;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse ScriptListRounder;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse FunctionsRounder;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ScriptSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse MainUIRounder;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse ScriptSearchRounder;
        private System.Windows.Forms.WebBrowser AceEditor;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse AceEditorRounder;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl MainUIDragControl;
        private System.Windows.Forms.Label LaucherHeader;
    }
}