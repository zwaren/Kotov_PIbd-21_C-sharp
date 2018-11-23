﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	public class SteamLocomotiveWithBumper : Locomotive
	{
		private bool haveBumper;
		private bool haveSteamEngine;
		private Color extraColor;

		public SteamLocomotiveWithBumper(
			int maxSpeed,
			float weight,
			Color mainColor,
			Color extraColor,
			bool haveBumper,
			bool haveSteamEngine
			) : base(maxSpeed, weight, mainColor)
		{
			this.extraColor = extraColor;
			this.haveBumper = haveBumper;
			this.haveSteamEngine = haveSteamEngine;
		}

		public SteamLocomotiveWithBumper(string info) : base(info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 6)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				extraColor = Color.FromName(strs[3]);
				haveBumper = Convert.ToBoolean(strs[4]);
				haveSteamEngine = Convert.ToBoolean(strs[5]);
			}
		}

		public override void DrawTransport(Graphics g)
		{
			base.DrawTransport(g);
			Brush bl = new SolidBrush(extraColor);
			if (haveBumper)
			{
				g.FillRectangle(bl, _startPosX + 100, _startPosY + 30, 7, 17);
			}
			if (haveSteamEngine)
			{
				g.FillRectangle(bl, _startPosX + 70, _startPosY - 10, 7, 17);
			}
		}

		public void SetDopColor(Color color)
		{
			extraColor = color;
		}

		public override string ToString()
		{
			return base.ToString() + ";" + extraColor.Name + ";" + haveBumper + ";" + haveSteamEngine;
		}
	}
}
