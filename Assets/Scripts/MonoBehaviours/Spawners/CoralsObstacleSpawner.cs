using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace KingFish.Scripts
{
	public class CoralsObstacleSpawner : BaseSpawner
	{
		[SerializeField] private Transform _spawnPoint;

		/// <summary>
		/// Spawn coral obstacle with random chanse
		/// </summary>
		protected override void Spawn()
		{
			bool isSpawnChanceSuccessful = Random.Range(1, 100) % 2 == 0;
			if (isSpawnChanceSuccessful)
			{
				InstantiateWithName();
			}
		}

		/// <summary>
		/// Coral Spawn point
		/// </summary>
		/// <returns></returns>
		protected override Vector3? GetSpawnPos()
		{
			return _spawnPoint.position;
		}
	}
}