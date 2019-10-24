using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class SimpleKillerController : MonoBehaviour, IHitable, IDestroyable
	{
		/// <summary>
		/// Realisation of IHitable interface
		/// </summary>
		/// <param name="playerGo"></param>
		public void InteractWith(GameObject playerGo)
		{
			if (playerGo.CompareTag(TagsConstants.PLAYER_TAG))
			{
				KillPlayer(playerGo);
			}
		}

		/// <summary>
		/// Kill player and game over invocator
		/// </summary>
		/// <param name="playerGo"></param>
		protected virtual void KillPlayer(GameObject playerGo)
		{
			AppManager.Instance.RaiseGameOverEvent();
			Destroy(playerGo);
		}

		/// <summary>
		/// Realisation of IDestroyable interface
		/// </summary>
		public void Destroy()
		{
			Destroy(this.gameObject);
		}
	}
}