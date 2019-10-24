using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KingFish.Scripts
{
	public class ScenesManager : MonoBehaviour
	{
		[SerializeField] protected AppSettingScriptable GlobalAppSettings;

		private AppManager _appManager;

		/// <summary>
		/// Automatically executed by Unity, when the script instance is being loaded.
		/// </summary>
		private void Awake()
		{
			// Init components
			_appManager = AppManager.Instance;
		}

		/// <summary>
		/// Automatically executed by Unity, when the script becomes enabled and active.
		/// </summary>
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

		/// <summary>
		/// Stars awaiter for scene relead 
		/// </summary>
		private void OnGameOver()
		{
			StartCoroutine(ResetSceneCoroutine());
		}

		/// <summary>
		/// Scene reset logic
		/// </summary>
		private IEnumerator ResetSceneCoroutine()
		{
			yield return new WaitForSeconds(GlobalAppSettings.WaitForRestart);
			SceneManager.LoadScene(ScenesConstants.MAIN_SCENE_NAME);
		}
	}
}