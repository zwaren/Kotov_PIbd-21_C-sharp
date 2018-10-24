namespace Kotov_PIbd_21_C_sharp
{
	partial class FormDepo
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
			this.pictureBoxDepo = new System.Windows.Forms.PictureBox();
			this.buttonParkLoco = new System.Windows.Forms.Button();
			this.buttonParkSteeamLoco = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBoxLocomotive = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
			this.buttonTake = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxDepo
			// 
			this.pictureBoxDepo.Location = new System.Drawing.Point(13, 13);
			this.pictureBoxDepo.Name = "pictureBoxDepo";
			this.pictureBoxDepo.Size = new System.Drawing.Size(622, 386);
			this.pictureBoxDepo.TabIndex = 0;
			this.pictureBoxDepo.TabStop = false;
			// 
			// buttonParkLoco
			// 
			this.buttonParkLoco.Location = new System.Drawing.Point(641, 13);
			this.buttonParkLoco.Name = "buttonParkLoco";
			this.buttonParkLoco.Size = new System.Drawing.Size(131, 36);
			this.buttonParkLoco.TabIndex = 1;
			this.buttonParkLoco.Text = "Припарковать локомотив";
			this.buttonParkLoco.UseVisualStyleBackColor = true;
			this.buttonParkLoco.Click += new System.EventHandler(this.buttonParkLoco_Click);
			// 
			// buttonParkSteeamLoco
			// 
			this.buttonParkSteeamLoco.Location = new System.Drawing.Point(641, 55);
			this.buttonParkSteeamLoco.Name = "buttonParkSteeamLoco";
			this.buttonParkSteeamLoco.Size = new System.Drawing.Size(131, 37);
			this.buttonParkSteeamLoco.TabIndex = 2;
			this.buttonParkSteeamLoco.Text = "Припарковать паровой локомотив";
			this.buttonParkSteeamLoco.UseVisualStyleBackColor = true;
			this.buttonParkSteeamLoco.Click += new System.EventHandler(this.buttonParkSteeamLoco_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTake);
			this.groupBox1.Controls.Add(this.maskedTextBoxPlace);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pictureBoxLocomotive);
			this.groupBox1.Location = new System.Drawing.Point(641, 230);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(131, 169);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать локомотив";
			// 
			// pictureBoxLocomotive
			// 
			this.pictureBoxLocomotive.Location = new System.Drawing.Point(7, 101);
			this.pictureBoxLocomotive.Name = "pictureBoxLocomotive";
			this.pictureBoxLocomotive.Size = new System.Drawing.Size(118, 62);
			this.pictureBoxLocomotive.TabIndex = 0;
			this.pictureBoxLocomotive.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Место:";
			// 
			// maskedTextBoxPlace
			// 
			this.maskedTextBoxPlace.Location = new System.Drawing.Point(55, 29);
			this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
			this.maskedTextBoxPlace.Size = new System.Drawing.Size(70, 20);
			this.maskedTextBoxPlace.TabIndex = 5;
			// 
			// buttonTake
			// 
			this.buttonTake.Location = new System.Drawing.Point(7, 58);
			this.buttonTake.Name = "buttonTake";
			this.buttonTake.Size = new System.Drawing.Size(118, 23);
			this.buttonTake.TabIndex = 6;
			this.buttonTake.Text = "Забрать";
			this.buttonTake.UseVisualStyleBackColor = true;
			this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
			// 
			// FormDepo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonParkSteeamLoco);
			this.Controls.Add(this.buttonParkLoco);
			this.Controls.Add(this.pictureBoxDepo);
			this.Name = "FormDepo";
			this.Text = "Депо";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxDepo;
		private System.Windows.Forms.Button buttonParkLoco;
		private System.Windows.Forms.Button buttonParkSteeamLoco;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBoxLocomotive;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
		private System.Windows.Forms.Label label1;
	}
}