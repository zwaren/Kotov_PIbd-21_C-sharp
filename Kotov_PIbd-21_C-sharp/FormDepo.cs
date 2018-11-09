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

		MultiLevelDepo depo;
		private const int countLevel = 5;

		public FormDepo()
		{
			InitializeComponent(); depo = new MultiLevelDepo(countLevel, pictureBoxDepo.Width, pictureBoxDepo.Height);
			for (int i = 0; i < countLevel; i++)
			{
				listBoxLevels.Items.Add("Уровень " + (i + 1));
			}
			listBoxLevels.SelectedIndex = 0;
		}

		private void Draw()
		{
			if(listBoxLevels.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
				Graphics gr = Graphics.FromImage(bmp);
				depo[listBoxLevels.SelectedIndex].Draw(gr);
				pictureBoxDepo.Image = bmp;
			}
		}

		private void buttonParkLoco_Click(object sender, EventArgs e)
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var loco = new Locomotive(100, 1000, dialog.Color);
					int place = depo[listBoxLevels.SelectedIndex] + loco;
					if (place == -1)
					{
						MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					Draw();
				}
			}
		}

		private void buttonParkSteamLoco_Click(object sender, EventArgs e)
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var loco = new SteamLocomotiveWithBumper(100, 1000, dialog.Color, dialogDop.Color, true, true);
						int place = depo[listBoxLevels.SelectedIndex] + loco;
						if (place == -1)
						{
							MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						Draw();
					}
				}
			}
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				if (maskedTextBoxPlace.Text != "")
				{
					var loco = depo[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
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

		private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
	}
}
