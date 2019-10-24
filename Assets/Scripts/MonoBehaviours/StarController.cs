using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class StarController : MonoBehaviour, IHitable, IDestroyable
	{
		/// <summary>
		/// Realisation of IHitable interface
		/// </summary>
		/// <param name="initiator"></param>
		public void InteractWith(GameObject initiator)
		{
			// TODO PickUp logic for now it's just destroy the star 
			Destroy();
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