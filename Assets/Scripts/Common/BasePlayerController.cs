using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class BasePlayerController : MonoBehaviour
	{
		[SerializeField] protected AppSettingScriptable GlobalConfig;

		protected Rigidbody2D Rigidbody2D;

		private AppManager _appManager;

		/// <summary>
		/// Automatically executed by Unity, when the script instance is being loaded.
		/// </summary>
		private void Awake()
		{
			Rigidbody2D = GetComponent<Rigidbody2D>();
			_appManager = AppManager.Instance;
		}

		/// <summary>
		/// Automatically executed by Unity, when the script becomes enabled and active.
		/// </summary>
		private void OnEnable()
		{
			_appManager.InputProvider.UserClicks += OnUserClicks;
		}

		/// <summary>
		/// Automatically executed by Unity, when the script becomes disabled or inactive.
		/// </summary>
		private void OnDisable()
		{
			_appManager.InputProvider.UserClicks -= OnUserClicks;
		}

		/// <summary>
		/// Automatically executed by Unity, when another object enters a trigger collider attached to this object (2D physics only)
		/// </summary>
		/// <param name="other"></param>
		private void OnTriggerEnter2D(Collider2D other)
		{
			TryToInteractWithTriggeredObject(other);
		}

		/// <summary>
		/// Handle actions after user click detect 
		/// </summary>
		protected virtual void OnUserClicks()
		{
			
		}

		private void TryToInteractWithTriggeredObject(Collider2D other)
		{
			IHitable triggeredObject = other.gameObject.GetComponent<IHitable>();
			triggeredObject?.InteractWith(this.gameObject);
		}
	}
}