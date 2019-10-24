using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	/// <summary>
	/// Interface that defines minimal information about the Destroy object
	/// </summary>
	public interface IDestroyable
	{
		/// <summary>
		/// Destroy object method
		/// </summary>
		void Destroy ();
	}
}