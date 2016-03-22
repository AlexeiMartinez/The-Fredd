using UnityEngine;
using System.Collections;


public class movimentFredd : MonoBehaviour {
	public Transform Fredd_0;
	public Rigidbody2D Fredd_1;
	public float VelcUp = 100f;
	public float izq = -50f;
	public bool up = false;
	public float der = 50f;
	private Animator animator;
	void Awake()
	{
		animator = GetComponent<Animator> ();
	}
	void FixedUpdate() {
		if (animator.GetBool("izq")== true){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (izq,GetComponent<Rigidbody2D>().velocity.y);
	}
		if (animator.GetBool("der")== true){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (der,GetComponent<Rigidbody2D>().velocity.y);
		}
		if (up && animator.GetBool("ini")){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x,VelcUp);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			animator.SetBool("izq",true);
		}
		else {
			animator.SetBool("izq",false);
		}

		if (Input.GetKey (KeyCode.D)) {
			animator.SetBool("der",true);	
		}
		else {
			animator.SetBool("der",false);
		}
		if (Input.GetKey (KeyCode.Space)) {
			up = false;
			animator.SetBool ("ini",true);
		} else {
			up = true;
		}
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,GetComponent<Rigidbody2D>().velocity.y);

	}
}
