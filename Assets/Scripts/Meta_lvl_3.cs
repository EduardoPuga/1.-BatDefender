using UnityEngine;
using System.Collections;

public class Meta_lvl_3 : MonoBehaviour {
	
	public void OnTriggerEnter2D(Collider2D other){
		/*print ("Trigger");
		print (other);*/
		
		Destroy (other.gameObject);
		Final ();
		
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}

	public void Final(){
		Application.LoadLevel ("Final");
	}
}
