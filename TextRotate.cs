using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRotate : MonoBehaviour {

	private RectTransform rectComponent;

	private float rotSpeed = 200f;

	private void Start(){
	
		rectComponent = GetComponent<RectTransform> ();
	
	}

	private void Update(){

		rectComponent.Rotate (0f, 0f, rotSpeed * Time.deltaTime);

	}


}
