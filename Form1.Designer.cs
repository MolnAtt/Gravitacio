namespace Gravitáció
{
	partial class GravSzim
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.időlabel = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.szin_textBox = new System.Windows.Forms.TextBox();
			this.ujb_cimlabel = new System.Windows.Forms.Label();
			this.ujb_Peldabolygok = new System.Windows.Forms.Button();
			this.ujb_szinlabel = new System.Windows.Forms.Label();
			this.ujb_ujbolygo = new System.Windows.Forms.Button();
			this.ujb_tomege = new System.Windows.Forms.TextBox();
			this.ujb_speed = new System.Windows.Forms.TextBox();
			this.ujb_irany = new System.Windows.Forms.TextBox();
			this.ujb_helyey = new System.Windows.Forms.TextBox();
			this.ujb_helyex = new System.Windows.Forms.TextBox();
			this.ujb_neve = new System.Windows.Forms.TextBox();
			this.ujb_tomeglabel = new System.Windows.Forms.Label();
			this.ujb_sebesseglabel = new System.Windows.Forms.Label();
			this.ujb_helylabel = new System.Windows.Forms.Label();
			this.ujb_nevlabel = new System.Windows.Forms.Label();
			this.szinvalasztas = new System.Windows.Forms.ColorDialog();
			this.metronom = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.időlabel);
			this.panel1.Controls.Add(this.start);
			this.panel1.Location = new System.Drawing.Point(1345, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 69);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Monitor";
			// 
			// időlabel
			// 
			this.időlabel.AutoSize = true;
			this.időlabel.Location = new System.Drawing.Point(102, 33);
			this.időlabel.Name = "időlabel";
			this.időlabel.Size = new System.Drawing.Size(16, 17);
			this.időlabel.TabIndex = 1;
			this.időlabel.Text = "0";
			// 
			// start
			// 
			this.start.Location = new System.Drawing.Point(7, 26);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(89, 30);
			this.start.TabIndex = 0;
			this.start.Text = "START";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.szin_textBox);
			this.panel2.Controls.Add(this.ujb_cimlabel);
			this.panel2.Controls.Add(this.ujb_Peldabolygok);
			this.panel2.Controls.Add(this.ujb_szinlabel);
			this.panel2.Controls.Add(this.ujb_ujbolygo);
			this.panel2.Controls.Add(this.ujb_tomege);
			this.panel2.Controls.Add(this.ujb_speed);
			this.panel2.Controls.Add(this.ujb_irany);
			this.panel2.Controls.Add(this.ujb_helyey);
			this.panel2.Controls.Add(this.ujb_helyex);
			this.panel2.Controls.Add(this.ujb_neve);
			this.panel2.Controls.Add(this.ujb_tomeglabel);
			this.panel2.Controls.Add(this.ujb_sebesseglabel);
			this.panel2.Controls.Add(this.ujb_helylabel);
			this.panel2.Controls.Add(this.ujb_nevlabel);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(324, 261);
			this.panel2.TabIndex = 1;
			// 
			// szin_textBox
			// 
			this.szin_textBox.Location = new System.Drawing.Point(208, 143);
			this.szin_textBox.Name = "szin_textBox";
			this.szin_textBox.Size = new System.Drawing.Size(100, 22);
			this.szin_textBox.TabIndex = 15;
			this.szin_textBox.Text = "Szín";
			// 
			// ujb_cimlabel
			// 
			this.ujb_cimlabel.AutoSize = true;
			this.ujb_cimlabel.Location = new System.Drawing.Point(102, 6);
			this.ujb_cimlabel.Name = "ujb_cimlabel";
			this.ujb_cimlabel.Size = new System.Drawing.Size(145, 17);
			this.ujb_cimlabel.TabIndex = 14;
			this.ujb_cimlabel.Text = "Új bolygó létrehozása";
			// 
			// ujb_Peldabolygok
			// 
			this.ujb_Peldabolygok.Location = new System.Drawing.Point(31, 212);
			this.ujb_Peldabolygok.Name = "ujb_Peldabolygok";
			this.ujb_Peldabolygok.Size = new System.Drawing.Size(277, 35);
			this.ujb_Peldabolygok.TabIndex = 13;
			this.ujb_Peldabolygok.Text = "Beépített példabolygók létrehozása";
			this.ujb_Peldabolygok.UseVisualStyleBackColor = true;
			this.ujb_Peldabolygok.Click += new System.EventHandler(this.Példabolygók_létrehozása_Click);
			// 
			// ujb_szinlabel
			// 
			this.ujb_szinlabel.AutoSize = true;
			this.ujb_szinlabel.Location = new System.Drawing.Point(163, 143);
			this.ujb_szinlabel.Name = "ujb_szinlabel";
			this.ujb_szinlabel.Size = new System.Drawing.Size(39, 17);
			this.ujb_szinlabel.TabIndex = 12;
			this.ujb_szinlabel.Text = "Szín:";
			// 
			// ujb_ujbolygo
			// 
			this.ujb_ujbolygo.Location = new System.Drawing.Point(31, 171);
			this.ujb_ujbolygo.Name = "ujb_ujbolygo";
			this.ujb_ujbolygo.Size = new System.Drawing.Size(277, 35);
			this.ujb_ujbolygo.TabIndex = 11;
			this.ujb_ujbolygo.Text = "Új bolygó létrehozása";
			this.ujb_ujbolygo.UseVisualStyleBackColor = true;
			this.ujb_ujbolygo.Click += new System.EventHandler(this.Új_bolygó_létrehozása_Click);
			// 
			// ujb_tomege
			// 
			this.ujb_tomege.Location = new System.Drawing.Point(208, 118);
			this.ujb_tomege.Name = "ujb_tomege";
			this.ujb_tomege.Size = new System.Drawing.Size(100, 22);
			this.ujb_tomege.TabIndex = 10;
			// 
			// ujb_speed
			// 
			this.ujb_speed.Location = new System.Drawing.Point(263, 90);
			this.ujb_speed.Name = "ujb_speed";
			this.ujb_speed.Size = new System.Drawing.Size(45, 22);
			this.ujb_speed.TabIndex = 9;
			// 
			// ujb_irany
			// 
			this.ujb_irany.Location = new System.Drawing.Point(208, 91);
			this.ujb_irany.Name = "ujb_irany";
			this.ujb_irany.Size = new System.Drawing.Size(49, 22);
			this.ujb_irany.TabIndex = 8;
			// 
			// ujb_helyey
			// 
			this.ujb_helyey.Location = new System.Drawing.Point(263, 62);
			this.ujb_helyey.Name = "ujb_helyey";
			this.ujb_helyey.Size = new System.Drawing.Size(45, 22);
			this.ujb_helyey.TabIndex = 7;
			// 
			// ujb_helyex
			// 
			this.ujb_helyex.Location = new System.Drawing.Point(208, 63);
			this.ujb_helyex.Name = "ujb_helyex";
			this.ujb_helyex.Size = new System.Drawing.Size(49, 22);
			this.ujb_helyex.TabIndex = 6;
			// 
			// ujb_neve
			// 
			this.ujb_neve.Location = new System.Drawing.Point(208, 35);
			this.ujb_neve.Name = "ujb_neve";
			this.ujb_neve.Size = new System.Drawing.Size(100, 22);
			this.ujb_neve.TabIndex = 5;
			// 
			// ujb_tomeglabel
			// 
			this.ujb_tomeglabel.AutoSize = true;
			this.ujb_tomeglabel.Location = new System.Drawing.Point(146, 121);
			this.ujb_tomeglabel.Name = "ujb_tomeglabel";
			this.ujb_tomeglabel.Size = new System.Drawing.Size(56, 17);
			this.ujb_tomeglabel.TabIndex = 4;
			this.ujb_tomeglabel.Text = "Tömeg:";
			// 
			// ujb_sebesseglabel
			// 
			this.ujb_sebesseglabel.AutoSize = true;
			this.ujb_sebesseglabel.Location = new System.Drawing.Point(28, 93);
			this.ujb_sebesseglabel.Name = "ujb_sebesseglabel";
			this.ujb_sebesseglabel.Size = new System.Drawing.Size(174, 17);
			this.ujb_sebesseglabel.TabIndex = 3;
			this.ujb_sebesseglabel.Text = "Sebességvektor (fok;seb):";
			// 
			// ujb_helylabel
			// 
			this.ujb_helylabel.AutoSize = true;
			this.ujb_helylabel.Location = new System.Drawing.Point(131, 65);
			this.ujb_helylabel.Name = "ujb_helylabel";
			this.ujb_helylabel.Size = new System.Drawing.Size(71, 17);
			this.ujb_helylabel.TabIndex = 2;
			this.ujb_helylabel.Text = "Hely (x;y):";
			// 
			// ujb_nevlabel
			// 
			this.ujb_nevlabel.AutoSize = true;
			this.ujb_nevlabel.Location = new System.Drawing.Point(165, 35);
			this.ujb_nevlabel.Name = "ujb_nevlabel";
			this.ujb_nevlabel.Size = new System.Drawing.Size(37, 17);
			this.ujb_nevlabel.TabIndex = 1;
			this.ujb_nevlabel.Text = "Név:";
			// 
			// metronom
			// 
			this.metronom.Interval = 16;
			this.metronom.Tick += new System.EventHandler(this.metronom_Tick);
			// 
			// GravSzim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1528, 552);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "GravSzim";
			this.Text = "Gravitációs szimuláció";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label időlabel;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox ujb_tomege;
		private System.Windows.Forms.TextBox ujb_speed;
		private System.Windows.Forms.TextBox ujb_irany;
		private System.Windows.Forms.TextBox ujb_helyey;
		private System.Windows.Forms.TextBox ujb_helyex;
		private System.Windows.Forms.TextBox ujb_neve;
		private System.Windows.Forms.Label ujb_tomeglabel;
		private System.Windows.Forms.Label ujb_sebesseglabel;
		private System.Windows.Forms.Label ujb_helylabel;
		private System.Windows.Forms.Label ujb_nevlabel;
		private System.Windows.Forms.Button ujb_ujbolygo;
		private System.Windows.Forms.Label ujb_szinlabel;
		private System.Windows.Forms.Button ujb_Peldabolygok;
		private System.Windows.Forms.Label ujb_cimlabel;
		private System.Windows.Forms.ColorDialog szinvalasztas;
		private System.Windows.Forms.TextBox szin_textBox;
		private System.Windows.Forms.Timer metronom;
	}
}

