using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShiftCompiler : MonoBehaviour {

	CalendarScript calendarScript;
	//Find Seven Day Break
	private bool[] RShift_4Nights = new bool[366];
	int RShift_between4Nights = 13;
	int RShift_4NightsCount= 0;
	//int RShift_4NightsInitialStart = 6;
	bool RShift_4NightsDone = true;

	//------------------------------------ R SHIFT --------------------------------------------------------------
	bool[] RShift_3Days =  new bool[366];
	int RShift_between3Days = 7 ;
	int RShift_3DaysCount= 0;
	int RShift_3DaysInitialStart = 11;
	bool RShift_3DaysDone = true;


	bool[] RShift_3Nights =  new bool[366];
	int RShift_between3Nights = 3;
	int RShift_3NightsCount= 0;
	int RShift_3NightsInitialStart = 14;
	bool RShift_3NightsDone = true;


	bool[] RShift_4Days =  new bool[366];
	int RShift_between4Days = 0;
	int RShift_4DaysCount= 0;
	int RShift_4DaysInitialStart = 10;
	bool RShift_4DaysDone = false;


	//-------------------------------------------------S SHIFT -------------------------------------------------------

	private bool[] SShift_4Nights = new bool[366];
	int SShift_between4Nights = 6;
	int SShift_4NightsCount= 0;
	//int SShift_4NightsInitialStart = 6;
	bool SShift_4NightsDone = true;


	bool[] SShift_3Days =  new bool[366];
	int SShift_between3Days = 0 ;
	int SShift_3DaysCount= 0;
	int SShift_3DaysInitialStart = 11;
	bool SShift_3DaysDone = true;


	bool[] SShift_3Nights =  new bool[366];
	int SShift_between3Nights = 24;
	int SShift_3NightsCount= 0;
	int SShift_3NightsInitialStart = 14;
	bool SShift_3NightsDone = true;


	bool[] SShift_4Days =  new bool[366];
	int SShift_between4Days = 17;
	int SShift_4DaysCount= 0;
	int SShift_4DaysInitialStart = 10;
	bool SShift_4DaysDone = true;



	//------------------------------------------------- T SHIFT -------------------------------------------------------

	private bool[] TShift_4Nights = new bool[366];
	int TShift_between4Nights = 0;
	int TShift_4NightsCount= 3;
	//int TShift_4NightsInitialStart = 6;
	bool TShift_4NightsDone = false;


	bool[] TShift_3Days =  new bool[366];
	int TShift_between3Days = 21 ;
	int TShift_3DaysCount= 0;
	int TShift_3DaysInitialStart = 11;
	bool TShift_3DaysDone = true;


	bool[] TShift_3Nights =  new bool[366];
	int TShift_between3Nights = 17;
	int TShift_3NightsCount= 0;
	int TShift_3NightsInitialStart = 14;
	bool TShift_3NightsDone = true;


	bool[] TShift_4Days =  new bool[366];
	int TShift_between4Days = 10;
	int TShift_4DaysCount= 0;
	int TShift_4DaysInitialStart = 10;
	bool TShift_4DaysDone = true;

	//-------------------------------------------------- U SHIFT -----------------------------------------------

	private bool[] UShift_4Nights = new bool[366];
	int UShift_between4Nights = 20;
	int UShift_4NightsCount= 0;
	//int UShift_4NightsInitialStart = 6;
	bool UShift_4NightsDone = true;


	bool[] UShift_3Days =  new bool[366];
	int UShift_between3Days = 14 ;
	int UShift_3DaysCount= 0;
	int UShift_3DaysInitialStart = 11;
	bool UShift_3DaysDone = true;


	bool[] UShift_3Nights =  new bool[366];
	int UShift_between3Nights = 10;
	int UShift_3NightsCount= 0;
	int UShift_3NightsInitialStart = 14;
	bool UShift_3NightsDone = true;


	bool[] UShift_4Days =  new bool[366];
	int UShift_between4Days = 3;
	int UShift_4DaysCount= 0;
	int UShift_4DaysInitialStart = 10;
	bool UShift_4DaysDone = true;

	int cellToStart;



	public Text[] R_dayShift_;
	public Text[] R_ShiftNight;
	public Text[] S_Shift;
	public Text[] S_ShiftNight;
	public Text[] T_Shift;
	public Text[] T_ShiftNight;
	public Text[] U_Shift;
	public Text[] U_ShiftNight;




	void Start(){

		calendarScript = FindObjectOfType<CalendarScript> ();

		CompilerErase_all ();






		for (int days = 0; days <= 365; days++) {

			if (RShift_4NightsCount == 4) {

				RShift_4NightsDone = true;

			}

			if (RShift_between4Nights < 25 && RShift_4NightsDone) {

				RShift_4Nights [days] = false;

				RShift_between4Nights++;

			}

			if (RShift_between4Nights == 25 && RShift_4NightsDone == true) {

				RShift_4NightsDone = false;

				RShift_4NightsCount = 0;

				RShift_between4Nights = 0;

			}

			if (RShift_4NightsCount < 4 && !RShift_4NightsDone) {

				RShift_4Nights [days] = true;

				RShift_4NightsCount++;

			}

			//RSHIFT 3 DAYS
			if (RShift_3DaysCount == 3) {

				RShift_3DaysDone = true;

			}

			if (RShift_between3Days < 26 && RShift_3DaysDone) {

				RShift_3Days [days] = false;

				RShift_between3Days++;

			}

			if (RShift_between3Days == 26 && RShift_3DaysDone == true) {

				RShift_3DaysDone = false;

				RShift_3DaysCount = 0;

				RShift_between3Days = 0;

			}

			if (RShift_3DaysCount < 4 && !RShift_3DaysDone) {

				RShift_3Days [days] = true;

				RShift_3DaysCount++;

			}

			//RSHIFT 3NIGHTS
			if (RShift_3NightsCount == 3) {

				RShift_3NightsDone = true;

			}

			if (RShift_between3Nights < 26 && RShift_3NightsDone) {

				RShift_3Nights [days] = false;

				RShift_between3Nights++;

			}

			if (RShift_between3Nights == 26 && RShift_3NightsDone == true) {

				RShift_3NightsDone = false;

				RShift_3NightsCount = 0;

				RShift_between3Nights = 0;

			}

			if (RShift_3NightsCount < 3 && !RShift_3NightsDone) {

				RShift_3Nights [days] = true;

				RShift_3NightsCount++;

			}


			//RSHIFT 4DAYS
			if (RShift_4DaysCount == 4) {

				RShift_4DaysDone = true;

			}

			if (RShift_between4Days < 25 && RShift_4DaysDone) {

				RShift_4Days [days] = false;

				RShift_between4Days++;

			}

			if (RShift_between4Days == 25 && RShift_4DaysDone == true) {

				RShift_4DaysDone = false;

				RShift_4DaysCount = 0;

				RShift_between4Days = 0;

			}

			if (RShift_4DaysCount < 4 && !RShift_4DaysDone) {

				RShift_4Days [days] = true;

				RShift_4DaysCount++;

			}

			//------------------------------------------------------------------- S SHIFT ----------------------------------------------------------

			if (SShift_4NightsCount == 4) {

				SShift_4NightsDone = true;

			}

			if (SShift_between4Nights < 25 && SShift_4NightsDone) {

				SShift_4Nights [days] = false;

				SShift_between4Nights++;

			}

			if (SShift_between4Nights == 25 && SShift_4NightsDone == true) {

				SShift_4NightsDone = false;

				SShift_4NightsCount = 0;

				SShift_between4Nights = 0;

			}

			if (SShift_4NightsCount < 4 && !SShift_4NightsDone) {

				SShift_4Nights [days] = true;

				SShift_4NightsCount++;

			}

			//RSHIFT 3 DAYS
			if (SShift_3DaysCount == 3) {

				SShift_3DaysDone = true;

			}

			if (SShift_between3Days < 26 && SShift_3DaysDone) {

				SShift_3Days [days] = false;

				SShift_between3Days++;

			}

			if (SShift_between3Days == 26 && SShift_3DaysDone == true) {

				SShift_3DaysDone = false;

				SShift_3DaysCount = 0;

				SShift_between3Days = 0;

			}

			if (SShift_3DaysCount < 4 && !SShift_3DaysDone) {

				SShift_3Days [days] = true;

				SShift_3DaysCount++;

			}

			//RSHIFT 3NIGHTS
			if (SShift_3NightsCount == 3) {

				SShift_3NightsDone = true;

			}

			if (SShift_between3Nights < 26 && SShift_3NightsDone) {

				SShift_3Nights [days] = false;

				SShift_between3Nights++;

			}

			if (SShift_between3Nights == 26 && SShift_3NightsDone == true) {

				SShift_3NightsDone = false;

				SShift_3NightsCount = 0;

				SShift_between3Nights = 0;

			}

			if (SShift_3NightsCount < 3 && !SShift_3NightsDone) {

				SShift_3Nights [days] = true;

				SShift_3NightsCount++;

			}


			//RSHIFT 4DAYS
			if (SShift_4DaysCount == 4) {

				SShift_4DaysDone = true;

			}

			if (SShift_between4Days < 25 && SShift_4DaysDone) {

				SShift_4Days [days] = false;

				SShift_between4Days++;

			}

			if (SShift_between4Days == 25 && SShift_4DaysDone == true) {

				SShift_4DaysDone = false;

				SShift_4DaysCount = 0;

				SShift_between4Days = 0;

			}

			if (SShift_4DaysCount < 4 && !SShift_4DaysDone) {

				SShift_4Days [days] = true;

				SShift_4DaysCount++;

			}

			//--------------------------------------------------------------- T SHIFT ---------------------------------------------

			if (TShift_4NightsCount == 4) {

				TShift_4NightsDone = true;

			}

			if (TShift_between4Nights < 25 && TShift_4NightsDone) {

				TShift_4Nights [days] = false;

				TShift_between4Nights++;

			}

			if (TShift_between4Nights == 25 && TShift_4NightsDone == true) {

				TShift_4NightsDone = false;

				TShift_4NightsCount = 0;

				TShift_between4Nights = 0;

			}

			if (TShift_4NightsCount < 4 && !TShift_4NightsDone) {

				TShift_4Nights [days] = true;

				TShift_4NightsCount++;

			}

			//RSHIFT 3 DAYS
			if (TShift_3DaysCount == 3) {

				TShift_3DaysDone = true;

			}

			if (TShift_between3Days < 26 && TShift_3DaysDone) {

				TShift_3Days [days] = false;

				TShift_between3Days++;

			}

			if (TShift_between3Days == 26 && TShift_3DaysDone == true) {

				TShift_3DaysDone = false;

				TShift_3DaysCount = 0;

				TShift_between3Days = 0;

			}

			if (TShift_3DaysCount < 4 && !TShift_3DaysDone) {

				TShift_3Days [days] = true;

				TShift_3DaysCount++;

			}

			//RSHIFT 3NIGHTS
			if (TShift_3NightsCount == 3) {

				TShift_3NightsDone = true;

			}

			if (TShift_between3Nights < 26 && TShift_3NightsDone) {

				TShift_3Nights [days] = false;

				TShift_between3Nights++;

			}

			if (TShift_between3Nights == 26 && TShift_3NightsDone == true) {

				TShift_3NightsDone = false;

				TShift_3NightsCount = 0;

				TShift_between3Nights = 0;

			}

			if (TShift_3NightsCount < 3 && !TShift_3NightsDone) {

				TShift_3Nights [days] = true;

				TShift_3NightsCount++;

			}


			//RSHIFT 4DAYS
			if (TShift_4DaysCount == 4) {

				TShift_4DaysDone = true;

			}

			if (TShift_between4Days < 25 && TShift_4DaysDone) {

				TShift_4Days [days] = false;

				TShift_between4Days++;

			}

			if (TShift_between4Days == 25 && TShift_4DaysDone == true) {

				TShift_4DaysDone = false;

				TShift_4DaysCount = 0;

				TShift_between4Days = 0;

			}

			if (TShift_4DaysCount < 4 && !TShift_4DaysDone) {

				TShift_4Days [days] = true;

				TShift_4DaysCount++;

			}


			// ---------------------------------------------- U SHIFT ------------------------------------------------

			if (UShift_4NightsCount == 4) {

				UShift_4NightsDone = true;

			}

			if (UShift_between4Nights < 25 && UShift_4NightsDone) {

				UShift_4Nights [days] = false;

				UShift_between4Nights++;

			}

			if (UShift_between4Nights == 25 && UShift_4NightsDone == true) {

				UShift_4NightsDone = false;

				UShift_4NightsCount = 0;

				UShift_between4Nights = 0;

			}

			if (UShift_4NightsCount < 4 && !UShift_4NightsDone) {

				UShift_4Nights [days] = true;

				UShift_4NightsCount++;

			}

			//RSHIFT 3 DAYS
			if (UShift_3DaysCount == 3) {

				UShift_3DaysDone = true;

			}

			if (UShift_between3Days < 26 && UShift_3DaysDone) {

				UShift_3Days [days] = false;

				UShift_between3Days++;

			}

			if (UShift_between3Days == 26 && UShift_3DaysDone == true) {

				UShift_3DaysDone = false;

				UShift_3DaysCount = 0;

				UShift_between3Days = 0;

			}

			if (UShift_3DaysCount < 4 && !UShift_3DaysDone) {

				UShift_3Days [days] = true;

				UShift_3DaysCount++;

			}

			//RSHIFT 3NIGHTS
			if (UShift_3NightsCount == 3) {

				UShift_3NightsDone = true;

			}

			if (UShift_between3Nights < 26 && UShift_3NightsDone) {

				UShift_3Nights [days] = false;

				UShift_between3Nights++;

			}

			if (UShift_between3Nights == 26 && UShift_3NightsDone == true) {

				UShift_3NightsDone = false;

				UShift_3NightsCount = 0;

				UShift_between3Nights = 0;

			}

			if (UShift_3NightsCount < 3 && !UShift_3NightsDone) {

				UShift_3Nights [days] = true;

				UShift_3NightsCount++;

			}


			//RSHIFT 4DAYS
			if (UShift_4DaysCount == 4) {

				UShift_4DaysDone = true;

			}

			if (UShift_between4Days < 25 && UShift_4DaysDone) {

				UShift_4Days [days] = false;

				UShift_between4Days++;

			}

			if (UShift_between4Days == 25 && UShift_4DaysDone == true) {

				UShift_4DaysDone = false;

				UShift_4DaysCount = 0;

				UShift_between4Days = 0;

			}

			if (UShift_4DaysCount < 4 && !UShift_4DaysDone) {

				UShift_4Days [days] = true;

				UShift_4DaysCount++;

			}
		}

		UpdateSchedule ();

	}



	public void UpdateSchedule(){

		if (calendarScript.monthNow == 0) {

			CompilerErase_all ();

			cellToStart = 1;

			for (int i = 0; i <= 30; i++) {

				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i + cellToStart].text = "R - Night"; 

					R_ShiftNight [i + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i + cellToStart].text = "R - Night"; 
					R_ShiftNight [i + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i + cellToStart].text = ""; 

				}



				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i + cellToStart].text = "S - Night"; 

					S_ShiftNight [i + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i + cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i + cellToStart].text = "S - Night"; 
					S_ShiftNight [i + cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i + cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i + cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i + cellToStart].text = "T - Night"; 

					T_ShiftNight[i + cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i + cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i + cellToStart].text = "T - Night"; 
					T_ShiftNight[i + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i + cellToStart].text = "U - Night"; 

					U_ShiftNight[i + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i + cellToStart].text = "U - Night"; 
					U_ShiftNight[i + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i + cellToStart].text = ""; 

				}


			}				

		}

		//----------------------------------------- feb --------------------------------------------

		if (calendarScript.monthNow == 1) {

			CompilerErase_all ();

			cellToStart = 4;

			int subt = 31;

			for (int i = 31; i <= 58; i++) {

				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//----------------------------------------march------------------------------------------------------

		if (calendarScript.monthNow == 2) {

			CompilerErase_all ();

			cellToStart = 4;

			int subt = 59;

			for (int i = 59; i <= 89; i++) {

				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//---------------------------------April --------------------------------------------

		if (calendarScript.monthNow == 3) {

			CompilerErase_all ();


			cellToStart = 0;

			int subt = 90;

			for (int i = 90; i <= 119; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}


		//--------------------------------------------- MAY ---------------------------------

		if (calendarScript.monthNow == 4) {

			CompilerErase_all ();


			cellToStart = 2;

			int subt = 120;

			for (int i = 120; i <= 150; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//-------------------------------------------JUNE----------------------

		if (calendarScript.monthNow == 5) {

			CompilerErase_all ();


			cellToStart = 5;

			int subt = 151;

			for (int i = 151; i <= 180; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//-------------------------JULY-----------------------------
		if (calendarScript.monthNow == 6) {

			CompilerErase_all ();


			cellToStart = 0;

			int subt = 181;

			for (int i = 181; i <= 211; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//-------------------------------AUGUST------------------------------

		if (calendarScript.monthNow == 7) {

			CompilerErase_all ();


			cellToStart = 3;

			int subt = 212;

			for (int i = 212; i <= 242; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//-----------------------------------SEPTEMBER------------------------------------------------------------------------------
		if (calendarScript.monthNow == 8) {

			CompilerErase_all ();


			cellToStart = 6;

			int subt = 243;

			for (int i = 243; i <= 272; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//------------------------------------OCTOBER-------------------------------------------------------
		if (calendarScript.monthNow == 9) {

			CompilerErase_all ();


			cellToStart = 1;

			int subt = 273;

			for (int i = 273; i <= 303; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//--------------------------------------NOVEMBER ----------------------------------------------
		if (calendarScript.monthNow == 10) {

			CompilerErase_all ();


			cellToStart = 4;

			int subt = 304;

			for (int i = 304; i <= 333; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}

		//----------------------------------------------------------DECEMBER-----------------------------------

		if (calendarScript.monthNow == 11) {

			CompilerErase_all ();


			cellToStart = 6;

			int subt = 334;

			for (int i = 334; i <= 364; i++) {


				if (RShift_4Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 

					R_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (RShift_3Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (RShift_3Nights [i] == true) {

					R_ShiftNight [i - subt + cellToStart].text = "R - Night"; 
					R_ShiftNight [i - subt + cellToStart].color = Color.blue;
				}

				if (RShift_4Days [i] == true) {

					R_dayShift_ [i - subt + cellToStart].text = "R - Day"; 

				}

				if (!RShift_4Nights [i] && !RShift_3Nights[i]) {

					R_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!RShift_3Days [i] && !RShift_4Days[i]) {

					R_dayShift_ [i - subt + cellToStart].text = ""; 

				}





				//-------------------------- S SHIFT --------------------------------------------------

				if (SShift_4Nights [i] == true) {

					S_ShiftNight [i - subt + cellToStart].text = "S - Night"; 

					S_ShiftNight [i - subt + cellToStart].color = Color.blue;

				}

				if (SShift_3Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (SShift_3Nights [i] == true) {

					S_ShiftNight [i - subt+ cellToStart].text = "S - Night"; 
					S_ShiftNight [i - subt+ cellToStart].color = Color.blue;
				}

				if (SShift_4Days [i] == true) {

					S_Shift [i - subt+ cellToStart].text = "S - Day"; 

				}

				if (!SShift_4Nights [i]  && !SShift_3Nights[i]) {

					S_ShiftNight [i - subt + cellToStart].text = "";


				}

				if (!SShift_3Days [i] && !SShift_4Days [i]) {

					S_Shift [i - subt+ cellToStart].text = "";

				}

				//--------------------------------------  T SHIFT ---------------------------------

				if (TShift_4Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 

					T_ShiftNight[i - subt+ cellToStart].color = Color.blue;

				}

				if (TShift_3Days [i] == true) {

					T_Shift[i - subt+ cellToStart].text = "T - Day"; 

				}

				if (TShift_3Nights [i] == true) {

					T_ShiftNight[i - subt+ cellToStart].text = "T - Night"; 
					T_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (TShift_4Days [i] == true) {

					T_Shift[i - subt + cellToStart].text = "T - Day"; 

				}

				if (!TShift_4Nights [i] && !TShift_3Nights[i]) {

					T_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!TShift_3Days [i] && !TShift_4Days [i]) {

					T_Shift[i - subt + cellToStart].text = ""; 

				}

				//---------------------------- U SHIFT -------------------------

				if (UShift_4Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 

					U_ShiftNight[i - subt + cellToStart].color = Color.blue;

				}

				if (UShift_3Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (UShift_3Nights [i] == true) {

					U_ShiftNight[i - subt + cellToStart].text = "U - Night"; 
					U_ShiftNight[i - subt + cellToStart].color = Color.blue;
				}

				if (UShift_4Days [i] == true) {

					U_Shift[i - subt + cellToStart].text = "U - Day"; 

				}

				if (!UShift_4Nights [i]  && !UShift_3Nights[i]) {

					U_ShiftNight[i - subt + cellToStart].text = "";

				}

				if (!UShift_3Days [i] && !UShift_4Days [i]) {

					U_Shift[i - subt + cellToStart].text = ""; 

				}

				//subt++;

			}				

		}









	}








	public void CompilerErase_all(){

		for (int d = 0; d <= 34; d++) {		

			R_dayShift_ [d].text = "";

			R_ShiftNight[d].text = "";
			S_Shift[d].text = "";
			S_ShiftNight[d].text = "";
			T_Shift[d].text = "";
			T_ShiftNight[d].text = "";
			U_Shift[d].text = "";
			U_ShiftNight[d].text = "";



		}			

	}




}
