namespace Game_of_Life
{
    partial class ModalDialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1Dead = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button3Alive = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2BGColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1CellColor = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nud_TimerInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1syncXY = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2UniversalY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1UniversalX = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rb_Finite = new System.Windows.Forms.RadioButton();
            this.rb_Toroidal = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerInterval)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2UniversalY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1UniversalX)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Cancel
            // 
            this.button1Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1Cancel.Location = new System.Drawing.Point(197, 366);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(75, 27);
            this.button1Cancel.TabIndex = 0;
            this.button1Cancel.Text = "Cancel";
            this.button1Cancel.UseVisualStyleBackColor = true;
            this.button1Cancel.Click += new System.EventHandler(this.button1Cancel_Click);
            // 
            // button2Ok
            // 
            this.button2Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2Ok.Location = new System.Drawing.Point(116, 366);
            this.button2Ok.Name = "button2Ok";
            this.button2Ok.Size = new System.Drawing.Size(75, 27);
            this.button2Ok.TabIndex = 1;
            this.button2Ok.Text = "Ok";
            this.button2Ok.UseVisualStyleBackColor = true;
            this.button2Ok.Click += new System.EventHandler(this.button2Ok_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 347);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(243, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Color";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Location = new System.Drawing.Point(6, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 122);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button1Dead);
            this.groupBox8.Location = new System.Drawing.Point(7, 68);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(140, 48);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Dead";
            // 
            // button1Dead
            // 
            this.button1Dead.Location = new System.Drawing.Point(5, 19);
            this.button1Dead.Name = "button1Dead";
            this.button1Dead.Size = new System.Drawing.Size(128, 23);
            this.button1Dead.TabIndex = 1;
            this.button1Dead.UseVisualStyleBackColor = true;
            this.button1Dead.Click += new System.EventHandler(this.button1Dead_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3Alive);
            this.groupBox7.Location = new System.Drawing.Point(6, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(140, 48);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Alive";
            // 
            // button3Alive
            // 
            this.button3Alive.Location = new System.Drawing.Point(6, 19);
            this.button3Alive.Name = "button3Alive";
            this.button3Alive.Size = new System.Drawing.Size(128, 23);
            this.button3Alive.TabIndex = 0;
            this.button3Alive.UseVisualStyleBackColor = true;
            this.button3Alive.Click += new System.EventHandler(this.button3Alive_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2BGColor);
            this.groupBox3.Location = new System.Drawing.Point(6, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Background";
            // 
            // button2BGColor
            // 
            this.button2BGColor.Location = new System.Drawing.Point(7, 19);
            this.button2BGColor.Name = "button2BGColor";
            this.button2BGColor.Size = new System.Drawing.Size(141, 23);
            this.button2BGColor.TabIndex = 0;
            this.button2BGColor.UseVisualStyleBackColor = true;
            this.button2BGColor.Click += new System.EventHandler(this.button2BGColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1CellColor);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cell";
            // 
            // button1CellColor
            // 
            this.button1CellColor.Location = new System.Drawing.Point(7, 20);
            this.button1CellColor.Name = "button1CellColor";
            this.button1CellColor.Size = new System.Drawing.Size(141, 23);
            this.button1CellColor.TabIndex = 0;
            this.button1CellColor.UseVisualStyleBackColor = true;
            this.button1CellColor.Click += new System.EventHandler(this.button1CellColor_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(243, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Universe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nud_TimerInterval);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(9, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 54);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Time Interval";
            // 
            // nud_TimerInterval
            // 
            this.nud_TimerInterval.Location = new System.Drawing.Point(79, 19);
            this.nud_TimerInterval.Name = "nud_TimerInterval";
            this.nud_TimerInterval.Size = new System.Drawing.Size(120, 20);
            this.nud_TimerInterval.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Timer Interval";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1syncXY);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.numericUpDown2UniversalY);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.numericUpDown1UniversalX);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 113);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Universe Size";
            // 
            // checkBox1syncXY
            // 
            this.checkBox1syncXY.AutoSize = true;
            this.checkBox1syncXY.Checked = true;
            this.checkBox1syncXY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1syncXY.Location = new System.Drawing.Point(83, 81);
            this.checkBox1syncXY.Name = "checkBox1syncXY";
            this.checkBox1syncXY.Size = new System.Drawing.Size(119, 17);
            this.checkBox1syncXY.TabIndex = 4;
            this.checkBox1syncXY.Text = "Syncronize X and Y";
            this.checkBox1syncXY.UseVisualStyleBackColor = true;
            this.checkBox1syncXY.CheckedChanged += new System.EventHandler(this.checkBox1syncXY_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Universe Y";
            // 
            // numericUpDown2UniversalY
            // 
            this.numericUpDown2UniversalY.Location = new System.Drawing.Point(83, 54);
            this.numericUpDown2UniversalY.Name = "numericUpDown2UniversalY";
            this.numericUpDown2UniversalY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2UniversalY.TabIndex = 2;
            this.numericUpDown2UniversalY.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2UniversalY.ValueChanged += new System.EventHandler(this.numericUpDown2UniversalY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universe X";
            // 
            // numericUpDown1UniversalX
            // 
            this.numericUpDown1UniversalX.Location = new System.Drawing.Point(83, 23);
            this.numericUpDown1UniversalX.Name = "numericUpDown1UniversalX";
            this.numericUpDown1UniversalX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1UniversalX.TabIndex = 0;
            this.numericUpDown1UniversalX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1UniversalX.ValueChanged += new System.EventHandler(this.numericUpDown1UniversalX_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(243, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.rb_Toroidal);
            this.groupBox9.Controls.Add(this.rb_Finite);
            this.groupBox9.Location = new System.Drawing.Point(12, 14);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(219, 88);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Boundary Type";
            // 
            // rb_Finite
            // 
            this.rb_Finite.AutoSize = true;
            this.rb_Finite.Checked = true;
            this.rb_Finite.Location = new System.Drawing.Point(7, 20);
            this.rb_Finite.Name = "rb_Finite";
            this.rb_Finite.Size = new System.Drawing.Size(50, 17);
            this.rb_Finite.TabIndex = 0;
            this.rb_Finite.TabStop = true;
            this.rb_Finite.Text = "Finite";
            this.rb_Finite.UseVisualStyleBackColor = true;
            // 
            // rb_Toroidal
            // 
            this.rb_Toroidal.AutoSize = true;
            this.rb_Toroidal.Location = new System.Drawing.Point(7, 44);
            this.rb_Toroidal.Name = "rb_Toroidal";
            this.rb_Toroidal.Size = new System.Drawing.Size(63, 17);
            this.rb_Toroidal.TabIndex = 1;
            this.rb_Toroidal.Text = "Toroidal";
            this.rb_Toroidal.UseVisualStyleBackColor = true;
            // 
            // ModalDialog
            // 
            this.AcceptButton = this.button2Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button1Cancel;
            this.ClientSize = new System.Drawing.Size(282, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2Ok);
            this.Controls.Add(this.button1Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialog";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimerInterval)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2UniversalY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1UniversalX)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.Button button2Ok;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3Alive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2BGColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1CellColor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2UniversalY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1UniversalX;
        private System.Windows.Forms.CheckBox checkBox1syncXY;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nud_TimerInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button1Dead;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rb_Toroidal;
        private System.Windows.Forms.RadioButton rb_Finite;
    }
}