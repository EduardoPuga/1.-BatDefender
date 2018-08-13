using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {

	public GameObject isla_1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetMouseButton (0)) {
			Nivel_1 ();
		}

	}
	
	public void Nivel_1(){
		Application.LoadLevel ("Level_1");
	}

	void OnColliderEnter2D (Collider2D isla_1){
		Destroy (isla_1.gameObject);
	}
}