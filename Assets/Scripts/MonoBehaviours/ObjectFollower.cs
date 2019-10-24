using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace KingFish.Scripts
{
	public class ObjectFollower : MonoBehaviour
	{
		[SerializeField] private float _minXOffsetRangeLimit = -6f;
		[SerializeField] private float _maxXOffsetRangeLimit = -0.5f;
		[SerializeField] private float _yOffsetRangeLimit = 0.5f;

		private float _lerpSpeed;
		private Vector2 _playerFollowPointOffset;
		private GameObject _playerGo;

		/// <summary>
		/// Automatically executed by Unity, every frame if the script is enabled.
		/// </summary>
		private void Update()
		{
			FollowByPlayer();
		}

		/// <summary>
		/// Set the player for future follow
		/// </summary>
		/// <param name="player"></param>
		public void SetPlayer(GameObject player)
		{
			_playerGo = player;
		}

		/// <summary>
		/// Before follow actions
		/// </summary>
		public void PrepareForFollowing()
		{
			// Generate random offset
			_playerFollowPointOffset = new Vector2(Random.Range(_minXOffsetRangeLimit, _maxXOffsetRangeLimit), Random.Range(-_yOffsetRangeLimit, _yOffsetRangeLimit));
			// Generate random follow speed
			_lerpSpeed = Random.Range(0.1f, 4f);
		}

		/// <summary>
		/// Follow based on player pos + random offset
		/// </summary>
		private void FollowByPlayer()
		{
			if (!_playerGo)
			{
				return;
			}

			transform.position = Vector2.Lerp(transform.position, (Vector2) _playerGo.transform.position + _playerFollowPointOffset, Time.deltaTime * _lerpSpeed);
		}
	}
}