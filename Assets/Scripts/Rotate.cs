using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public GameObject rotate;
	public float rotateSpeed = 2f;
	public GameObject pedastole;
	public bool enableRotation = false;
	public GameObject snowManBottomBody;
	public GameObject dropScriptHolder;
	public GameObject snowManMiddleBody;
	public GameObject dropMiddleScriptHolder;
	public GameObject snowManHead;
	public GameObject dropHeadScriptHolder;
	// Use this for initialization
	void Start () {
		
	}
	public void RotateObjects(){
		enableRotation = true;
		pedastole.transform.Rotate (0, rotateSpeed, 0);
		Drop dropScript = dropScriptHolder.GetComponent<Drop> ();
		DropUpper dropMiddleScript = dropMiddleScriptHolder.GetComponent<DropUpper> ();
		DropHead dropHeadScript = dropHeadScriptHolder.GetComponent<DropHead> ();

		if (dropScript.rotateOn == true) {
			snowManBottomBody.transform.Rotate (0, rotateSpeed, 0);
		}

		if (dropMiddleScript.rotateOn == true) {
			snowManMiddleBody.transform.Rotate (0, rotateSpeed, 0);
		}

		if (dropHeadScript.rotateOn == true) {
			snowManHead.transform.Rotate (0, rotateSpeed, 0);
		}
	
	}

	
	// Update is called once per frame
	void Update () {
		if (enableRotation == true) {
			RotateObjects ();
		}
	}

	public void StopRotation(){
		enableRotation = false;
	}
}
