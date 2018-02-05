using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Disclaimer : MonoBehaviour {

	public GameObject panel;

	void Start(){

		if (PlayerPrefs.GetInt ("DISCLAIMERDONE") == 0 || PlayerPrefs.GetInt("DISCLAIMERDONE") == null) {

			panel.SetActive (true);
		
		}

		if (PlayerPrefs.GetInt ("DISCLAIMERDONE") == 1) {
		
			panel.SetActive (false);
		
		}

	}


	public void AgreePanel(){

		panel.SetActive (false);

		PlayerPrefs.SetInt ("DISCLAIMERDONE", 1);

	}

	public void DisagreePanel(){
	
		Application.Quit ();
	
	}

}
