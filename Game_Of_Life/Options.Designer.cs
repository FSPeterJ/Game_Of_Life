namespace Game_Of_Life
{
    partial class Options
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tc_Options = new System.Windows.Forms.TabControl();
            this.tp_General = new System.Windows.Forms.TabPage();
            this.tp_View = new System.Windows.Forms.TabPage();
            this.tp_Advanced = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nud_TimerMS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_Options.SuspendLayout();
            this.tp_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(828, 626);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 30);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(747, 626);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // tc_Options
            // 
            this.tc_Options.Controls.Add(this.tp_General);
            this.tc_Options.Controls.Add(this.tp_View);
            this.tc_Options.Controls.Add(this.tp_Advanced);
            this.tc_Options.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_Options.Location = new System.Drawing.Point(0, 0);
            this.tc_Options.Name = "tc_Options";
            this.tc_Options.SelectedIndex = 0;
            this.tc_Options.Size = new System.Drawing.Size(915, 620);
            this.tc_Options.TabIndex = 2;
            // 
            // tp_General
            // 
            this.tp_General.Controls.Add(this.label1);
            this.tp_General.Controls.Add(this.numericUpDown3);
            this.tp_General.Controls.Add(this.numericUpDown1);
            this.tp_General.Controls.Add(this.nud_TimerMS);
            this.tp_General.Location = new System.Drawing.Point(4, 25);
            this.tp_General.Name = "tp_General";
            this.tp_General.Padding = new System.Windows.Forms.Padding(3);
            this.tp_General.Size = new System.Drawing.Size(907, 591);
            this.tp_General.TabIndex = 0;
            this.tp_General.Text = "General";
            this.tp_General.UseVisualStyleBackColor = true;
            // 
            // tp_View
            // 
            this.tp_View.Location = new System.Drawing.Point(4, 25);
            this.tp_View.Name = "tp_View";
            this.tp_View.Padding = new System.Windows.Forms.Padding(3);
            this.tp_View.Size = new System.Drawing.Size(907, 591);
            this.tp_View.TabIndex = 1;
            this.tp_View.Text = "View";
            this.tp_View.UseVisualStyleBackColor = true;
            this.tp_View.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tp_Advanced
            // 
            this.tp_Advanced.Location = new System.Drawing.Point(4, 25);
            this.tp_Advanced.Name = "tp_Advanced";
            this.tp_Advanced.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Advanced.Size = new System.Drawing.Size(907, 591);
            this.tp_Advanced.TabIndex = 2;
            this.tp_Advanced.Text = "Advanced";
            this.tp_Advanced.UseVisualStyleBackColor = true;
            this.tp_Advanced.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(223, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // nud_TimerMS
            // 
            this.nud_TimerMS.Location = new System.Drawing.Point(223, 28);
            this.nud_TimerMS.Name = "nud_TimerMS";
            this.nud_TimerMS.Size = new System.Drawing.Size(67, 22);
            this.nud_TimerMS.TabIndex = 0;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(223, 116);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer Interval in Milliseconds";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 661);
            this.Controls.Add(this.tc_Options);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.tc_Options.ResumeLayout(false);
            this.tp_General.ResumeLayout(false);
            this.tp_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TabControl tc_Options;
        private System.Windows.Forms.TabPage tp_General;
        private System.Windows.Forms.TabPage tp_View;
        private System.Windows.Forms.TabPage tp_Advanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nud_TimerMS;
    }
}