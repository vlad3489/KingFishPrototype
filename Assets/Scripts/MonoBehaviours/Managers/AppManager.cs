using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class AppManager : Singleton<AppManager>
	{
		[Header("Objects references:")]
		[SerializeField] private GameObject[] _environmentObjects;
		
		public event Action GameOver;

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
			ActivateObjects(_environmentObjects);
		}

		/// <summary>
		/// Spawners activator
		/// </summary>
		/// <param name="environmentObjects"></param>
		private void ActivateObjects(GameObject[] environmentObjects)
		{
			foreach (var obj in _environmentObjects)
			{
				if (!obj.activeInHierarchy)
				{
					obj.SetActive(true);
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