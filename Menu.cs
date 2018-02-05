using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour {

	public GameObject main_menu;
	public GameObject menu_close;
	public GameObject ImportantDatesPanel;



	public GameObject rShiftDay;
	public GameObject rShiftNight;
	public GameObject sShiftDay;
	public GameObject sShiftNight;
	public GameObject tShiftDay;
	public GameObject tShiftNight;
	public GameObject uShiftDay;
	public GameObject uShiftNight;

	bool r_on = true;
	bool s_on = true;
	bool t_on = true;
	bool u_on = true;





	void Start(){	
	
		main_menu.SetActive (false);

		ImportantDatesPanel.SetActive (false);
	
		menu_close.SetActive (false);
	
	}


	public void main_menu_open(){
	
		main_menu.SetActive (true);

		menu_close.SetActive (true);

		ImportantDatesPanel.SetActive (false);
	
	}

	public void main_menu_close(){

		main_menu.SetActive (false);
	
		menu_close.SetActive (false);

		ImportantDatesPanel.SetActive (false);
	
	}

	public void important_dates_open(){
	
		main_menu.SetActive (false);
	
		ImportantDatesPanel.SetActive (true);
	
	}

	public void important_dates_close(){

		main_menu.SetActive (true);
	
		ImportantDatesPanel.SetActive (false);

	}

	public void about_panel_open(){
	
		main_menu.SetActive (false);

		ImportantDatesPanel.SetActive (false);
	
	}

	public void about_panel_close(){

		main_menu.SetActive (false);
	
		ImportantDatesPanel.SetActive (false);

	}

	public void HideR(){
	
		if (r_on) {
		
			rShiftDay.SetActive (false);

			rShiftNight.SetActive (false);	

			r_on = false;

			return;
		
		}

		if (!r_on) {
		
			rShiftDay.SetActive (true);

			rShiftNight.SetActive (true);

			r_on = true;

			return;
		
		}	

	}



	public void HideS(){	

		if (s_on) {

			sShiftDay.SetActive (false);

			sShiftNight.SetActive (false);		

			s_on = false;

			return;
		
		}

		if (!s_on) {
		
			sShiftDay.SetActive (true);

			sShiftNight.SetActive (true);

			s_on = true;

			return;
		
		}
	}




	public void HideT(){	

		if (t_on) {
		
			tShiftDay.SetActive (false);

			tShiftNight.SetActive (false);		

			t_on = false;

			return;
		
		}

		if (!t_on) {
		
			tShiftDay.SetActive (true);

			tShiftNight.SetActive (true);

			t_on = true;

			return;		
		}

	}








	public void HideU(){	

		if (u_on) {
		
			uShiftDay.SetActive (false);

			uShiftNight.SetActive (false);

			u_on = false;

			return;
		
		}

		if (!u_on) {
		
			uShiftDay.SetActive (true);

			uShiftNight.SetActive (true);
		
			u_on = true;

			return;
		}

				
	}


}
