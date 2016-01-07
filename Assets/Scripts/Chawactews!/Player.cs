using UnityEngine;
using System.Collections;

public class Player : Character
{
	public int skill { get; private set; }
	public int health { get; private set; }
	public int rep { get; private set; }
	public int money { get; private set; }

	public Player(int skill, int health, int rep, int money, string name) : base(name)
	{
		this.skill = skill;
		this.health = health;
		this.rep = rep;
		this.money = money;
	}

	public Player(string name) : base(name)
	{
		this.health = (int) Constants.health.MAX_HEALTH;
		this.rep = (int)Constants.skillDefaults.REP;
		this.money = (int)Constants.skillDefaults.MONEY;
	}

	/// <summary>
	/// Increments the skill by the passed int.
	/// </summary>
	/// <param name="n">Amount to increment. Cannot be negative.</param>
	public void incrementSkill(int n)
	{
		if (n < 0)
			return;

		skill += n;
		return;
	}

	/// <summary>
	/// Decrements the skill by the passed int.
	/// </summary>
	/// <param name="n">Amount to decrement. Cannot be negative.</param>
	public void decrementSkill(int n)
	{
		if (n < 0)
			return;

		skill -= n;
		return;
	}
	
	/// <summary>
	/// Increments the health.
	/// </summary>
	/// <param name="n">Amount to increment. Cannot be negative.</param>
	public void incrementHealth(int n)
	{
		if (n < 0)
			return;
		
		health += n;
		return;
	}

	/// <summary>
	/// Decrements the health.
	/// </summary>
	/// <param name="n">Amount to decrement. Cannot be negative</param>
	public void decrementHealth(int n)
	{
		if (n < 0)
			return;
		
		health -= n;
		return;
	}

	/// <summary>
	/// Sets the health to the maximum amount.
	/// </summary>
	public void fillHealth()
	{
		health = (int) Constants.health.MAX_HEALTH;
	}

	/// <summary>
	/// Determines if player is alive	/// </summary>
	/// <returns><c>true</c>, if player is alive, <c>false</c> otherwise.</returns>
	public bool isAlive()
	{
		if (health > 0)
			return true;
		else
			return false;		
	}

	/// <summary>
	/// Increments the money.
	/// </summary>
	/// <param name="n">Amount to increment. Cannot be negative.</param>
	void incrementMoney(int n)
	{
		if (n < 0)
			return;
		
		money += n;
		return;
	}

	/// <summary>
	/// Decrements the money.
	/// </summary>
	/// <param name="n">Amount to decrement. Cannot be negative.</param>
	public void decrementMoney(int n)
	{
		if (n < 0)
			return;
		
		money -= n;
		return;
	}

	/// <summary>
	/// Increments the rep.
	/// </summary>
	/// <param name="n">Amount to increment. Cannot be negative.</param>
	public void incrementRep(int n)
	{
		if (n < 0)
			return;
		
		rep += n;
		return;
	}

	/// <summary>
	/// Decrements the rep.
	/// </summary>
	/// <param name="n">Amount to decrement. Cannot be negative.</param>
	public void decrementRep(int n)
	{
		if (n < 0)
			return;
		
		rep -= n;
		return;
	}
}
