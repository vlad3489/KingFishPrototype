using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingFish.Scripts
{
	[RequireComponent(typeof(ObjectMover), typeof(ObjectFollower))]
	public class BandFishController : MonoBehaviour, IHitable, IDestroyable
	{
		[SerializeField] private SpriteRenderer _fishSprite;
		[SerializeField] private Collider2D _fishCollider2D;
		private ObjectMover _mover;
		private ObjectFollower _follower;

		/// <summary>
		/// Automatically executed by Unity, when the script instance is being loaded.
		/// </summary>
		private void Awake()
		{
			_mover = GetComponent<ObjectMover>();
			_follower = GetComponent<ObjectFollower>();
			_fishCollider2D = GetComponent<Collider2D> ();
		}

		/// <summary>
		/// Realisation of IHitable interface
		/// </summary>
		/// <param name="playerGo"></param>
		public void InteractWith(GameObject playerGo)
		{
			if (playerGo.CompareTag(TagsConstants.PLAYER_TAG))
			{
				DisableMover();
				ActivateFollower(playerGo);
			}
		}

		/// <summary>
		/// Disable the movement component
		/// </summary>
		private void DisableMover()
		{
			_mover.enabled = false;
		}

		/// <summary>
		/// Activates follower component
		/// </summary>
		/// <param name="playerGo"></param>
		private void ActivateFollower(GameObject playerGo)
		{
			_fishSprite.flipX = true;
			_follower.SetPlayer(playerGo);
			_follower.PrepareForFollowing();
			
			_fishCollider2D.enabled = false;
			_follower.enabled = true;
		}

		/// <summary>
		/// Realisation of IDestroyable interface
		/// </summary>
		public void Destroy()
		{
			Destroy(this.gameObject);
		}
	}
}