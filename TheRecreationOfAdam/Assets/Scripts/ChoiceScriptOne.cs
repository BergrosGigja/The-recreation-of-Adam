using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScriptOne : MonoBehaviour {
	//creating the objects used for the dialog
	public GameObject Activate;
	public GameObject TextBox;
	public GameObject Option01;
	public GameObject Option02;
	public GameObject Option03;
	public GameObject Option04;
	public GameObject Option05;

	public int SelectedAnwer;

	public void Start()
	{
		Activate.SetActive(false);
	}

	void OnMouseDown()
	{
		Activate.SetActive(true);
		Option04.SetActive(false);
		Option05.SetActive(false);
	}


	//What happens if you choose each answer for the first question
	public void ChoiceOption1() 
	{
		TextBox.GetComponent<Text>().text = "You were in a car accident 10 years ago.";
		SelectedAnwer = 1;
	}

	public void ChoiceOption2() 
	{
		TextBox.GetComponent<Text>().text = "You are at the hospital.";
		SelectedAnwer = 2;
	}

	public void ChoiceOption3() 
	{
		TextBox.GetComponent<Text>().text = "You have been in a coma for 10 years. Alot has happened.";
		SelectedAnwer = 3;
	}


	// Update is called once per frame
	void Update () 
	{
		if(SelectedAnwer >= 1){
				Option01.SetActive(false);
				Option02.SetActive(false);
				Option03.SetActive(false);
				Option04.SetActive(true);
				Option05.SetActive(true);
		}
	}
	
	//What happens if you choose each answer for the second question
	public void ChoiceOption4() 
	{
		TextBox.GetComponent<Text>().text = "All the colors are gone.";
		SelectedAnwer = 4;
	}

	public void ChoiceOption5() 
	{
		TextBox.GetComponent<Text>().text = "All the colors are gone.";
		SelectedAnwer = 5;
	}
	void LateUpdate () 
	{
		if(SelectedAnwer >= 4){
				Option04.SetActive(false);
				Option05.SetActive(false);
		}
	}
}
