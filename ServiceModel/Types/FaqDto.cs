using System;

namespace ServiceModel
{
	public class FaqDto
	{
		public FaqDto ()
		{

		}

		public int Id { get; set; }
		public string Question { get; set; }
		public string Answer { get; set; }
		public string Category { get; set; }

	}
}

