using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	class Locomotive
	{
		private float _startPosX;
		private float _startPosY;
		private int _pictureWidth;
		private int _pictureHeight;
		private const int locomotiveWidth = 100;
		private const int locomotiveHeight = 60;

		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public Color DopColor { private set; get; }

		public Locomotive(int maxSpeed, float weight, Color mainColor, Color dopColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}

		public void MoveTransport(Direction direction)
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
		public void DrawLocomotive(Graphics g)
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
	}
}
