namespace Kotov_PIbd_21_C_sharp
{
	partial class FormLocomotiveConfig
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
			this.groupBoxLocoType = new System.Windows.Forms.GroupBox();
			this.labelLoco = new System.Windows.Forms.Label();
			this.pictureBoxLoco = new System.Windows.Forms.PictureBox();
			this.labelSteamLoco = new System.Windows.Forms.Label();
			this.panelLocomotive = new System.Windows.Forms.Panel();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelLime = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelFuchsia = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.panelAqua = new System.Windows.Forms.Panel();
			this.panelSilver = new System.Windows.Forms.Panel();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxLocoType.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoco)).BeginInit();
			this.panelLocomotive.SuspendLayout();
			this.groupBoxColors.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxLocoType
			// 
			this.groupBoxLocoType.Controls.Add(this.labelSteamLoco);
			this.groupBoxLocoType.Controls.Add(this.labelLoco);
			this.groupBoxLocoType.Location = new System.Drawing.Point(13, 13);
			this.groupBoxLocoType.Name = "groupBoxLocoType";
			this.groupBoxLocoType.Size = new System.Drawing.Size(179, 150);
			this.groupBoxLocoType.TabIndex = 0;
			this.groupBoxLocoType.TabStop = false;
			this.groupBoxLocoType.Text = "Тип локомотива";
			// 
			// labelLoco
			// 
			this.labelLoco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelLoco.Location = new System.Drawing.Point(7, 20);
			this.labelLoco.Name = "labelLoco";
			this.labelLoco.Size = new System.Drawing.Size(166, 55);
			this.labelLoco.TabIndex = 0;
			this.labelLoco.Text = "labelLoco";
			this.labelLoco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLoco.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLoco_MouseDown);
			// 
			// pictureBoxLoco
			// 
			this.pictureBoxLoco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxLoco.Location = new System.Drawing.Point(17, 20);
			this.pictureBoxLoco.Name = "pictureBoxLoco";
			this.pictureBoxLoco.Size = new System.Drawing.Size(184, 104);
			this.pictureBoxLoco.TabIndex = 1;
			this.pictureBoxLoco.TabStop = false;
			// 
			// labelSteamLoco
			// 
			this.labelSteamLoco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSteamLoco.Location = new System.Drawing.Point(6, 84);
			this.labelSteamLoco.Name = "labelSteamLoco";
			this.labelSteamLoco.Size = new System.Drawing.Size(167, 54);
			this.labelSteamLoco.TabIndex = 1;
			this.labelSteamLoco.Text = "labelSteamLoco";
			this.labelSteamLoco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSteamLoco.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSteamLoco_MouseDown);
			// 
			// panelLocomotive
			// 
			this.panelLocomotive.AllowDrop = true;
			this.panelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLocomotive.Controls.Add(this.labelDopColor);
			this.panelLocomotive.Controls.Add(this.labelBaseColor);
			this.panelLocomotive.Controls.Add(this.pictureBoxLoco);
			this.panelLocomotive.Location = new System.Drawing.Point(199, 13);
			this.panelLocomotive.Name = "panelLocomotive";
			this.panelLocomotive.Size = new System.Drawing.Size(222, 279);
			this.panelLocomotive.TabIndex = 2;
			this.panelLocomotive.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragDrop);
			this.panelLocomotive.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragEnter);
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.panelBlue);
			this.groupBoxColors.Controls.Add(this.panelSilver);
			this.groupBoxColors.Controls.Add(this.panelAqua);
			this.groupBoxColors.Controls.Add(this.panelRed);
			this.groupBoxColors.Controls.Add(this.panelFuchsia);
			this.groupBoxColors.Controls.Add(this.panelYellow);
			this.groupBoxColors.Controls.Add(this.panelLime);
			this.groupBoxColors.Controls.Add(this.panelBlack);
			this.groupBoxColors.Location = new System.Drawing.Point(428, 13);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(135, 279);
			this.groupBoxColors.TabIndex = 3;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Цвета";
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.Location = new System.Drawing.Point(7, 20);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(56, 55);
			this.panelBlack.TabIndex = 0;
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelLime
			// 
			this.panelLime.BackColor = System.Drawing.Color.Lime;
			this.panelLime.Location = new System.Drawing.Point(69, 21);
			this.panelLime.Name = "panelLime";
			this.panelLime.Size = new System.Drawing.Size(56, 55);
			this.panelLime.TabIndex = 1;
			this.panelLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.Location = new System.Drawing.Point(7, 81);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(56, 55);
			this.panelYellow.TabIndex = 1;
			this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelFuchsia
			// 
			this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
			this.panelFuchsia.Location = new System.Drawing.Point(69, 82);
			this.panelFuchsia.Name = "panelFuchsia";
			this.panelFuchsia.Size = new System.Drawing.Size(56, 55);
			this.panelFuchsia.TabIndex = 1;
			this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.Location = new System.Drawing.Point(7, 142);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(56, 55);
			this.panelRed.TabIndex = 1;
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelAqua
			// 
			this.panelAqua.BackColor = System.Drawing.Color.Aqua;
			this.panelAqua.Location = new System.Drawing.Point(69, 143);
			this.panelAqua.Name = "panelAqua";
			this.panelAqua.Size = new System.Drawing.Size(56, 55);
			this.panelAqua.TabIndex = 1;
			this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelSilver
			// 
			this.panelSilver.BackColor = System.Drawing.Color.Silver;
			this.panelSilver.Location = new System.Drawing.Point(7, 203);
			this.panelSilver.Name = "panelSilver";
			this.panelSilver.Size = new System.Drawing.Size(56, 55);
			this.panelSilver.TabIndex = 1;
			this.panelSilver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.Location = new System.Drawing.Point(69, 203);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(56, 55);
			this.panelBlue.TabIndex = 1;
			this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(17, 142);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(184, 55);
			this.labelBaseColor.TabIndex = 2;
			this.labelBaseColor.Text = "label1";
			this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(17, 202);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(184, 55);
			this.labelDopColor.TabIndex = 3;
			this.labelDopColor.Text = "label2";
			this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(20, 186);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(20, 216);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormLocomotiveConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 306);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.panelLocomotive);
			this.Controls.Add(this.groupBoxLocoType);
			this.Name = "FormLocomotiveConfig";
			this.Text = "FormLocomotiveConfig";
			this.groupBoxLocoType.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoco)).EndInit();
			this.panelLocomotive.ResumeLayout(false);
			this.groupBoxColors.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxLocoType;
		private System.Windows.Forms.Label labelLoco;
		private System.Windows.Forms.Label labelSteamLoco;
		private System.Windows.Forms.PictureBox pictureBoxLoco;
		private System.Windows.Forms.Panel panelLocomotive;
		private System.Windows.Forms.GroupBox groupBoxColors;
		private System.Windows.Forms.Panel panelBlue;
		private System.Windows.Forms.Panel panelSilver;
		private System.Windows.Forms.Panel panelAqua;
		private System.Windows.Forms.Panel panelRed;
		private System.Windows.Forms.Panel panelFuchsia;
		private System.Windows.Forms.Panel panelYellow;
		private System.Windows.Forms.Panel panelLime;
		private System.Windows.Forms.Panel panelBlack;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelBaseColor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonCancel;
	}
}