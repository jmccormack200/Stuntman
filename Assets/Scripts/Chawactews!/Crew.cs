using UnityEngine;
using System.Collections;

public class Crew : Character
{
	public int skill { get; private set; }

	public Crew(string name, int skill) : base(name)
	{
		this.skill = skill;
	}
}
