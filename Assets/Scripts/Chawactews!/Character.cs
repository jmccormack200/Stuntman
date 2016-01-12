using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// </summary>
public class Character : MonoBehaviour
{
		public new string name { get; private set; }

		public Character(string name)
		{
				this.name = name;
		}
}
