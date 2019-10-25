using System;

namespace KingFish.Scripts
{
	/// <summary>
	/// Interface that defines minimal information about the user input
	/// </summary>
	public interface IUserInputProvider
	{
		event Action UserClicks;
	}
}