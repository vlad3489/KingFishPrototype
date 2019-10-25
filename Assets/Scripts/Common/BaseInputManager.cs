using System;
using UnityEngine;

namespace KingFish.Scripts
{
	public abstract class BaseInputManager : MonoBehaviour, IUserInputProvider
	{
		public event Action UserClicks;

		private void Update()
		{
			#if UNITY_EDITOR || UNITY_STANDALONE

			TryHandleStandaloneInput();

			#elif UNITY_ANDROID || UNITY_IOS
			
			TryHandleMobileTouchInput();
			
			#endif
		}

		protected abstract void TryHandleStandaloneInput();
		protected abstract void TryHandleMobileTouchInput();

		/// <summary>
		/// Used for raising main user click event
		/// </summary>
		protected void RaiseUserClick()
		{
			UserClicks?.Invoke();
		}
	}
}