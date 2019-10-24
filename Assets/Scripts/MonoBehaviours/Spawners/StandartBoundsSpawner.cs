using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class StandartBoundsSpawner : BaseSpawner
	{
		[SerializeField] private BoxCollider2D _spawnedArea;

		/// <summary>
		/// Gets spawned position based on collider area
		/// </summary>
		/// <returns></returns>
		protected override Vector3? GetSpawnPos()
		{
			return Helper.RandomPointInBoundsRange(_spawnedArea.bounds);
		}
	}
}