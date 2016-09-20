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
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.nud_TimerMS = new System.Windows.Forms.NumericUpDown();
            this.tp_View = new System.Windows.Forms.TabPage();
            this.tp_Advanced = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tc_Options.SuspendLayout();
            this.tp_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerMS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(621, 509);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(56, 24);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(560, 509);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(56, 24);
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
            this.tc_Options.Margin = new System.Windows.Forms.Padding(2);
            this.tc_Options.Name = "tc_Options";
            this.tc_Options.SelectedIndex = 0;
            this.tc_Options.Size = new System.Drawing.Size(686, 504);
            this.tc_Options.TabIndex = 2;
            // 
            // tp_General
            // 
            this.tp_General.Controls.Add(this.label4);
            this.tp_General.Controls.Add(this.label3);
            this.tp_General.Controls.Add(this.label1);
            this.tp_General.Controls.Add(this.nud_Height);
            this.tp_General.Controls.Add(this.nud_Width);
            this.tp_General.Controls.Add(this.nud_TimerMS);
            this.tp_General.Location = new System.Drawing.Point(4, 22);
            this.tp_General.Margin = new System.Windows.Forms.Padding(2);
            this.tp_General.Name = "tp_General";
            this.tp_General.Padding = new System.Windows.Forms.Padding(2);
            this.tp_General.Size = new System.Drawing.Size(678, 478);
            this.tp_General.TabIndex = 0;
            this.tp_General.Text = "General";
            this.tp_General.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer Interval in Milliseconds";
            // 
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(167, 94);
            this.nud_Height.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Height.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(58, 20);
            this.nud_Height.TabIndex = 4;
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(167, 58);
            this.nud_Width.Margin = new System.Windows.Forms.Padding(2);
            this.nud_Width.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(58, 20);
            this.nud_Width.TabIndex = 3;
            // 
            // nud_TimerMS
            // 
            this.nud_TimerMS.Location = new System.Drawing.Point(167, 23);
            this.nud_TimerMS.Margin = new System.Windows.Forms.Padding(2);
            this.nud_TimerMS.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_TimerMS.Name = "nud_TimerMS";
            this.nud_TimerMS.Size = new System.Drawing.Size(58, 20);
            this.nud_TimerMS.TabIndex = 0;
            // 
            // tp_View
            // 
            this.tp_View.Location = new System.Drawing.Point(4, 22);
            this.tp_View.Margin = new System.Windows.Forms.Padding(2);
            this.tp_View.Name = "tp_View";
            this.tp_View.Padding = new System.Windows.Forms.Padding(2);
            this.tp_View.Size = new System.Drawing.Size(678, 478);
            this.tp_View.TabIndex = 1;
            this.tp_View.Text = "View";
            this.tp_View.UseVisualStyleBackColor = true;
            this.tp_View.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tp_Advanced
            // 
            this.tp_Advanced.Location = new System.Drawing.Point(4, 22);
            this.tp_Advanced.Margin = new System.Windows.Forms.Padding(2);
            this.tp_Advanced.Name = "tp_Advanced";
            this.tp_Advanced.Padding = new System.Windows.Forms.Padding(2);
            this.tp_Advanced.Size = new System.Drawing.Size(678, 478);
            this.tp_Advanced.TabIndex = 2;
            this.tp_Advanced.Text = "Advanced";
            this.tp_Advanced.UseVisualStyleBackColor = true;
            this.tp_Advanced.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width of Universe in Cells";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height of Universe in Cells";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 537);
            this.Controls.Add(this.tc_Options);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.tc_Options.ResumeLayout(false);
            this.tp_General.ResumeLayout(false);
            this.tp_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerMS)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.NumericUpDown nud_TimerMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}