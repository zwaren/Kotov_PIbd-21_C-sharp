using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	class Depo<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Depo<T>>
		where T : class, ITransport
	{
		private Dictionary<int, T> _places;
		private int _maxCount;
		private int PictureWidth { get; set; }
		private int PictureHeight { get; set; }
		private int _placeSizeWidth = 210;
		private int _placeSizeHeight = 80;
		private int _currentIndex;

		public Depo(int sizes, int pictureWidth, int pictureHeight)
		{
			_maxCount = sizes;
			_places = new Dictionary<int, T>();
			PictureWidth = pictureWidth;
			PictureHeight = pictureHeight;
		}

		public static int operator +(Depo<T> p, T loco)
		{
			if (p._places.Count == p._maxCount)
			{
				throw new DepoOverflowException();
			}
			if (p._places.ContainsValue(loco))
			{
				throw new DepoAlreadyHaveException();
			}
			for (int i = 0; i < p._maxCount; i++)
			{
				if (p.CheckFreePlace(i))
				{
					p._places.Add(i, loco);
					p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
					i % 5 * p._placeSizeHeight + 15, p.PictureWidth, p.PictureHeight);
					return i;
				}
			}
			return -1;
		}

		public static T operator -(Depo<T> p, int index)
		{
			if (!p.CheckFreePlace(index))
			{
				T loco = p._places[index];
				p._places.Remove(index);
				return loco;
			}
			throw new DepoNotFoundException(index);
		}

		private bool CheckFreePlace(int index)
		{
			return !_places.ContainsKey(index);
		}

		public void Draw(Graphics g)
		{
			DrawMarking(g);
			var keys = _places.Keys.ToList();
			for (int i = 0; i < keys.Count; i++)
			{
				_places[keys[i]].DrawTransport(g);
			}
		}

		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
			for (int i = 0; i < _maxCount / 5; i++)
			{
				for (int j = 1; j < 6; ++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
					i * _placeSizeWidth + 110, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
			}
		}

		public T this[int ind]
		{
			get
			{
				if (_places.ContainsKey(ind))
				{
					return _places[ind];
				}
				throw new DepoNotFoundException(ind);
			}
			set
			{
				if (CheckFreePlace(ind))
				{
					_places.Add(ind, value);
					_places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 *
						_placeSizeHeight + 15, PictureWidth, PictureHeight);
				}
				else
				{
					throw new DepoOccupiedPlaceException(ind);
				}
			}
		}

		public T Current => _places[GetKey];

		public int GetKey => _places.Keys.ToList()[_currentIndex];

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			_places.Clear();
		}

		public bool MoveNext()
		{
			if (_currentIndex + 1 >= _places.Count)
			{
				Reset();
				return false;
			}
			_currentIndex++;
			return true;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public int CompareTo(Depo<T> other)
		{
			if (_places.Count > other._places.Count)
			{
				return -1;
			}
			else if (_places.Count < other._places.Count)
			{
				return 1;
			}
			else if (_places.Count > 0)
			{
				var thisKeys = _places.Keys.ToList();
				var otherKeys = other._places.Keys.ToList();
				for (int i = 0; i < _places.Count; ++i)
				{
					if (_places[thisKeys[i]] is SteamLocomotiveWithBumper && other._places[otherKeys[i]] is Locomotive)
					{
						return 1;
					}
					if (_places[thisKeys[i]] is Locomotive && other._places[otherKeys[i]] is SteamLocomotiveWithBumper)
					{
						return -1;
					}
					if (_places[thisKeys[i]] is SteamLocomotiveWithBumper && other._places[otherKeys[i]] is SteamLocomotiveWithBumper)
					{
						return (_places[thisKeys[i]] as SteamLocomotiveWithBumper).CompareTo(other._places[otherKeys[i]] as SteamLocomotiveWithBumper);
					}
					if (_places[thisKeys[i]] is Locomotive && other._places[otherKeys[i]] is Locomotive)
					{
						return (_places[thisKeys[i]] as Locomotive).CompareTo(other._places[otherKeys[i]] as Locomotive);
					}
				}
			}
			return 0;
		}

	}
}
