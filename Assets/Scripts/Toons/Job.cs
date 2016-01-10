using UnityEngine;
using System.Collections;


/// <summary>
/// Job class used for in-game work-related jobs. Contains a job description, cash & reputation requirements and rewards.
/// </summary>
public class Job
{
    public string description { get; private set; }
    public int cashReward { get; private set; }
    public int repReward { get; private set; }
    public int cashRequirement { get; private set; }
    public int repRequirement { get; private set; }

    Job(string description, int cashReward, int repReward, int cashRequirement, int repRequirement)
    {
        this.description = description;
        this.cashReward = cashReward;
        this.repReward = repReward;
        this.cashRequirement = cashRequirement;
        this.repRequirement = repRequirement;
    }

    Job(string description, int cashReward, int repReward)
    {
        this.description = description;
        this.cashReward = cashReward;
        this.repReward = repReward;
        this.cashRequirement = (int) Constants.jobDefaults.cashRequirement;
        this.repRequirement = (int) Constants.jobDefaults.repRequirement;
    }

    Job(string description)
    {
        this.description = description;
        this.cashReward = (int)Constants.jobDefaults.cashReward;
        this.repReward = (int)Constants.jobDefaults.repReward;
        this.cashRequirement = (int)Constants.jobDefaults.cashRequirement;
        this.repRequirement = (int)Constants.jobDefaults.repRequirement;
    }
}
