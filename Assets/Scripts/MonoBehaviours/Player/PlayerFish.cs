using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class PlayerFish : BasePlayerController
	{
		/// <summary>
		/// Automatically executed by Unity, every frame if the script is enabled.
		/// </summary>
		private void Update()
		{
			// TODO Create input manager
			
			if (Input.GetKey(KeyCode.Space))
			{
				Rigidbody2D.velocity = Vector2.down * GlobalConfig.PlayerDiveForce;
			}
		}
	}
}