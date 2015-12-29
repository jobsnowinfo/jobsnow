using System;

namespace JobsNow.Core.Model
{
	public class Skill
	{
		#region Private Members
		private int id = -1;
		private string description = "";
		#endregion

		#region Public Properties
		public int Id {	get { return id; } set { id = value; } }
		public string Description { get { return description; } set { description = value; } }
		#endregion

		public Skill ()
		{
		}
	}
}

