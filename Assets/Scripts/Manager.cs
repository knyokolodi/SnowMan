using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	// Use this for initialization
	public GameObject DropOne;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DropSomething(){
		DropOne.SetActive (true);
	}
}
