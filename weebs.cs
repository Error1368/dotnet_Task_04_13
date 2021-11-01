using System;

namespace computers
{
	public class ComputerWebFirstLevel
	{
		protected string name
		{
			get;
		}
		protected int stantions_count
		{
			get;
			set;
		}
		protected int average_distance
		{
			//average_c#_getters/setters_enjoyer
			get;
			set;
		}

		virtual public int calculate_quality()
		{
			return average_distance * stantions_count;
		}

		public string getParams()
		{
			return String.Format("Name:\t{0}\nStantions count:\t{1}\nAverage distance:\t{2}\nQuality:\t{3}",
								 name, stantions_count, average_distance, calculate_quality());
		}

		public ComputerWebFirstLevel(string name, int stantions_count, int average_distance)
		{
			this.name = name;
			this.stantions_count = stantions_count;
			this.average_distance = average_distance;
		}
	}

	public class ComputerWebSecondLevel : ComputerWebFirstLevel
	{
		protected int average_data_moving_speed
		{
			get;
			set;
		}
		override
		public int calculate_quality()
		{
			return base.calculate_quality() * average_data_moving_speed;
		}

		new public string getParams()
		{
			return String.Format("Name:\t{0}\nStantions count:\t{1}\nAverage distance:\t{2} m\nAverage speed:\t{3} Mb/s\nQuality:\t{4}",
								 name, stantions_count, average_distance, average_data_moving_speed, calculate_quality());
		}

		public ComputerWebSecondLevel(string name, int stantions_count, int average_distance, int average_data_moving_speed) : base(name, stantions_count, average_distance)
		{
			this.average_data_moving_speed = average_data_moving_speed;
		}
	}

}
