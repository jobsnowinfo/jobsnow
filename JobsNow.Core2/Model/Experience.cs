using System;

namespace JobsNow.Core.Model
{
	public class Experience
	{
		#region Private Members
		private int id = -1;
		private Skill skill = null;
		private bool individualDays = false;
		private DateTime initDate = DateTime.MinValue;
		private DateTime finishDate = DateTime.MinValue;
		private Feedback feedback = null;
		#endregion

		#region Public Properties
		public int Id {	get { return id; } set { id = value; } }
		public Skill Skill { get { return skill; } set { skill = value; } } 
		public bool IndividualDays { get { return individualDays; } set { individualDays = value; } }
		public DateTime InitDate { get { return initDate; } set { initDate = value; } }
		public DateTime FinishDate { get { return finishDate; } set { finishDate = value; } }
		public Feedback Feedback { get { return feedback; } set { feedback = value; } }
		#endregion

		public Experience ()
		{
		}
	}
}

