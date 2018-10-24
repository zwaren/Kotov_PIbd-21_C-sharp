using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kotov_PIbd_21_C_sharp
{
	public partial class FormDepo : Form
	{

		Depo<ITransport> depo;

		public FormDepo()
		{
			InitializeComponent();
			depo = new Depo<ITransport>(20, pictureBoxDepo.Width, pictureBoxDepo.Height);
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
			Graphics gr = Graphics.FromImage(bmp);
			depo.Draw(gr);
			pictureBoxDepo.Image = bmp;
		}

		private void buttonParkLoco_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var loco = new Locomotive(100, 1000, dialog.Color);
				int place = depo + loco;
				Draw();
			}
		}

		private void buttonParkSteamLoco_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var loco = new SteamLocomotiveWithBumper(100, 1000, dialog.Color, dialogDop.Color, true, true);
					int place = depo + loco;
					Draw();
				}
			}
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (maskedTextBoxPlace.Text != "")
			{
				var loco = depo - Convert.ToInt32(maskedTextBoxPlace.Text);
				if (loco != null)
				{
					Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
					Graphics gr = Graphics.FromImage(bmp);
					loco.SetPosition(5, 5, pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
					loco.DrawTransport(gr);
					pictureBoxLocomotive.Image = bmp;
				}
				else
				{
					Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
					pictureBoxLocomotive.Image = bmp;
				}
				Draw();
			}
		}
	}
}
