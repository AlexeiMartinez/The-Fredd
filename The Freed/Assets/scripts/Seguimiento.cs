using UnityEngine;
using System.Collections;


public class Seguimiento : MonoBehaviour {
	public Transform Freed;
	public Transform Objeto;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		Objeto.position = new Vector3 (Objeto.position.x, Freed.position.y, Objeto.position.z);
	}
}
