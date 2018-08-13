using UnityEngine;
using System.Collections;

public class Fruta : MonoBehaviour {
	
	public void OnTriggerEnter2D(Collider2D other){
		/*print ("Trigger");
		print (other);*/
		
		Destroy (gameObject);
		
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}
}
