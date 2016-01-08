using UnityEngine;
using System.Collections;

/// <summary>
/// A member of the crew. Child of Character class.
/// </summary>
public class Crew : Character
{
    public int skill { get; private set; }
    public Constants.crewJob job { get; private set; }

    public Crew(string name, int skill, Constants.crewJob job) : base(name)
    {
        this.skill = skill;
        this.job = job;
    }
}
