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
			this.monitorpanel = new System.Windows.Forms.Panel();
			this.ment = new System.Windows.Forms.Button();
			this.időlabel = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Button();
			this.ujb_panel = new System.Windows.Forms.Panel();
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
			this.monitorpanel.SuspendLayout();
			this.ujb_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// monitorpanel
			// 
			this.monitorpanel.BackColor = System.Drawing.SystemColors.Control;
			this.monitorpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.monitorpanel.Controls.Add(this.ment);
			this.monitorpanel.Controls.Add(this.időlabel);
			this.monitorpanel.Controls.Add(this.start);
			this.monitorpanel.Location = new System.Drawing.Point(12, 12);
			this.monitorpanel.Name = "monitorpanel";
			this.monitorpanel.Size = new System.Drawing.Size(768, 114);
			this.monitorpanel.TabIndex = 0;
			// 
			// ment
			// 
			this.ment.Location = new System.Drawing.Point(3, 39);
			this.ment.Name = "ment";
			this.ment.Size = new System.Drawing.Size(89, 30);
			this.ment.TabIndex = 2;
			this.ment.Text = "MENT";
			this.ment.UseVisualStyleBackColor = true;
			this.ment.Click += new System.EventHandler(this.ment_Click);
			// 
			// időlabel
			// 
			this.időlabel.AutoSize = true;
			this.időlabel.Location = new System.Drawing.Point(37, 81);
			this.időlabel.Name = "időlabel";
			this.időlabel.Size = new System.Drawing.Size(16, 17);
			this.időlabel.TabIndex = 1;
			this.időlabel.Text = "0";
			// 
			// start
			// 
			this.start.Location = new System.Drawing.Point(3, 3);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(89, 30);
			this.start.TabIndex = 0;
			this.start.Text = "START";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// ujb_panel
			// 
			this.ujb_panel.BackColor = System.Drawing.SystemColors.Control;
			this.ujb_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ujb_panel.Controls.Add(this.szin_textBox);
			this.ujb_panel.Controls.Add(this.ujb_cimlabel);
			this.ujb_panel.Controls.Add(this.ujb_Peldabolygok);
			this.ujb_panel.Controls.Add(this.ujb_szinlabel);
			this.ujb_panel.Controls.Add(this.ujb_ujbolygo);
			this.ujb_panel.Controls.Add(this.ujb_tomege);
			this.ujb_panel.Controls.Add(this.ujb_speed);
			this.ujb_panel.Controls.Add(this.ujb_irany);
			this.ujb_panel.Controls.Add(this.ujb_helyey);
			this.ujb_panel.Controls.Add(this.ujb_helyex);
			this.ujb_panel.Controls.Add(this.ujb_neve);
			this.ujb_panel.Controls.Add(this.ujb_tomeglabel);
			this.ujb_panel.Controls.Add(this.ujb_sebesseglabel);
			this.ujb_panel.Controls.Add(this.ujb_helylabel);
			this.ujb_panel.Controls.Add(this.ujb_nevlabel);
			this.ujb_panel.Location = new System.Drawing.Point(1182, 12);
			this.ujb_panel.Name = "ujb_panel";
			this.ujb_panel.Size = new System.Drawing.Size(324, 261);
			this.ujb_panel.TabIndex = 1;
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
			this.metronom.Interval = 10;
			this.metronom.Tick += new System.EventHandler(this.metronom_Tick);
			// 
			// GravSzim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1528, 552);
			this.Controls.Add(this.ujb_panel);
			this.Controls.Add(this.monitorpanel);
			this.Name = "GravSzim";
			this.Text = "Gravitációs szimuláció";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.monitorpanel.ResumeLayout(false);
			this.monitorpanel.PerformLayout();
			this.ujb_panel.ResumeLayout(false);
			this.ujb_panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel monitorpanel;
		private System.Windows.Forms.Label időlabel;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Panel ujb_panel;
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
		private System.Windows.Forms.Button ment;
	}
}

