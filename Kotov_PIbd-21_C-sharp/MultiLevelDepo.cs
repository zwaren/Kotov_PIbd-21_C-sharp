using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	class MultiLevelDepo
	{
		List<Depo<ITransport>> depoStages;
		private const int countPlaces = 20;

		public MultiLevelDepo(int countStages, int pictureWidth, int pictureHeight)
		{
			depoStages = new List<Depo<ITransport>>();
			for (int i = 0; i < countStages; ++i)
			{
				depoStages.Add(new Depo<ITransport>(countPlaces, pictureWidth, pictureHeight));
			}
		}

		public Depo<ITransport> this[int index]
		{
			get
			{
				if (index > -1 && index < depoStages.Count)
				{
					return depoStages[index];
				}
				return null;
			}
		}
	}
}
