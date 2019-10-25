using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	public class OneFingerInput : BaseInputManager, IUserInputProvider
	{
		protected override void TryHandleStandaloneInput()
		{
			// Detect mouse right click or space button
			if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space))
			{
				RaiseUserClick();
			}
		}

		protected override void TryHandleMobileTouchInput()
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);

				if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary)
				{
					RaiseUserClick();
				}
			}
		}
	}
}