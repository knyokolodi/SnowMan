using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject SnowManHead;
	public Rigidbody SnowManHeadR;
	public GameObject PedastoleHead;
	public GameObject SnowManUpperBody;
	public Rigidbody SnowManUpperBodyR;
	public GameObject PedastoleUpper;
	public GameObject SnowManBottomBody;
	public Rigidbody SnowManBottomBodyR;
	public GameObject PedastoleBottom;
	public GameObject isDrop;
	public GameObject isDropSnowManUpperBody;
	public GameObject isDropSnowManHead;
	public Transform VRHand;

	// Use this for initialization
	void Start () {
		//SnowManBottomBody.GetComponent<Rigidbody>().useGravity = true;
		SnowManUpperBody.GetComponent<Collider> ().enabled = false;
		SnowManHead.GetComponent<Collider> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoveObjectBBody(){
		PedastoleBottom.GetComponent<Collider> ().enabled = true;
		SnowManBottomBodyR.transform.parent = VRHand.transform;
	}

	public void MoveUpBody(){
		PedastoleUpper.GetComponent<Collider> ().enabled = true;
		SnowManUpperBodyR.transform.parent = VRHand.transform;
	}

	public void MoveHead(){
		PedastoleHead.GetComponent<Collider> ().enabled = true;
		SnowManHeadR.transform.parent = VRHand.transform;
	}
}
