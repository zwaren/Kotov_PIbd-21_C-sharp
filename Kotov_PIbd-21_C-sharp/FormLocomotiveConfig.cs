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
	public partial class FormLocomotiveConfig : Form
	{
		ITransport loco = null;

		private event locoDelegate eventAddLoco;

		public FormLocomotiveConfig()
		{
			InitializeComponent();
			panelBlack.MouseDown += panelColor_MouseDown;
			panelFuchsia.MouseDown += panelColor_MouseDown;
			panelSilver.MouseDown += panelColor_MouseDown;
			panelLime.MouseDown += panelColor_MouseDown;
			panelAqua.MouseDown += panelColor_MouseDown;
			panelRed.MouseDown += panelColor_MouseDown;
			panelYellow.MouseDown += panelColor_MouseDown;
			panelBlue.MouseDown += panelColor_MouseDown;
			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawLoco()
		{
			if (loco != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxLoco.Width, pictureBoxLoco.Height);
				Graphics gr = Graphics.FromImage(bmp);
				loco.SetPosition(5, 5, pictureBoxLoco.Width, pictureBoxLoco.Height);
				loco.DrawTransport(gr);
				pictureBoxLoco.Image = bmp;
			}
		}

		public void AddEvent(locoDelegate ev)
		{
			if (eventAddLoco == null)
			{
				eventAddLoco = new locoDelegate(ev);
			}
			else
			{
				eventAddLoco += ev;
			}
		}

		private void labelLoco_MouseDown(object sender, MouseEventArgs e)
		{
			labelLoco.DoDragDrop(labelLoco.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelSteamLoco_MouseDown(object sender, MouseEventArgs e)
		{
			labelSteamLoco.DoDragDrop(labelSteamLoco.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panelLocomotive_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelLocomotive_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "labelLoco":
					loco = new Locomotive(100, 500, Color.White);
					break;
				case "labelSteamLoco":
					loco = new SteamLocomotiveWithBumper(100, 500, Color.White, Color.Black, true, true);
					break;
			}
			DrawLoco();
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			(sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (loco != null)
			{
				loco.SetMainColor((Color)e.Data.GetData(typeof(Color)));
				DrawLoco();
			}
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (loco != null)
			{
				if (loco is SteamLocomotiveWithBumper)
				{
					(loco as SteamLocomotiveWithBumper).SetDopColor((Color)e.Data.GetData(typeof(Color)));
					DrawLoco();
				}
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			eventAddLoco?.Invoke(loco);
			Close();
		}
	}
}
