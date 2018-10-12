﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	interface ITransport
	{
		void SetPosition(int x, int y, int width, int height);
		void MoveTransport(Direction direction);
		void DrawTransport(Graphics g);
	}
}
