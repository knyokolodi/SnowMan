using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {

	public Rigidbody SnowManBottomBodyAG;
	public Transform DropBottomBody;
	public GameObject SnowManUpperBody;
	public bool rotateOn = false;

	// Use this for initialization
	void Start () {
		SnowManBottomBodyAG.transform.parent = null;
		SnowManBottomBodyAG.transform.localPosition = DropBottomBody.transform.localPosition;
		SnowManBottomBodyAG.GetComponent<Collider> ().enabled = false;
		SnowManUpperBody.GetComponent<Collider> ().enabled = true;
		rotateOn = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
