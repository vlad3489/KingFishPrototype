using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class PlayerFishMovementController : BasePlayerController
	{
		protected override void OnUserClicks()
		{
			// Dive down
			Rigidbody2D.velocity = Vector2.down * GlobalConfig.PlayerDiveForce;
		}
	}
}