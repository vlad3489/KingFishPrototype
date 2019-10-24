using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KingFish.Scripts
{
	public class ObjectsDestroyer : MonoBehaviour
	{
		public LayerMask DestroyedLayerMask;

		/// <summary>
		/// Automatically executed by Unity, when another object enters a trigger collider attached to this object (2D physics only)
		/// </summary>
		/// <param name="other"></param>
		private void OnTriggerEnter2D(Collider2D other)
		{
			TryDestroyDestroyableObject (other);

			TryDestroyObjectBySpecificMask (other);
		}

		private void TryDestroyDestroyableObject (Collider2D triggeredObject)
		{
			IDestroyable objectToBeDestroyed = triggeredObject.GetComponent<IDestroyable> ();
			objectToBeDestroyed?.Destroy ();
		}

		private void TryDestroyObjectBySpecificMask (Collider2D triggeredObject)
		{
			if (DestroyedLayerMask == (DestroyedLayerMask | (1 << triggeredObject.gameObject.layer)))
			{
				Destroy (triggeredObject.gameObject);
			}
		}
	}
}