using UnityEngine;
using System.Collections;

public class DropHead : MonoBehaviour {

	public Rigidbody SnowManHeadAG;
	public Transform DropManHead;
	public GameObject PedastoleHead;
	public bool rotateOn = false;

	// Use this for initialization
	void Start () {
		SnowManHeadAG.transform.parent = null;
		SnowManHeadAG.transform.localPosition = DropManHead.transform.localPosition;
		SnowManHeadAG.GetComponent<Collider> ().enabled = false;
		PedastoleHead.GetComponent<Collider> ().enabled = false;
		rotateOn = true;
	}

}
