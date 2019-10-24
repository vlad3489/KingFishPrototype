using UnityEngine;

namespace KingFish.Scripts
{
	/// <summary>
	/// Interface that defines minimal information about the object that can be hited by player
	/// </summary>
	public interface IHitable
	{
		/// <summary>
		/// Across this method player interacts with object
		/// </summary>
		/// <param name="initiator"></param>
		void InteractWith(GameObject initiator);
	}
}