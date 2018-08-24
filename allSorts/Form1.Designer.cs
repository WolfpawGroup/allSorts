using System.Windows.Forms;

namespace allSorts
{
	partial class Form1
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.tb_End = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tb_End)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Bubble Sort",
            "Bubble Sort v2",
            "Quicksort",
            "Pigeonhole Sort"});
			this.comboBox1.Location = new System.Drawing.Point(12, 532);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(147, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(165, 532);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 21);
			this.button1.TabIndex = 1;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Fix number array (0 to end)",
            "Fix number array worst case (end to 0)",
            "Fix string Array (aaaa to end)",
            "Random number array (start to end)",
            "Random number array worst case (end to start)"});
			this.comboBox2.Location = new System.Drawing.Point(12, 559);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(147, 21);
			this.comboBox2.TabIndex = 2;
			// 
			// tb_End
			// 
			this.tb_End.AutoSize = false;
			this.tb_End.Location = new System.Drawing.Point(53, 586);
			this.tb_End.Maximum = 9999;
			this.tb_End.Minimum = 10;
			this.tb_End.Name = "tb_End";
			this.tb_End.Size = new System.Drawing.Size(106, 24);
			this.tb_End.TabIndex = 3;
			this.tb_End.TickFrequency = 0;
			this.tb_End.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tb_End.Value = 20;
			this.tb_End.ValueChanged += new System.EventHandler(this.tb_End_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(165, 592);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "20";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 562);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Bubble sort with Random number array";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 592);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Length: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 619);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.tb_End);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.tb_End)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox comboBox1;
		private Button button1;
		private ComboBox comboBox2;
		private TrackBar tb_End;
		private Label label2;
		private Label label1;
		private Label label3;
	}
}

