using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {
	
	public int win;
	
	public bool dm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.transform.name == "Block")
		{
			dm = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
			dm = false;
	}
}
