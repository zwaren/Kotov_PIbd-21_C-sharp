﻿using NLog;
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
		private Logger logger;

		public FormDepo()
		{
			InitializeComponent();
			logger = LogManager.GetCurrentClassLogger();
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
					try
					{
						var loco = depo[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
						Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
						Graphics gr = Graphics.FromImage(bmp);
						loco.SetPosition(5, 5, pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
						loco.DrawTransport(gr);
						pictureBoxLocomotive.Image = bmp;
						Draw();
					}
					catch (DepoNotFoundException ex)
					{
						MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
						logger.Error(ex.Message);
						Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
						pictureBoxLocomotive.Image = bmp;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						logger.Error(ex.Message);
					}
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
				try
				{
					int place = depo[listBoxLevels.SelectedIndex] + loco;
					logger.Info("Добавлен локомотив " + loco.ToString() + " на место " + place);
					Draw();
				}
				catch (DepoOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error(ex.Message);
				}
				catch (DepoAlreadyHaveException ex)
				{
					MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error(ex.Message);
				}
			}

		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					depo.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error(ex.Message);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					depo.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
				}
				catch (DepoOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error(ex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Error(ex.Message);
				}
				Draw();
			}
		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
			depo.Sort();
			Draw();
			logger.Info("Сортировка уровней");
		}
	}
}
