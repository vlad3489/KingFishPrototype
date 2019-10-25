using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class AppManager : Singleton<AppManager>
	{
		[Header("External references:")]
		[SerializeField] private BaseSpawner[] _spawners;
		[SerializeField] private BaseInputManager _inputManager;

		public event Action GameOver;

		#region Properties

		/// <summary>
		/// Gets the currently Input provider.
		/// </summary>
		public IUserInputProvider InputProvider => _inputManager;

		#endregion


		/// <summary>
		/// Automatically executed by Unity, on the frame when the script is enabled just before any of the Update methods is called the first time.
		/// </summary>
		private void Start()
		{
			Init();
		}

		/// <summary>
		/// Main App entrypoint
		/// </summary>
		private void Init()
		{
			ActivateSpawners();
		}

		/// <summary>
		/// Spawners activator
		/// </summary>
		private void ActivateSpawners()
		{
			foreach (var spawner in _spawners)
			{
				if (!spawner.gameObject.activeInHierarchy)
				{
					spawner.gameObject.SetActive(true);
				}
			}
		}

		/// <summary>
		/// Raises main Game over event.
		/// </summary>
		public void RaiseGameOverEvent()
		{
			GameOver?.Invoke();
		}
	}
}