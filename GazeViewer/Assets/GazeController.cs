using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeController : MonoBehaviour {

	public Camera playerCamera;
	private LineRenderer gazeLine;

	// Use this for initialization
	void Start () {
		this.gazeLine = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 gazeDestination = playerCamera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 10));
		Vector3 gazeOrigin = transform.position;
//		gazeOrigin.y += 0.2f;

		transform.LookAt (gazeDestination);
		gazeLine.SetPosition (0, gazeOrigin);
		gazeLine.SetPosition (1, gazeDestination);
	}
}
