using UnityEngine;
using System.Collections;

public class CircularMovement : MonoBehaviour  {
	
	private Vector3 center = new Vector3(0,0,0);
	public float degreesPerSecond = -65.0f;
	
	private Vector3 v;
	
	void Start() {
		v = transform.position - center;
	}
	
	//values for internal use
	private Quaternion _lookRotation;
	private Vector3 _direction;
	
	void Update () {
		v = Quaternion.AngleAxis (degreesPerSecond * Time.deltaTime, Vector3.forward) * v;
		transform.position = center + v;

		transform.RotateAround(center, Vector3.forward, degreesPerSecond * Time.deltaTime);

	}
}
