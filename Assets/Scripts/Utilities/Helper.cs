using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper
{
	public static Vector3 RandomPointInBoundsRange(Bounds bounds)
	{
		return new Vector3(Random.Range(bounds.min.x, bounds.max.x), Random.Range(bounds.min.y, bounds.max.y), Random.Range(bounds.min.z, bounds.max.z));
	}

	public static Vector2 TopCamBoundaryPos(Camera cam)
	{
		Vector2 topPosPoint = cam.ViewportToWorldPoint(new Vector3(1f, 1f, cam.nearClipPlane));
		return topPosPoint;
	}

	public static Vector2 BottomCamBoundaryPos(Camera cam)
	{
		Vector2 bottomPosPoint = cam.ViewportToWorldPoint(new Vector3(0f, 0f, cam.nearClipPlane));
		return bottomPosPoint;
	}
}