using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class BasePlayerController : MonoBehaviour
	{
		[SerializeField] protected AppSettingScriptable GlobalConfig;

		protected Rigidbody2D Rigidbody2D;

		/// <summary>
		/// Automatically executed by Unity, when the script instance is being loaded.
		/// </summary>
		private void Awake()
		{
			Rigidbody2D = GetComponent<Rigidbody2D>();
		}

		/// <summary>
		/// Automatically executed by Unity, when another object enters a trigger collider attached to this object (2D physics only)
		/// </summary>
		/// <param name="other"></param>
		private void OnTriggerEnter2D(Collider2D other)
		{
			IHitable triggeredObject = other.gameObject.GetComponent<IHitable>();
			triggeredObject?.InteractWith(this.gameObject);
		}
	}
}