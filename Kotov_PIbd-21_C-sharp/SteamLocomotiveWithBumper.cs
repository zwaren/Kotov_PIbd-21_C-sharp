using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	public class SteamLocomotiveWithBumper : Locomotive, IComparable<SteamLocomotiveWithBumper>, IEquatable<SteamLocomotiveWithBumper>
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

		public int CompareTo(SteamLocomotiveWithBumper other)
		{
			var res = (this as Locomotive).CompareTo(other as Locomotive);
			if (res != 0)
			{
				return res;
			}
			if (extraColor != other.extraColor)
			{
				extraColor.Name.CompareTo(other.extraColor.Name);
			}
			if (haveBumper != other.haveBumper)
			{
				return haveBumper.CompareTo(other.haveBumper);
			}
			if (haveSteamEngine != other.haveSteamEngine)
			{
				return haveSteamEngine.CompareTo(other.haveSteamEngine);
			}
			return 0;
		}

		public bool Equals(SteamLocomotiveWithBumper other)
		{
			var res = (this as Locomotive).Equals(other as Locomotive);
			if (!res)
			{
				return res;
			}
			if (GetType().Name != other.GetType().Name)
			{
				return false;
			}
			if (extraColor != other.extraColor)
			{
				return false;
			}
			if (haveBumper != other.haveBumper)
			{
				return false;
			}
			if (haveSteamEngine != other.haveSteamEngine)
			{
				return false;
			}
			return true;
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			SteamLocomotiveWithBumper locoObj = obj as SteamLocomotiveWithBumper;
			if (locoObj == null)
			{
				return false;
			}
			else
			{
				return Equals(locoObj);
			}
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
