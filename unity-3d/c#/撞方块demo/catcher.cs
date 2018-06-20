using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catcher : MonoBehaviour
{

	public  GameObject _leftWall;
	public GameObject _rightWall;
	public float _catcherSpeed = 0.2f;



	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.A) && _leftWall.transform.position.x < (transform.position.x - 1.2f)) {
			transform.localPosition = new Vector3 (transform.localPosition.x - _catcherSpeed, transform.localPosition.y, transform.localPosition.z);

		} else if (Input.GetKey (KeyCode.D) && _rightWall.transform.position.x > (transform.position.x + 1.2f)) {
			transform.localPosition = new Vector3 (transform.localPosition.x + _catcherSpeed, transform.localPosition.y, transform.localPosition.z);
		}

	}

}