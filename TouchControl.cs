using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class TouchControl : MonoBehaviour {
	public float minSwipeDist, maxSwipeTime; bool couldBeSwipe;

	float swipeStartTime;
	Vector2 startPos;

	CalendarScript controller;



	IEnumerator checkHorizontalSwipes () //Coroutine, wich gets Started in "Start()" and runs over the whole game to check for swipes
	{
		while (true) { //Loop. Otherwise we wouldnt check continoulsy ;-)
			foreach (Touch touch in Input.touches) { //For every touch in the Input.touches - array...

				switch (touch.phase) {
				case TouchPhase.Began: //The finger first touched the screen --> It could be(come) a swipe
					couldBeSwipe = true;

					startPos = touch.position;  //Position where the touch started
					swipeStartTime = Time.time; //The time it started
					break;

				case TouchPhase.Stationary: //Is the touch stationary? --> No swipe then!
					couldBeSwipe = false;
					break;
				}
				float swipeTime = Time.time - swipeStartTime; //Time the touch stayed at the screen till now.
				float swipeDist = Mathf.Abs (touch.position.y - startPos.y); //Swipedistance


				if (couldBeSwipe && swipeTime < maxSwipeTime && swipeDist > minSwipeDist) {
					// It's a swiiiiiiiiiiiipe!
					couldBeSwipe = false; //<-- Otherwise this part would be called over and over again.

					if (Mathf.Sign (touch.position.y - startPos.y) == 1f) { //Swipe-direction, either 1 or -1.

						controller.NextMonth ();

					} else {

						controller.PreviousMonth ();
						Debug.Log ("Swiped left");
					}
				} 
			}
			yield return null;
		}
}

	void Start(){

		controller = FindObjectOfType<CalendarScript> ();
	
		StartCoroutine (checkHorizontalSwipes ());
			
	
	}
}
