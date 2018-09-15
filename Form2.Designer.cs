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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5Cancel = new System.Windows.Forms.Button();
            this.button4OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3TextColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2BGColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1CellColor = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 331);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5Cancel);
            this.tabPage1.Controls.Add(this.button4OK);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5Cancel
            // 
            this.button5Cancel.Location = new System.Drawing.Point(186, 274);
            this.button5Cancel.Name = "button5Cancel";
            this.button5Cancel.Size = new System.Drawing.Size(75, 23);
            this.button5Cancel.TabIndex = 2;
            this.button5Cancel.Text = "Cancel";
            this.button5Cancel.UseVisualStyleBackColor = true;
            this.button5Cancel.Click += new System.EventHandler(this.button5Cancel_Click);
            // 
            // button4OK
            // 
            this.button4OK.Location = new System.Drawing.Point(105, 274);
            this.button4OK.Name = "button4OK";
            this.button4OK.Size = new System.Drawing.Size(75, 23);
            this.button4OK.TabIndex = 1;
            this.button4OK.Text = "OK";
            this.button4OK.UseVisualStyleBackColor = true;
            this.button4OK.Click += new System.EventHandler(this.button4OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3TextColor);
            this.groupBox4.Location = new System.Drawing.Point(7, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 51);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text Color";
            // 
            // button3TextColor
            // 
            this.button3TextColor.Location = new System.Drawing.Point(7, 19);
            this.button3TextColor.Name = "button3TextColor";
            this.button3TextColor.Size = new System.Drawing.Size(104, 24);
            this.button3TextColor.TabIndex = 0;
            this.button3TextColor.UseVisualStyleBackColor = true;
            this.button3TextColor.Click += new System.EventHandler(this.button3TextColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2BGColor);
            this.groupBox3.Location = new System.Drawing.Point(7, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 51);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Universe Color";
            // 
            // button2BGColor
            // 
            this.button2BGColor.Location = new System.Drawing.Point(7, 19);
            this.button2BGColor.Name = "button2BGColor";
            this.button2BGColor.Size = new System.Drawing.Size(104, 24);
            this.button2BGColor.TabIndex = 0;
            this.button2BGColor.UseVisualStyleBackColor = true;
            this.button2BGColor.Click += new System.EventHandler(this.button2BGColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1CellColor);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 51);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cell Color";
            // 
            // button1CellColor
            // 
            this.button1CellColor.Location = new System.Drawing.Point(6, 19);
            this.button1CellColor.Name = "button1CellColor";
            this.button1CellColor.Size = new System.Drawing.Size(105, 23);
            this.button1CellColor.TabIndex = 0;
            this.button1CellColor.UseVisualStyleBackColor = true;
            this.button1CellColor.Click += new System.EventHandler(this.button1CellColor_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 331);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5Cancel;
        private System.Windows.Forms.Button button4OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3TextColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2BGColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1CellColor;
    }
}