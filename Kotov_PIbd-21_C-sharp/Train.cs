﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	public abstract class Train : ITransport
	{
		protected float _startPosX;
		protected float _startPosY;
		protected int _pictureWidth;
		protected int _pictureHeight;

		public int MaxSpeed { protected set; get; }
		public float Weight { protected set; get; }
		public Color MainColor { protected set; get; }

		public abstract void DrawTransport(Graphics g);

		public abstract void MoveTransport(Direction direction);

		public void SetMainColor(Color color)
		{
			MainColor = color;
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
	}
}
