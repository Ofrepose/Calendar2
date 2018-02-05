using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
///using Vuforia;


public class CalendarScript : MonoBehaviour {

	ShiftCompiler compiler;

	public Text monthText;

	public Text[] days;

	//public Font[] fonts;

	public GameObject[] calendarBlocks;
	
	public int monthNow = 0;
	
	public int dayOfYear;
	
	public int cellToStart;

	public GameObject[] today;


	void Start () {	

		compiler = FindObjectOfType<ShiftCompiler> ();
	
		EraseAll();	
	
		Text monthText = GetComponent<Text>();	
	
		monthNow = (System.DateTime.Now.Month - 1);	
	
		UpdateScreen();	
		
	}
	
		
	public void UpdateScreen(){	

		//TodayHigh ();
	
		if (monthNow == 0){		
		
			cellToStart = 1;
			
			dayOfYear = 0;

			//monthText.font = fonts [0];
	
			monthText.text = "January";
			
			while (dayOfYear <= 30){				
			
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear += 1;
				
				cellToStart += 1;			
			}
	
		}
		
		if (monthNow == 1){

			//monthText.font = fonts [1];
			
			monthText.text = "February";
			
			cellToStart = 4;
			
			dayOfYear = 0;				
			
			while (dayOfYear <= 27){
			
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
				
				}
			
			}	
			
		}		
		
		if (monthNow == 2){			
		
			cellToStart = 4;

			//monthText.font = fonts [2];
			
			monthText.text = "March";
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 30){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
		
		if (monthNow == 3){

			//monthText.font = fonts [3];
			
			monthText.text = "April";
			
			cellToStart = 0;			
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 29){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
		
		if (monthNow == 4){

			//monthText.font = fonts [4];

			monthText.text = "May";
			
			cellToStart = 2;		
			
			dayOfYear = 0;		
			
			while (dayOfYear <= 30){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}			
		}
		
		if (monthNow == 5){

			//monthText.font = fonts [5];
			
			monthText.text = "June";
			
			cellToStart = 5;			
			
			dayOfYear = 0;		
			
			
			while (dayOfYear <= 29){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
		
		if (monthNow == 6){

		//	monthText.font = fonts [6];
			
			monthText.text = "July";		
			
			cellToStart = 0;			
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 30){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}	
			
		}
		
		if (monthNow == 7){

			//monthText.font = fonts [7];
			
			monthText.text = "August";
			
			cellToStart = 3;			
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 30){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
		
		if (monthNow == 8){

			//monthText.font = fonts [8];
			
			monthText.text = "September";
			
			cellToStart = 6;			
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 29){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
		
		if (monthNow == 9){

			//monthText.font = fonts [9];
			
			monthText.text = "October";
			
			cellToStart = 1;		
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 30){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
		
		if (monthNow == 10){

			//monthText.font = fonts [10];
			
			monthText.text = "November";
			
			cellToStart = 4;			
			
			dayOfYear = 0;			
			
			while (dayOfYear <= 29){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}			
			
		}
		
		if (monthNow == 11){

			//monthText.font = fonts [11];
			
			monthText.text = "December";
			
			cellToStart = 6;			
			
			dayOfYear = 0;	
			
			
			while (dayOfYear <= 30){
				
				days[cellToStart].text = (dayOfYear + 1).ToString();
				
				dayOfYear+=1;
				
				cellToStart +=1;
				
				if (cellToStart >= 35){
					
					cellToStart = 0;
					
				}
				
			}		
			
		}
	
	}
	
	
	public void NextMonth(){
	
		if (monthNow < 11){


		
			EraseAll();
			
			monthNow += 1;
			
			UpdateScreen();

			//compiler.CompilerErase_all ();

			compiler.UpdateSchedule ();
		
		}	
	}
	
	public void PreviousMonth(){
	
		if(monthNow > 0) {


		
			monthNow -= 1;
			
			EraseAll();
			
			UpdateScreen();	



			compiler.UpdateSchedule ();
		
		}
		
	}
	
	
	public void EraseAll(){	

		for (int x = 0; x <= 34; x++) {

			days[x].text = "";
		
		}
	
	}

	public void TodayHigh (){


	
		int monthis = System.DateTime.Now.Month - 1;

		//int monthis = System.DateTime.Now.Month -1;

		int dayis = System.DateTime.Now.Day -1 ;

		Debug.Log ("Today is " + monthis + " " + dayis);

		if (monthNow == monthis) {
		
			for (int i = 0; i < 30; i++) {
			
				if (i == dayis) {
				
					today [i].SetActive (true);
				
				} else
					today [i].SetActive (false);
			
			}
		
		}
		if (monthNow != monthis) {
		
			for (int i = 0; i <= 30; i++) {
			
				today [i].SetActive (false);
			
			}
		
		}



	}
	
	
}
