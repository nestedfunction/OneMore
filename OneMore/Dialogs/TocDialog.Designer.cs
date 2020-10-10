﻿namespace River.OneMoreAddIn.Dialogs
{
	partial class TocDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TocDialog));
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.pageRadio = new System.Windows.Forms.RadioButton();
			this.sectionRadio = new System.Windows.Forms.RadioButton();
			this.topBox = new System.Windows.Forms.CheckBox();
			this.notebookRadio = new System.Windows.Forms.RadioButton();
			this.pagesBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(245, 254);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(120, 38);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(371, 254);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(120, 38);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// pageRadio
			// 
			this.pageRadio.AutoSize = true;
			this.pageRadio.Checked = true;
			this.pageRadio.Location = new System.Drawing.Point(18, 28);
			this.pageRadio.Name = "pageRadio";
			this.pageRadio.Size = new System.Drawing.Size(292, 24);
			this.pageRadio.TabIndex = 2;
			this.pageRadio.TabStop = true;
			this.pageRadio.Text = "Insert table of headings on this page";
			this.pageRadio.UseVisualStyleBackColor = true;
			this.pageRadio.CheckedChanged += new System.EventHandler(this.ChangedRadio);
			// 
			// sectionRadio
			// 
			this.sectionRadio.AutoSize = true;
			this.sectionRadio.Location = new System.Drawing.Point(18, 111);
			this.sectionRadio.Name = "sectionRadio";
			this.sectionRadio.Size = new System.Drawing.Size(340, 24);
			this.sectionRadio.TabIndex = 3;
			this.sectionRadio.Text = "Add page with table of pages in this section";
			this.sectionRadio.UseVisualStyleBackColor = true;
			this.sectionRadio.CheckedChanged += new System.EventHandler(this.ChangedRadio);
			// 
			// topBox
			// 
			this.topBox.AutoSize = true;
			this.topBox.Location = new System.Drawing.Point(46, 58);
			this.topBox.Name = "topBox";
			this.topBox.Size = new System.Drawing.Size(368, 24);
			this.topBox.TabIndex = 4;
			this.topBox.Text = "Add link to each heading to jump to top of page";
			this.topBox.UseVisualStyleBackColor = true;
			// 
			// notebookRadio
			// 
			this.notebookRadio.AutoSize = true;
			this.notebookRadio.Location = new System.Drawing.Point(18, 161);
			this.notebookRadio.Name = "notebookRadio";
			this.notebookRadio.Size = new System.Drawing.Size(371, 24);
			this.notebookRadio.TabIndex = 5;
			this.notebookRadio.Text = "Add page with table of sections in this notebook";
			this.notebookRadio.UseVisualStyleBackColor = true;
			this.notebookRadio.CheckedChanged += new System.EventHandler(this.ChangedRadio);
			// 
			// pagesBox
			// 
			this.pagesBox.AutoSize = true;
			this.pagesBox.Enabled = false;
			this.pagesBox.Location = new System.Drawing.Point(46, 191);
			this.pagesBox.Name = "pagesBox";
			this.pagesBox.Size = new System.Drawing.Size(245, 24);
			this.pagesBox.TabIndex = 6;
			this.pagesBox.Text = "Include pages in each section";
			this.pagesBox.UseVisualStyleBackColor = true;
			// 
			// TocDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(503, 304);
			this.Controls.Add(this.pagesBox);
			this.Controls.Add(this.notebookRadio);
			this.Controls.Add(this.topBox);
			this.Controls.Add(this.sectionRadio);
			this.Controls.Add(this.pageRadio);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TocDialog";
			this.Padding = new System.Windows.Forms.Padding(15, 25, 0, 0);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Table of Contents";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.RadioButton pageRadio;
		private System.Windows.Forms.RadioButton sectionRadio;
		private System.Windows.Forms.CheckBox topBox;
		private System.Windows.Forms.RadioButton notebookRadio;
		private System.Windows.Forms.CheckBox pagesBox;
	}
}