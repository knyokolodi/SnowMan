using UnityEngine;
using System.Collections;

public class DropUpper : MonoBehaviour {

	public Rigidbody SnowManUpperBodyAG;
	public Transform DropUpperBody;
	public GameObject PedastoleUpper;
	public GameObject SnowManHead;
	public bool rotateOn = false;

	// Use this for initialization
	void Start () {
		SnowManUpperBodyAG.transform.parent = null;
		SnowManUpperBodyAG.transform.localPosition = DropUpperBody.transform.localPosition;
		SnowManUpperBodyAG.GetComponent<Collider> ().enabled = false;
		PedastoleUpper.GetComponent<Collider> ().enabled = false;
		SnowManHead.GetComponent<Collider> ().enabled = true;
		rotateOn = true;
	}

	// Update is called once per frame
	void Update () {

	}
}
