using System;
using System.Collections.Generic;

namespace JobsNow.Core.Model
{
	public class Candidate
	{
		#region Private members
		private int id = -1;
		private string name  = "";
		private string lastName = "";
		private int phoneNumber = -1;
		private List<Skill> skills = null;
		private List<Experience> experiences = null;
		#endregion

		#region Public properties

		public int Id {get { return id; } set { id = value; }}
		public string Name {get { return name; } set { name = value; }}
		public string LastName {get { return lastName; } set { lastName = value; }}
		public int PhoneNumber {get { return phoneNumber; } set { phoneNumber = value; }}
		public List<Skill> Skills { get { return skills; } set { skills = value; } }
		public List<Experience> Experiences { get { return experiences; } set { experiences = value; } }
		#endregion

		public Candidate ()
		{
		}
	}
}