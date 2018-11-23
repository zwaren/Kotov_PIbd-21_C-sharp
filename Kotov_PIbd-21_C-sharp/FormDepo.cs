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

		FormLocomotiveConfig form;

		private const int countLevel = 5;

		public FormDepo()
		{
			InitializeComponent();
			depo = new MultiLevelDepo(countLevel, pictureBoxDepo.Width, pictureBoxDepo.Height);
			for (int i = 0; i < countLevel; i++)
			{
				listBoxLevels.Items.Add("Уровень " + (i + 1));
			}
			listBoxLevels.SelectedIndex = 0;
		}

		private void Draw()
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
				Graphics gr = Graphics.FromImage(bmp);
				depo[listBoxLevels.SelectedIndex].Draw(gr);
				pictureBoxDepo.Image = bmp;
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

		private void buttonSetLoco_Click(object sender, EventArgs e)
		{
			form = new FormLocomotiveConfig();
			form.AddEvent(AddLoco);
			form.Show();
		}

		private void AddLoco(ITransport loco)
		{
			if (loco != null && listBoxLevels.SelectedIndex > -1)
			{
				int place = depo[listBoxLevels.SelectedIndex] + loco;
				if (place > -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Локомотив не удалось поставить");
				}
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (depo.SaveData(saveFileDialog.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "Результат",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (depo.LoadData(openFileDialog.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				Draw();
			}
		}
	}
}
