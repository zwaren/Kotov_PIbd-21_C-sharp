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
	public partial class FormLocomotive : Form
	{
		private ITransport locomotive;

		public FormLocomotive()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
			Graphics gr = Graphics.FromImage(bmp);
			locomotive.DrawTransport(gr);
			pictureBoxLocomotive.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			locomotive = new Locomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			locomotive.SetPosition(rnd.Next(30, 100), rnd.Next(30, 100), pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					locomotive.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					locomotive.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					locomotive.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					locomotive.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}

		private void buttonUpgrade_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			locomotive = new SteamLocomotiveWithBumper(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black, true, true);
			locomotive.SetPosition(rnd.Next(30, 100), rnd.Next(300, 400), pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
			Draw();
		}
	}
}
