using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {
	public int _speed =500;
	public Text _text;
	public GameObject _bricksParent;
	public GameObject img;
	private int _brickCount;
	// Use this for initialization
	void Start () {
		
		float x = Random.Range (-100, 100) / 100f;
		float y = Random.Range (-100, 100) / 100f;
		var rigidbody = GetComponent<Rigidbody> ();
		rigidbody.AddForce (new Vector3 (x, y, 0) * _speed);
		_brickCount = _bricksParent.transform.childCount;
		_text.text = "剩余：" + _brickCount;
	}

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "brick") {
			GameObject.Destroy (collision.gameObject);
			_brickCount -= 1;
			if (_brickCount == 0) {
				img.SetActive (true);
			}
			_text.text = "剩余：" + _brickCount;
		}
	}
}
