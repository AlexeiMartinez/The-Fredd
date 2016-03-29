using UnityEngine;
using System.Collections;

public class ScrollParalax : MonoBehaviour {
	public Transform Fredd_0;
	public float sub = 100f;
	public float bajada = 0.5f;
	private bool up = false;
	public float tiemporeal = 0f;
	public Animator animator;
	private float inicio = 0f;
	public MeshRenderer CuboFondo ; /*Cubo / Fondo*/
	// Use this for initialization
	void Start () {
		
	}
	void Awake() {

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			up = false;
			do {
				inicio = Time.time;
				animator.SetBool ("ini", true);
			} while (false);
		} else {
			up = true;
		}
		if (!animator.GetBool ("ini")) {
			tiemporeal = Time.time - inicio;
		} else {
			tiemporeal = Time.time;
		}
		if (up && animator.GetBool ("ini")) {
			CuboFondo.material.mainTextureOffset = new Vector2 (0, (tiemporeal * sub)%1);
		}
		else if(animator.GetBool ("ini") && !up)
		{
			CuboFondo.material.mainTextureOffset = new Vector2 (0, (tiemporeal * bajada)%1);	
		}

	}
}
