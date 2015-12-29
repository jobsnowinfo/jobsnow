using System;

namespace JobsNow.Core.Model
{
	public class Feedback
	{
		#region Private Members
		private int id = -1;
		private int score = 0;
		private string rating = "";
		#endregion

		#region Public Properties
		public int Id {	get { return id; } set { id = value; } }
		public int Score { get { return score; } set { score = value; } }
		public string Rating { get { return rating; } set { rating = value; } }
		#endregion

		public Feedback ()
		{
		}
	}
}

