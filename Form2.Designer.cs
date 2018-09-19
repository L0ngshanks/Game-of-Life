namespace Game_of_Life
{
    partial class Form2
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
            this.button1Cancel = new System.Windows.Forms.Button();
            this.button2Ok = new System.Windows.Forms.Button();
            this.button1NewSeed = new System.Windows.Forms.Button();
            this.numericUpDown1_NewSeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_NewSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Cancel
            // 
            this.button1Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1Cancel.Location = new System.Drawing.Point(216, 53);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(75, 23);
            this.button1Cancel.TabIndex = 0;
            this.button1Cancel.Text = "Cancel";
            this.button1Cancel.UseVisualStyleBackColor = true;
            this.button1Cancel.Click += new System.EventHandler(this.button1Cancel_Click);
            // 
            // button2Ok
            // 
            this.button2Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2Ok.Location = new System.Drawing.Point(135, 53);
            this.button2Ok.Name = "button2Ok";
            this.button2Ok.Size = new System.Drawing.Size(75, 23);
            this.button2Ok.TabIndex = 1;
            this.button2Ok.Text = "Ok";
            this.button2Ok.UseVisualStyleBackColor = true;
            this.button2Ok.Click += new System.EventHandler(this.button2Ok_Click);
            // 
            // button1NewSeed
            // 
            this.button1NewSeed.Location = new System.Drawing.Point(13, 13);
            this.button1NewSeed.Name = "button1NewSeed";
            this.button1NewSeed.Size = new System.Drawing.Size(75, 23);
            this.button1NewSeed.TabIndex = 2;
            this.button1NewSeed.Text = "New Seed";
            this.button1NewSeed.UseVisualStyleBackColor = true;
            this.button1NewSeed.Click += new System.EventHandler(this.button1NewSeed_Click);
            // 
            // numericUpDown1_NewSeed
            // 
            this.numericUpDown1_NewSeed.Location = new System.Drawing.Point(95, 14);
            this.numericUpDown1_NewSeed.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown1_NewSeed.Name = "numericUpDown1_NewSeed";
            this.numericUpDown1_NewSeed.ReadOnly = true;
            this.numericUpDown1_NewSeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_NewSeed.TabIndex = 3;
            // 
            // Form2
            // 
            this.AcceptButton = this.button2Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1Cancel;
            this.ClientSize = new System.Drawing.Size(303, 88);
            this.Controls.Add(this.numericUpDown1_NewSeed);
            this.Controls.Add(this.button1NewSeed);
            this.Controls.Add(this.button2Ok);
            this.Controls.Add(this.button1Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "New Seed";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_NewSeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.Button button2Ok;
        private System.Windows.Forms.Button button1NewSeed;
        private System.Windows.Forms.NumericUpDown numericUpDown1_NewSeed;
    }
}