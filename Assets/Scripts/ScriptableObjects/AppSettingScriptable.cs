using UnityEngine;

namespace KingFish.Scripts
{
	[UnityEngine.CreateAssetMenu(fileName = "GlobalSettings", menuName = "Settings", order = 0)]
	public class AppSettingScriptable : UnityEngine.ScriptableObject
	{
		[Header("Player Settings:")]
		public float PlayerDiveForce;

		[Header("Scenes Settings:")]
		[Tooltip("Seconds delay for restart level")]
		public float WaitForRestart;
	}
}