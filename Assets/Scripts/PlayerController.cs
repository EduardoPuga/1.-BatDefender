using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private float verticalSpeed = 0.3f;
	private float horizontalSpeed = 0.3f;
	private int estado;//0 reposo; 1 corriendo_derecha ; 2 corriendo_izquierda; 3 saltando; 4 agachado; 5 cayendo;
	public Sprite reposo;
	public Sprite [] corriendo_derecha;
	public Sprite [] corriendo_izquierda;
	public Sprite [] saltando;
	//public Sprite [] cayendo;
	public Sprite agachado;
	public Sprite cayendo;
	
	private int runIndex;
	private int tick;
	private int skipRun = 8;
	
	private int jumpIndex;
	private int skipJump = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tick++;
		
		if (tick > 2000) {
			tick = 0;
		}
		
		if (Input.GetKeyUp (KeyCode.UpArrow)) {

			gameObject.GetComponent<Rigidbody2D>().velocity -= new Vector2 (0, verticalSpeed);
			estado = 3;
			print ("Estado " + estado);
			estado = 5;

		}else if (Input.GetKey (KeyCode.RightArrow)) {
			
			gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2 (horizontalSpeed, 0);
			estado = 1;
			print ("Estado " + estado);
			
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			
			gameObject.GetComponent<Rigidbody2D>().velocity -= new Vector2 (horizontalSpeed, 0);
			estado = 2;
			print ("Estado " + estado);
			
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			
			gameObject.GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, verticalSpeed);
			//gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2 (0, verticalSpeed);
			estado = 3;
			print ("Estado " + estado);
			
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			
			estado = 4;
			print ("Estado " + estado);
			
		}	else if (estado != 5){

			estado = 0;
			print ("Estado " + estado);
			
		}

				
		if (estado == 0) {
			
			gameObject.GetComponent<SpriteRenderer> ().sprite = reposo;
			
		}
		
		if (estado == 1 && (tick % skipRun==0)) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = corriendo_derecha [runIndex];
			runIndex++;
			if (runIndex > 7 || estado != 1) {
				runIndex = 1;
			}
		}

		if (estado == 2 && (tick % skipRun==0)) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = corriendo_izquierda [runIndex];
			runIndex++;
			if (runIndex > 7 || estado != 2) {
				runIndex = 1;
			}
		}
		
		if (estado == 3 && (tick % skipJump==0)) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = saltando [jumpIndex];
			jumpIndex++;
			if (jumpIndex > 6) {
				jumpIndex = 1;
			}
		}
		
		if (estado == 4) {
			
			gameObject.GetComponent<SpriteRenderer> ().sprite = agachado;
			
		}

		if (estado == 5) {
			
			gameObject.GetComponent<SpriteRenderer> ().sprite = cayendo;
			
		}
		
		/*if (Input.GetKey(KeyCode.Space)) {
			
			GameObject playerController = Instantiate (laserController,
			                                           new Vector3(transform.position.x+2,
			            transform.position.y,
			            transform.position.z
			            ),
			                                           Quaternion.identity
			                                           ) as GameObject;
			
		}*/
	}
}