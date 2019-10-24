using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class BorderLimiterController : MonoBehaviour
	{
		public Transform TopBorderLimiter;
		public Transform BottomBorderLimiter;

		/// <summary>
		/// Automatically executed by Unity, on the frame when the script is enabled just before any of the Update methods is called the first time.
		/// </summary>
		private void Start()
		{
			SetBorderLimiters();
		}

		/// <summary>
		/// Sets the top and pottom limmits based on screen size
		/// </summary>
		private void SetBorderLimiters()
		{
			Vector2 topLimiterPos = Helper.TopCamBoundaryPos(Camera.main);
			Vector2 bottomLimiterPos = Helper.BottomCamBoundaryPos(Camera.main);

			TopBorderLimiter.position = new Vector3(0, topLimiterPos.y, 0f);
			BottomBorderLimiter.position = new Vector3(0, bottomLimiterPos.y, 0f);
		}
	}
}