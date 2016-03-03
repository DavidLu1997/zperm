﻿namespace ZopperPerm
{
    partial class PermMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermMainWindow));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.stringToPermute = new System.Windows.Forms.TextBox();
            this.permutationButton = new System.Windows.Forms.RadioButton();
            this.combinationButton = new System.Windows.Forms.RadioButton();
            this.kValue = new System.Windows.Forms.NumericUpDown();
            this.mainOutput = new System.Windows.Forms.RichTextBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 1;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // stringToPermute
            // 
            resources.ApplyResources(this.stringToPermute, "stringToPermute");
            this.stringToPermute.Name = "stringToPermute";
            this.stringToPermute.TextChanged += new System.EventHandler(this.changeK);
            // 
            // permutationButton
            // 
            resources.ApplyResources(this.permutationButton, "permutationButton");
            this.permutationButton.Name = "permutationButton";
            this.permutationButton.TabStop = true;
            this.permutationButton.UseVisualStyleBackColor = true;
            // 
            // combinationButton
            // 
            resources.ApplyResources(this.combinationButton, "combinationButton");
            this.combinationButton.Name = "combinationButton";
            this.combinationButton.TabStop = true;
            this.combinationButton.UseVisualStyleBackColor = true;
            // 
            // kValue
            // 
            resources.ApplyResources(this.kValue, "kValue");
            this.kValue.Name = "kValue";
            // 
            // mainOutput
            // 
            resources.ApplyResources(this.mainOutput, "mainOutput");
            this.mainOutput.Name = "mainOutput";
            // 
            // generateButton
            // 
            resources.ApplyResources(this.generateButton, "generateButton");
            this.generateButton.Name = "generateButton";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateAction);
            // 
            // PermMainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.mainOutput);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.combinationButton);
            this.Controls.Add(this.permutationButton);
            this.Controls.Add(this.stringToPermute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "PermMainWindow";
            this.Load += new System.EventHandler(this.PermMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringToPermute;
        private System.Windows.Forms.RadioButton permutationButton;
        private System.Windows.Forms.RadioButton combinationButton;
        private System.Windows.Forms.NumericUpDown kValue;
        private System.Windows.Forms.RichTextBox mainOutput;
        private System.Windows.Forms.Button generateButton;
    }
}
