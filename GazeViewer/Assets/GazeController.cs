using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeController : MonoBehaviour {

	public Camera playerCamera;
	private LineRenderer gazeLine;
	private float worldRadius = 4f;
	public GameObject endPoint;
	public GameObject face;

	// Use this for initialization
	void Start () {
		this.gazeLine = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//sets endpoints of GazeObject and CameraView
		transform.position = playerCamera.ViewportToWorldPoint (new Vector3 (0.2f, 0.7f, worldRadius));

		Vector3 gazeOrigin = transform.position;
//		Vector3 gazeDestination = playerCamera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, worldRadius));
		Vector3 gazeDestination = new Vector3(0f, 5f, -10f);
		transform.LookAt (gazeDestination);
		transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
//		transform.upl = 1;
		face.transform.LookAt (gazeDestination);
		gazeLine.SetPosition (0, gazeOrigin);
		gazeLine.SetPosition (1, gazeDestination);

		endPoint.transform.position = gazeDestination;
	}
}
