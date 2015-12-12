namespace Urho3DSamplesLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonAngelScript = new System.Windows.Forms.RadioButton();
            this.radioButtonLua = new System.Windows.Forms.RadioButton();
            this.listBoxScripts = new System.Windows.Forms.ListBox();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.radioButtonRelease = new System.Windows.Forms.RadioButton();
            this.radioButtonDebug = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelSelectSript = new System.Windows.Forms.Panel();
            this.panelBuil = new System.Windows.Forms.Panel();
            this.labelFileMask = new System.Windows.Forms.Label();
            this.labelCommandLine = new System.Windows.Forms.Label();
            this.comboBoxResolutions = new System.Windows.Forms.ComboBox();
            this.panelSelectSript.SuspendLayout();
            this.panelBuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAngelScript
            // 
            this.radioButtonAngelScript.AutoSize = true;
            this.radioButtonAngelScript.Checked = true;
            this.radioButtonAngelScript.Location = new System.Drawing.Point(0, 0);
            this.radioButtonAngelScript.Name = "radioButtonAngelScript";
            this.radioButtonAngelScript.Size = new System.Drawing.Size(79, 17);
            this.radioButtonAngelScript.TabIndex = 0;
            this.radioButtonAngelScript.TabStop = true;
            this.radioButtonAngelScript.Text = "AngelScript";
            this.radioButtonAngelScript.UseVisualStyleBackColor = true;
            this.radioButtonAngelScript.CheckedChanged += new System.EventHandler(this.radioButtonAngelScript_CheckedChanged);
            // 
            // radioButtonLua
            // 
            this.radioButtonLua.AutoSize = true;
            this.radioButtonLua.Location = new System.Drawing.Point(83, 0);
            this.radioButtonLua.Name = "radioButtonLua";
            this.radioButtonLua.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLua.TabIndex = 1;
            this.radioButtonLua.Text = "Lua";
            this.radioButtonLua.UseVisualStyleBackColor = true;
            this.radioButtonLua.CheckedChanged += new System.EventHandler(this.radioButtonLua_CheckedChanged);
            // 
            // listBoxScripts
            // 
            this.listBoxScripts.FormattingEnabled = true;
            this.listBoxScripts.Location = new System.Drawing.Point(12, 32);
            this.listBoxScripts.Name = "listBoxScripts";
            this.listBoxScripts.Size = new System.Drawing.Size(655, 173);
            this.listBoxScripts.TabIndex = 3;
            this.listBoxScripts.SelectedIndexChanged += new System.EventHandler(this.listBoxScripts_SelectedIndexChanged);
            this.listBoxScripts.DoubleClick += new System.EventHandler(this.listBoxScripts_DoubleClick);
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.CheckOnClick = true;
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Location = new System.Drawing.Point(12, 211);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(655, 64);
            this.checkedListBoxOptions.TabIndex = 4;
            this.checkedListBoxOptions.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOptions_SelectedIndexChanged);
            // 
            // radioButtonRelease
            // 
            this.radioButtonRelease.AutoSize = true;
            this.radioButtonRelease.Checked = true;
            this.radioButtonRelease.Location = new System.Drawing.Point(3, 1);
            this.radioButtonRelease.Name = "radioButtonRelease";
            this.radioButtonRelease.Size = new System.Drawing.Size(64, 17);
            this.radioButtonRelease.TabIndex = 5;
            this.radioButtonRelease.TabStop = true;
            this.radioButtonRelease.Text = "Release";
            this.radioButtonRelease.UseVisualStyleBackColor = true;
            this.radioButtonRelease.CheckedChanged += new System.EventHandler(this.radioButtonRelease_CheckedChanged);
            // 
            // radioButtonDebug
            // 
            this.radioButtonDebug.AutoSize = true;
            this.radioButtonDebug.Location = new System.Drawing.Point(73, 1);
            this.radioButtonDebug.Name = "radioButtonDebug";
            this.radioButtonDebug.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDebug.TabIndex = 6;
            this.radioButtonDebug.Text = "Debug";
            this.radioButtonDebug.UseVisualStyleBackColor = true;
            this.radioButtonDebug.CheckedChanged += new System.EventHandler(this.radioButtonDebug_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(592, 281);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 51);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelSelectSript
            // 
            this.panelSelectSript.Controls.Add(this.radioButtonAngelScript);
            this.panelSelectSript.Controls.Add(this.radioButtonLua);
            this.panelSelectSript.Location = new System.Drawing.Point(12, 9);
            this.panelSelectSript.Name = "panelSelectSript";
            this.panelSelectSript.Size = new System.Drawing.Size(130, 18);
            this.panelSelectSript.TabIndex = 0;
            // 
            // panelBuil
            // 
            this.panelBuil.Controls.Add(this.radioButtonRelease);
            this.panelBuil.Controls.Add(this.radioButtonDebug);
            this.panelBuil.Location = new System.Drawing.Point(238, 281);
            this.panelBuil.Name = "panelBuil";
            this.panelBuil.Size = new System.Drawing.Size(200, 21);
            this.panelBuil.TabIndex = 6;
            // 
            // labelFileMask
            // 
            this.labelFileMask.AutoSize = true;
            this.labelFileMask.BackColor = System.Drawing.SystemColors.Control;
            this.labelFileMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFileMask.Location = new System.Drawing.Point(144, 9);
            this.labelFileMask.Name = "labelFileMask";
            this.labelFileMask.Size = new System.Drawing.Size(73, 15);
            this.labelFileMask.TabIndex = 9;
            this.labelFileMask.Text = "labelFileMask";
            // 
            // labelCommandLine
            // 
            this.labelCommandLine.AutoSize = true;
            this.labelCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCommandLine.Location = new System.Drawing.Point(12, 308);
            this.labelCommandLine.Name = "labelCommandLine";
            this.labelCommandLine.Size = new System.Drawing.Size(98, 15);
            this.labelCommandLine.TabIndex = 10;
            this.labelCommandLine.Text = "labelCommandLine";
            // 
            // comboBoxResolutions
            // 
            this.comboBoxResolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolutions.FormattingEnabled = true;
            this.comboBoxResolutions.Location = new System.Drawing.Point(12, 281);
            this.comboBoxResolutions.Name = "comboBoxResolutions";
            this.comboBoxResolutions.Size = new System.Drawing.Size(220, 21);
            this.comboBoxResolutions.TabIndex = 5;
            this.comboBoxResolutions.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutions_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 346);
            this.Controls.Add(this.comboBoxResolutions);
            this.Controls.Add(this.labelCommandLine);
            this.Controls.Add(this.labelFileMask);
            this.Controls.Add(this.panelBuil);
            this.Controls.Add(this.panelSelectSript);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkedListBoxOptions);
            this.Controls.Add(this.listBoxScripts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urho3D Samples Launcher";
            this.panelSelectSript.ResumeLayout(false);
            this.panelSelectSript.PerformLayout();
            this.panelBuil.ResumeLayout(false);
            this.panelBuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAngelScript;
        private System.Windows.Forms.RadioButton radioButtonLua;
        private System.Windows.Forms.ListBox listBoxScripts;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.RadioButton radioButtonRelease;
        private System.Windows.Forms.RadioButton radioButtonDebug;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelSelectSript;
        private System.Windows.Forms.Panel panelBuil;
        private System.Windows.Forms.Label labelFileMask;
        private System.Windows.Forms.Label labelCommandLine;
        private System.Windows.Forms.ComboBox comboBoxResolutions;
    }
}

