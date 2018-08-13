using UnityEngine;
using System.Collections;

public class Meta_lvl_2 : MonoBehaviour {
	
	public void OnTriggerEnter2D(Collider2D other){
		/*print ("Trigger");
		print (other);*/
		
		Destroy (other.gameObject);
		Nivel_3 ();
		
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}

	public void Nivel_3(){
		Application.LoadLevel ("Level_3");
	}
}
