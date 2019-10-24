using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public abstract class BaseSpawner : MonoBehaviour
	{
		[SerializeField] private GameObject _originObject;
		[SerializeField] private int _spawnIntervalMin = 1;
		[SerializeField] private int _spawnIntervalMax = 1;

		/// <summary>
		/// Automatically executed by Unity, on the frame when the script is enabled just before any of the Update methods is called the first time.
		/// </summary>
		protected virtual void Start()
		{
			StartCoroutine(SpawnerCoroutine());
		}

		/// <summary>
		/// Infinite spawner routine
		/// </summary>
		/// <returns></returns>
		private IEnumerator SpawnerCoroutine()
		{
			// TODO revrite infinite spawner

			for (;;)
			{
				yield return new WaitForSeconds(Random.Range(_spawnIntervalMin, _spawnIntervalMax));
				Spawn();
			}
		}

		/// <summary>
		/// Spawn the object
		/// </summary>
		protected virtual void Spawn()
		{
			InstantiateWithName();
		}

		/// <summary>
		/// Instantiate object on scene
		/// </summary>
		/// <param name="objectName"></param>
		/// <returns></returns>
		protected GameObject InstantiateWithName(string objectName = null)
		{
			// TODO create pool of objects (Instantiate are not optimized solution)

			GameObject spawnedObject = Instantiate(_originObject, GetSpawnPos().GetValueOrDefault(), Quaternion.identity);
			spawnedObject.name = objectName ?? spawnedObject.name;
			return spawnedObject;
		}

		/// <summary>
		/// Get the spawned point
		/// </summary>
		/// <returns></returns>
		protected abstract Vector3? GetSpawnPos();
	}
}