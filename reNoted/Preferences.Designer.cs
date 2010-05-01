//Copyright 2010 Jason Hamilton (laydros.org)

//This file is part of reNoted.

//reNoted is free software: you can redistribute it and/or modify it under the 
//terms of the GNU General Public License as published by the Free Software 
//Foundation, either version 3 of the License, or (at your option) any later version.

//reNoted is distributed in the hope that it will be useful, but WITHOUT ANY 
//WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
//FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public License along with 
//reNoted. If not, see http://www.gnu.org/licenses/.

namespace reNoted
{
    partial class Preferences
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.userEditorNameLabel = new System.Windows.Forms.Label();
            this.userEditorChooseButton = new System.Windows.Forms.Button();
            this.fileDirLabel = new System.Windows.Forms.Label();
            this.autoSaveLabel = new System.Windows.Forms.Label();
            this.autoSaveOptionsBox = new System.Windows.Forms.GroupBox();
            this.autoSaveIntervalLabel = new System.Windows.Forms.Label();
            this.autoSaveInterval = new System.Windows.Forms.NumericUpDown();
            this.autoSaveBackupCheck = new System.Windows.Forms.CheckBox();
            this.autoSaveEnabledCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.prefsSaveButton = new System.Windows.Forms.Button();
            this.prefsCancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fileDirNameLabel = new System.Windows.Forms.Label();
            this.dirChooseButton = new System.Windows.Forms.Button();
            this.tabPerfGroup = new System.Windows.Forms.GroupBox();
            this.navigateTabRadioButton = new System.Windows.Forms.RadioButton();
            this.insertTabRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPrefLabel = new System.Windows.Forms.Label();
            this.deleteConfirmCheck = new System.Windows.Forms.CheckBox();
            this.userEditorLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.userEditorDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.autoSaveOptionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoSaveInterval)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPerfGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.07692F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileDirLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoSaveLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.autoSaveOptionsBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabPerfGroup, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tabPrefLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.deleteConfirmCheck, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.userEditorLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.Controls.Add(this.userEditorNameLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.userEditorChooseButton, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(135, 59);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 45);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // userEditorNameLabel
            // 
            this.userEditorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userEditorNameLabel.AutoSize = true;
            this.userEditorNameLabel.Location = new System.Drawing.Point(3, 16);
            this.userEditorNameLabel.Name = "userEditorNameLabel";
            this.userEditorNameLabel.Size = new System.Drawing.Size(33, 13);
            this.userEditorNameLabel.TabIndex = 8;
            this.userEditorNameLabel.Text = "fileDir";
            // 
            // userEditorChooseButton
            // 
            this.userEditorChooseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userEditorChooseButton.Location = new System.Drawing.Point(150, 11);
            this.userEditorChooseButton.Name = "userEditorChooseButton";
            this.userEditorChooseButton.Size = new System.Drawing.Size(59, 23);
            this.userEditorChooseButton.TabIndex = 9;
            this.userEditorChooseButton.Text = "Choose";
            this.userEditorChooseButton.UseVisualStyleBackColor = true;
            this.userEditorChooseButton.Click += new System.EventHandler(this.userEditorChooseButton_Click);
            // 
            // fileDirLabel
            // 
            this.fileDirLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fileDirLabel.AutoSize = true;
            this.fileDirLabel.Location = new System.Drawing.Point(47, 21);
            this.fileDirLabel.Margin = new System.Windows.Forms.Padding(5);
            this.fileDirLabel.Name = "fileDirLabel";
            this.fileDirLabel.Size = new System.Drawing.Size(80, 13);
            this.fileDirLabel.TabIndex = 2;
            this.fileDirLabel.Text = "Notes Directory";
            // 
            // autoSaveLabel
            // 
            this.autoSaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autoSaveLabel.AutoSize = true;
            this.autoSaveLabel.Location = new System.Drawing.Point(70, 171);
            this.autoSaveLabel.Margin = new System.Windows.Forms.Padding(5);
            this.autoSaveLabel.Name = "autoSaveLabel";
            this.autoSaveLabel.Size = new System.Drawing.Size(57, 13);
            this.autoSaveLabel.TabIndex = 4;
            this.autoSaveLabel.Text = "Auto Save";
            // 
            // autoSaveOptionsBox
            // 
            this.autoSaveOptionsBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoSaveOptionsBox.Controls.Add(this.autoSaveIntervalLabel);
            this.autoSaveOptionsBox.Controls.Add(this.autoSaveInterval);
            this.autoSaveOptionsBox.Controls.Add(this.autoSaveBackupCheck);
            this.autoSaveOptionsBox.Controls.Add(this.autoSaveEnabledCheck);
            this.autoSaveOptionsBox.Location = new System.Drawing.Point(135, 133);
            this.autoSaveOptionsBox.MaximumSize = new System.Drawing.Size(0, 90);
            this.autoSaveOptionsBox.MinimumSize = new System.Drawing.Size(170, 90);
            this.autoSaveOptionsBox.Name = "autoSaveOptionsBox";
            this.autoSaveOptionsBox.Size = new System.Drawing.Size(170, 90);
            this.autoSaveOptionsBox.TabIndex = 6;
            this.autoSaveOptionsBox.TabStop = false;
            // 
            // autoSaveIntervalLabel
            // 
            this.autoSaveIntervalLabel.AutoSize = true;
            this.autoSaveIntervalLabel.Location = new System.Drawing.Point(62, 61);
            this.autoSaveIntervalLabel.Name = "autoSaveIntervalLabel";
            this.autoSaveIntervalLabel.Size = new System.Drawing.Size(93, 13);
            this.autoSaveIntervalLabel.TabIndex = 3;
            this.autoSaveIntervalLabel.Text = "Interval (Seconds)";
            // 
            // autoSaveInterval
            // 
            this.autoSaveInterval.Location = new System.Drawing.Point(6, 59);
            this.autoSaveInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.autoSaveInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoSaveInterval.Name = "autoSaveInterval";
            this.autoSaveInterval.Size = new System.Drawing.Size(50, 20);
            this.autoSaveInterval.TabIndex = 2;
            this.autoSaveInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.autoSaveInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // autoSaveBackupCheck
            // 
            this.autoSaveBackupCheck.AutoSize = true;
            this.autoSaveBackupCheck.Location = new System.Drawing.Point(6, 35);
            this.autoSaveBackupCheck.Name = "autoSaveBackupCheck";
            this.autoSaveBackupCheck.Size = new System.Drawing.Size(97, 17);
            this.autoSaveBackupCheck.TabIndex = 1;
            this.autoSaveBackupCheck.Text = "Create Backup";
            this.autoSaveBackupCheck.UseVisualStyleBackColor = true;
            // 
            // autoSaveEnabledCheck
            // 
            this.autoSaveEnabledCheck.AutoSize = true;
            this.autoSaveEnabledCheck.Location = new System.Drawing.Point(7, 11);
            this.autoSaveEnabledCheck.Name = "autoSaveEnabledCheck";
            this.autoSaveEnabledCheck.Size = new System.Drawing.Size(65, 17);
            this.autoSaveEnabledCheck.TabIndex = 0;
            this.autoSaveEnabledCheck.Text = "Enabled";
            this.autoSaveEnabledCheck.UseVisualStyleBackColor = true;
            this.autoSaveEnabledCheck.CheckedChanged += new System.EventHandler(this.autoSaveEnabledCheck_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.prefsSaveButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.prefsCancelButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 313);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(353, 30);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // prefsSaveButton
            // 
            this.prefsSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prefsSaveButton.Location = new System.Drawing.Point(50, 3);
            this.prefsSaveButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.prefsSaveButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.prefsSaveButton.Name = "prefsSaveButton";
            this.prefsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.prefsSaveButton.TabIndex = 0;
            this.prefsSaveButton.Text = "OK";
            this.prefsSaveButton.UseVisualStyleBackColor = true;
            this.prefsSaveButton.Click += new System.EventHandler(this.prefsSaveButton_Click);
            // 
            // prefsCancelButton
            // 
            this.prefsCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prefsCancelButton.Location = new System.Drawing.Point(227, 3);
            this.prefsCancelButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.prefsCancelButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.prefsCancelButton.Name = "prefsCancelButton";
            this.prefsCancelButton.Size = new System.Drawing.Size(75, 23);
            this.prefsCancelButton.TabIndex = 1;
            this.prefsCancelButton.Text = "Cancel";
            this.prefsCancelButton.UseVisualStyleBackColor = true;
            this.prefsCancelButton.Click += new System.EventHandler(this.prefsCancelButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.Controls.Add(this.fileDirNameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dirChooseButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(135, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 50);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // fileDirNameLabel
            // 
            this.fileDirNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileDirNameLabel.AutoSize = true;
            this.fileDirNameLabel.Location = new System.Drawing.Point(3, 18);
            this.fileDirNameLabel.Name = "fileDirNameLabel";
            this.fileDirNameLabel.Size = new System.Drawing.Size(33, 13);
            this.fileDirNameLabel.TabIndex = 8;
            this.fileDirNameLabel.Text = "fileDir";
            // 
            // dirChooseButton
            // 
            this.dirChooseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dirChooseButton.Location = new System.Drawing.Point(150, 13);
            this.dirChooseButton.Name = "dirChooseButton";
            this.dirChooseButton.Size = new System.Drawing.Size(59, 23);
            this.dirChooseButton.TabIndex = 9;
            this.dirChooseButton.Text = "Choose";
            this.dirChooseButton.UseVisualStyleBackColor = true;
            this.dirChooseButton.Click += new System.EventHandler(this.dirChooseButton_Click);
            // 
            // tabPerfGroup
            // 
            this.tabPerfGroup.Controls.Add(this.navigateTabRadioButton);
            this.tabPerfGroup.Controls.Add(this.insertTabRadioButton);
            this.tabPerfGroup.Location = new System.Drawing.Point(135, 229);
            this.tabPerfGroup.MinimumSize = new System.Drawing.Size(160, 60);
            this.tabPerfGroup.Name = "tabPerfGroup";
            this.tabPerfGroup.Size = new System.Drawing.Size(190, 60);
            this.tabPerfGroup.TabIndex = 5;
            this.tabPerfGroup.TabStop = false;
            // 
            // navigateTabRadioButton
            // 
            this.navigateTabRadioButton.AutoSize = true;
            this.navigateTabRadioButton.Location = new System.Drawing.Point(6, 33);
            this.navigateTabRadioButton.Name = "navigateTabRadioButton";
            this.navigateTabRadioButton.Size = new System.Drawing.Size(68, 17);
            this.navigateTabRadioButton.TabIndex = 1;
            this.navigateTabRadioButton.TabStop = true;
            this.navigateTabRadioButton.Text = "Navigate";
            this.navigateTabRadioButton.UseVisualStyleBackColor = true;
            // 
            // insertTabRadioButton
            // 
            this.insertTabRadioButton.AutoSize = true;
            this.insertTabRadioButton.Location = new System.Drawing.Point(6, 10);
            this.insertTabRadioButton.Name = "insertTabRadioButton";
            this.insertTabRadioButton.Size = new System.Drawing.Size(73, 17);
            this.insertTabRadioButton.TabIndex = 0;
            this.insertTabRadioButton.TabStop = true;
            this.insertTabRadioButton.Text = "Insert Tab";
            this.insertTabRadioButton.UseVisualStyleBackColor = true;
            // 
            // tabPrefLabel
            // 
            this.tabPrefLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tabPrefLabel.AutoSize = true;
            this.tabPrefLabel.Location = new System.Drawing.Point(46, 252);
            this.tabPrefLabel.Margin = new System.Windows.Forms.Padding(5);
            this.tabPrefLabel.Name = "tabPrefLabel";
            this.tabPrefLabel.Size = new System.Drawing.Size(81, 13);
            this.tabPrefLabel.TabIndex = 3;
            this.tabPrefLabel.Text = "Tab Key Usage";
            // 
            // deleteConfirmCheck
            // 
            this.deleteConfirmCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteConfirmCheck.AutoSize = true;
            this.deleteConfirmCheck.Location = new System.Drawing.Point(135, 110);
            this.deleteConfirmCheck.Name = "deleteConfirmCheck";
            this.deleteConfirmCheck.Size = new System.Drawing.Size(135, 17);
            this.deleteConfirmCheck.TabIndex = 10;
            this.deleteConfirmCheck.Text = "Confirm Note Deletion?";
            this.deleteConfirmCheck.UseVisualStyleBackColor = true;
            // 
            // userEditorLabel
            // 
            this.userEditorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userEditorLabel.AutoSize = true;
            this.userEditorLabel.Location = new System.Drawing.Point(25, 75);
            this.userEditorLabel.Name = "userEditorLabel";
            this.userEditorLabel.Size = new System.Drawing.Size(104, 13);
            this.userEditorLabel.TabIndex = 11;
            this.userEditorLabel.Text = "User Selected Editor";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose directory for notes";
            // 
            // userEditorDialog
            // 
            this.userEditorDialog.FileName = "User Selected Editor";
            this.userEditorDialog.ReadOnlyChecked = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.autoSaveOptionsBox.ResumeLayout(false);
            this.autoSaveOptionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoSaveInterval)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPerfGroup.ResumeLayout(false);
            this.tabPerfGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button prefsSaveButton;
        private System.Windows.Forms.Button prefsCancelButton;
        private System.Windows.Forms.Label fileDirLabel;
        private System.Windows.Forms.Label tabPrefLabel;
        private System.Windows.Forms.Label autoSaveLabel;
        private System.Windows.Forms.GroupBox tabPerfGroup;
        private System.Windows.Forms.RadioButton insertTabRadioButton;
        private System.Windows.Forms.RadioButton navigateTabRadioButton;
        private System.Windows.Forms.GroupBox autoSaveOptionsBox;
        private System.Windows.Forms.Label autoSaveIntervalLabel;
        private System.Windows.Forms.NumericUpDown autoSaveInterval;
        private System.Windows.Forms.CheckBox autoSaveBackupCheck;
        private System.Windows.Forms.CheckBox autoSaveEnabledCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label fileDirNameLabel;
        private System.Windows.Forms.Button dirChooseButton;
        private System.Windows.Forms.CheckBox deleteConfirmCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label userEditorNameLabel;
        private System.Windows.Forms.Button userEditorChooseButton;
        private System.Windows.Forms.Label userEditorLabel;
        private System.Windows.Forms.OpenFileDialog userEditorDialog;
    }
}