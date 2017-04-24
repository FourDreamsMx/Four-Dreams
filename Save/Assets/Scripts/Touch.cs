using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
	private Vector3 PuntoPantalla; 
	private Vector3 OffSet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		OffSet = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, PuntoPantalla.z));
	}
	void OnMouseDrag(){
		Vector3 PuntoActual = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, PuntoPantalla.z);
		Vector3 Posicion = Camera.main.ScreenToWorldPoint (PuntoActual) + OffSet;
		transform.position = Posicion;
	}
}
