using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	public class Locomotive : Train
	{
		private const int locomotiveWidth = 100;
		private const int locomotiveHeight = 60;

		public Locomotive(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		public Locomotive(string info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}

		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - locomotiveWidth)
					{
						_startPosX += step;
					}
					break;
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - locomotiveHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);

			Brush br = new SolidBrush(MainColor);
			g.FillRectangle(br, _startPosX, _startPosY + 10, 100, 30);

			Brush bl = new SolidBrush(Color.Black);
			Brush bg = new SolidBrush(Color.Gray);
			g.DrawRectangle(pen, _startPosX, _startPosY + 10, 15, 30);
			g.FillEllipse(bl, _startPosX + 10, _startPosY + 35, 10, 10);
			g.FillEllipse(bl, _startPosX + 20, _startPosY + 35, 10, 10);
			g.FillEllipse(bl, _startPosX + 30, _startPosY + 35, 10, 10);
			g.FillEllipse(bl, _startPosX + 60, _startPosY + 35, 10, 10);
			g.FillEllipse(bl, _startPosX + 70, _startPosY + 35, 10, 10);
			g.FillEllipse(bl, _startPosX + 80, _startPosY + 35, 10, 10);
			g.FillEllipse(bg, _startPosX, _startPosY + 5, 100, 10);
			g.FillRectangle(bl, _startPosX - 5, _startPosY + 36, 110, 5);
		}

		public override string ToString()
		{
			return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
		}
	}
}
