using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	class MultiLevelDepo
	{
		List<Depo<ITransport>> depoStages;
		private const int countPlaces = 15;
		private int pictureWidth;
		private int pictureHeight;

		public MultiLevelDepo(int countStages, int pictureWidth, int pictureHeight)
		{
			depoStages = new List<Depo<ITransport>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
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

		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (FileStream fs = new FileStream(filename, FileMode.Create))
			{
				using (BufferedStream bs = new BufferedStream(fs))
				{
					WriteToFile("CountLevels:" + depoStages.Count +
					Environment.NewLine, fs);
					foreach (var level in depoStages)
					{
						WriteToFile("Level" + Environment.NewLine, fs);
						for (int i = 0; i < countPlaces; i++)
						{
							var loco = level[i];
							if (loco != null)
							{
								if (loco.GetType().Name == "Locomotive")
								{
									WriteToFile(i + ":Locomotive:", fs);
								}
								if (loco.GetType().Name == "SteamLocomotiveWithBumper")
								{
									WriteToFile(i + ":SteamLocomotiveWithBumper:", fs);
								}
								WriteToFile(loco + Environment.NewLine, fs);
							}
						}
					}
				}
			}
			return true;
		}

		private void WriteToFile(string text, FileStream stream)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(text);
			stream.Write(info, 0, info.Length);
		}


		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			string bufferTextFromFile = "";
			using (FileStream fs = new FileStream(filename, FileMode.Open))
			{
				using (BufferedStream bs = new BufferedStream(fs))
				{
					byte[] b = new byte[fs.Length];
					UTF8Encoding temp = new UTF8Encoding(true);
					while (bs.Read(b, 0, b.Length) > 0)
					{
						bufferTextFromFile += temp.GetString(b);
					}
				}
			}
			bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
			var strs = bufferTextFromFile.Split('\n');
			if (strs[0].Contains("CountLevels"))
			{
				int count = Convert.ToInt32(strs[0].Split(':')[1]);
				if (depoStages != null)
				{
					depoStages.Clear();
				}
				depoStages = new List<Depo<ITransport>>(count);
			}
			else
			{
				return false;
			}
			int counter = -1;
			ITransport loco = null;
			for (int i = 1; i < strs.Length; ++i)
			{
				if (strs[i] == "Level")
				{
					counter++;
					depoStages.Add(new Depo<ITransport>(countPlaces, pictureWidth,
					pictureHeight));
					continue;
				}
				if (string.IsNullOrEmpty(strs[i]))
				{
					continue;
				}
				if (strs[i].Split(':')[1] == "Locomotive")
				{
					loco = new Locomotive(strs[i].Split(':')[2]);
				}
				else if (strs[i].Split(':')[1] == "SteamLocomotiveWithBumper")
				{
					loco = new SteamLocomotiveWithBumper(strs[i].Split(':')[2]);
				}
				depoStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = loco;
			}
			return true;
		}
	}
}
