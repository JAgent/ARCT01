using UnityEngine;
using GoogleARCore;

public class PosiTra : MonoBehaviour {

	private Vector3 origPos;

	void Start () {
		origPos = gameObject.transform.position;
	}

	void Update () {

		if (Session.Status == SessionStatus.Tracking)
		{
			var pose = Frame.Pose;
			gameObject.transform.position = pose.position + origPos;
		}
	}
}