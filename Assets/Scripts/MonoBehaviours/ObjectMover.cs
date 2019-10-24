using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class ObjectMover : MonoBehaviour
	{
		[SerializeField] private bool _canBeMoved;
		[SerializeField] private float _movementSpeed;

		/// <summary>
		/// Automatically executed by Unity, every frame if the script is enabled.
		/// </summary>
		private void Update()
		{
			if (!_canBeMoved)
			{
				return;
			}

			ApplyMovement(_movementSpeed);
		}

		/// <summary>
		/// Base movement through the screen
		/// </summary>
		/// <param name="speed"></param>
		private void ApplyMovement(float speed)
		{
			transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left * speed, Time.deltaTime * _movementSpeed);
		}
	}
}