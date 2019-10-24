using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class UIManager : MonoBehaviour
	{
		[Header("References:")]
		[SerializeField] private Canvas _mainUiCanvas;

		private AppManager _appManager;

		/// <summary>
		/// Automatically executed by Unity, when the script instance is being loaded.
		/// </summary>
		private void Awake()
		{
			// Init components
			_appManager = AppManager.Instance;
		}


		private void OnEnable()
		{
			_appManager.GameOver += OnGameOver;
		}

		/// <summary>
		/// Automatically executed by Unity, when the script becomes disabled or inactive.
		/// </summary>
		private void OnDisable()
		{
			_appManager.GameOver -= OnGameOver;
		}

		private void OnGameOver()
		{
			if (!_mainUiCanvas.gameObject.activeInHierarchy)
			{
				_mainUiCanvas.gameObject.SetActive(true);
			}
		}
	}
}