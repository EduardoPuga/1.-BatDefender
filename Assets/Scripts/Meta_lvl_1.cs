using UnityEngine;
using System.Collections;

public class Meta_lvl_1 : MonoBehaviour {
	
	public void OnTriggerEnter2D(Collider2D other){
		/*print ("Trigger");
		print (other);*/
		
		Destroy (other.gameObject);
		Nivel_2 ();
		
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}

	public void Nivel_2(){
		Application.LoadLevel ("Level_2");
	}
}
