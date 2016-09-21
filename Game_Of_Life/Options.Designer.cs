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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.nud_TimerMS = new System.Windows.Forms.NumericUpDown();
            this.tp_View = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LiveCell = new System.Windows.Forms.Button();
            this.btn_Background = new System.Windows.Forms.Button();
            this.btn_Grid10 = new System.Windows.Forms.Button();
            this.btn_Grid = new System.Windows.Forms.Button();
            this.tp_Advanced = new System.Windows.Forms.TabPage();
            this.rb_Toroidal = new System.Windows.Forms.RadioButton();
            this.rb_Finite = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tc_Options.SuspendLayout();
            this.tp_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerMS)).BeginInit();
            this.tp_View.SuspendLayout();
            this.tp_Advanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(828, 626);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 30);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(747, 626);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tc_Options.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_Options.Name = "tc_Options";
            this.tc_Options.SelectedIndex = 0;
            this.tc_Options.Size = new System.Drawing.Size(915, 620);
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
            this.tp_General.Location = new System.Drawing.Point(4, 25);
            this.tp_General.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_General.Name = "tp_General";
            this.tp_General.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_General.Size = new System.Drawing.Size(907, 591);
            this.tp_General.TabIndex = 0;
            this.tp_General.Text = "General";
            this.tp_General.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height of Universe in Cells";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width of Universe in Cells";
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
            // nud_Height
            // 
            this.nud_Height.Location = new System.Drawing.Point(223, 116);
            this.nud_Height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_Height.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(77, 22);
            this.nud_Height.TabIndex = 4;
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(223, 71);
            this.nud_Width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_Width.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(77, 22);
            this.nud_Width.TabIndex = 3;
            // 
            // nud_TimerMS
            // 
            this.nud_TimerMS.Location = new System.Drawing.Point(223, 28);
            this.nud_TimerMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_TimerMS.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_TimerMS.Name = "nud_TimerMS";
            this.nud_TimerMS.Size = new System.Drawing.Size(77, 22);
            this.nud_TimerMS.TabIndex = 0;
            // 
            // tp_View
            // 
            this.tp_View.Controls.Add(this.label7);
            this.tp_View.Controls.Add(this.label6);
            this.tp_View.Controls.Add(this.label5);
            this.tp_View.Controls.Add(this.label2);
            this.tp_View.Controls.Add(this.btn_LiveCell);
            this.tp_View.Controls.Add(this.btn_Background);
            this.tp_View.Controls.Add(this.btn_Grid10);
            this.tp_View.Controls.Add(this.btn_Grid);
            this.tp_View.Location = new System.Drawing.Point(4, 25);
            this.tp_View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_View.Name = "tp_View";
            this.tp_View.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_View.Size = new System.Drawing.Size(907, 591);
            this.tp_View.TabIndex = 1;
            this.tp_View.Text = "View";
            this.tp_View.UseVisualStyleBackColor = true;
            this.tp_View.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Live Cell Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Background Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "10x Grid Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grid Color";
            // 
            // btn_LiveCell
            // 
            this.btn_LiveCell.Location = new System.Drawing.Point(28, 238);
            this.btn_LiveCell.Name = "btn_LiveCell";
            this.btn_LiveCell.Size = new System.Drawing.Size(73, 65);
            this.btn_LiveCell.TabIndex = 3;
            this.btn_LiveCell.UseVisualStyleBackColor = true;
            this.btn_LiveCell.Click += new System.EventHandler(this.btn_Grid_Click);
            // 
            // btn_Background
            // 
            this.btn_Background.Location = new System.Drawing.Point(28, 167);
            this.btn_Background.Name = "btn_Background";
            this.btn_Background.Size = new System.Drawing.Size(73, 65);
            this.btn_Background.TabIndex = 2;
            this.btn_Background.UseVisualStyleBackColor = true;
            this.btn_Background.Click += new System.EventHandler(this.btn_Grid_Click);
            // 
            // btn_Grid10
            // 
            this.btn_Grid10.Location = new System.Drawing.Point(28, 96);
            this.btn_Grid10.Name = "btn_Grid10";
            this.btn_Grid10.Size = new System.Drawing.Size(73, 65);
            this.btn_Grid10.TabIndex = 1;
            this.btn_Grid10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Grid10.UseVisualStyleBackColor = true;
            this.btn_Grid10.Click += new System.EventHandler(this.btn_Grid_Click);
            // 
            // btn_Grid
            // 
            this.btn_Grid.Location = new System.Drawing.Point(28, 25);
            this.btn_Grid.Name = "btn_Grid";
            this.btn_Grid.Size = new System.Drawing.Size(73, 65);
            this.btn_Grid.TabIndex = 0;
            this.btn_Grid.UseVisualStyleBackColor = true;
            this.btn_Grid.Click += new System.EventHandler(this.btn_Grid_Click);
            // 
            // tp_Advanced
            // 
            this.tp_Advanced.Controls.Add(this.label8);
            this.tp_Advanced.Controls.Add(this.rb_Finite);
            this.tp_Advanced.Controls.Add(this.rb_Toroidal);
            this.tp_Advanced.Location = new System.Drawing.Point(4, 25);
            this.tp_Advanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Advanced.Name = "tp_Advanced";
            this.tp_Advanced.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Advanced.Size = new System.Drawing.Size(907, 591);
            this.tp_Advanced.TabIndex = 2;
            this.tp_Advanced.Text = "Advanced";
            this.tp_Advanced.UseVisualStyleBackColor = true;
            this.tp_Advanced.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rb_Toroidal
            // 
            this.rb_Toroidal.AutoSize = true;
            this.rb_Toroidal.Location = new System.Drawing.Point(257, 101);
            this.rb_Toroidal.Name = "rb_Toroidal";
            this.rb_Toroidal.Size = new System.Drawing.Size(81, 21);
            this.rb_Toroidal.TabIndex = 0;
            this.rb_Toroidal.TabStop = true;
            this.rb_Toroidal.Text = "Toroidal";
            this.rb_Toroidal.UseVisualStyleBackColor = true;
            this.rb_Toroidal.CheckedChanged += new System.EventHandler(this.rb_Toroidal_CheckedChanged);
            // 
            // rb_Finite
            // 
            this.rb_Finite.AutoSize = true;
            this.rb_Finite.Location = new System.Drawing.Point(257, 128);
            this.rb_Finite.Name = "rb_Finite";
            this.rb_Finite.Size = new System.Drawing.Size(63, 21);
            this.rb_Finite.TabIndex = 1;
            this.rb_Finite.TabStop = true;
            this.rb_Finite.Text = "Finite";
            this.rb_Finite.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Border Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 661);
            this.Controls.Add(this.tc_Options);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tp_View.ResumeLayout(false);
            this.tp_View.PerformLayout();
            this.tp_Advanced.ResumeLayout(false);
            this.tp_Advanced.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LiveCell;
        private System.Windows.Forms.Button btn_Background;
        private System.Windows.Forms.Button btn_Grid10;
        private System.Windows.Forms.Button btn_Grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Finite;
        private System.Windows.Forms.RadioButton rb_Toroidal;
    }
}