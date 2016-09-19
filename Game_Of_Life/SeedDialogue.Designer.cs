namespace Game_Of_Life
{
    partial class SeedDialogue
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
            this.btn_Randomize = new System.Windows.Forms.Button();
            this.nud_Seed = new System.Windows.Forms.NumericUpDown();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Seed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Randomize
            // 
            this.btn_Randomize.Location = new System.Drawing.Point(297, 31);
            this.btn_Randomize.Name = "btn_Randomize";
            this.btn_Randomize.Size = new System.Drawing.Size(75, 23);
            this.btn_Randomize.TabIndex = 0;
            this.btn_Randomize.Text = "Randomize";
            this.btn_Randomize.UseVisualStyleBackColor = true;
            this.btn_Randomize.Click += new System.EventHandler(this.btn_Randomize_Click);
            // 
            // nud_Seed
            // 
            this.nud_Seed.Location = new System.Drawing.Point(47, 34);
            this.nud_Seed.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nud_Seed.Name = "nud_Seed";
            this.nud_Seed.Size = new System.Drawing.Size(244, 20);
            this.nud_Seed.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(216, 92);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(297, 92);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SeedDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 127);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.nud_Seed);
            this.Controls.Add(this.btn_Randomize);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SeedDialogue";
            this.Text = "SeedDialogue";
            this.Load += new System.EventHandler(this.SeedDialogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Seed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Randomize;
        private System.Windows.Forms.NumericUpDown nud_Seed;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}