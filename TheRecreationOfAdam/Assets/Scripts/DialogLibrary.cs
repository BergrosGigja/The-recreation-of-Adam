using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogLibrary : MonoBehaviour {
	//creating the objects used for the dialog
	public GameObject Activate;
	public GameObject TextBox;
	public GameObject Option01;
	public GameObject Option02;
	public GameObject Option03;
	public GameObject Option04;
	public GameObject Option05;
	public GameObject Option06;
	public GameObject Option07;
	public GameObject Option08;
	public GameObject Option09;
	public GameObject Option10;
	public GameObject Option11;
	public GameObject Option12;
	public GameObject Option13;
	public GameObject Option14;
	public GameObject Option15;
	public int SelectedAnswer;

	public void Start()
	{
		Activate.SetActive(false);
	}

	void OnMouseDown()
	{
		Activate.SetActive(true);
		Option01.SetActive(true);
		Option02.SetActive(true);
		Option03.SetActive(true);
		Option04.SetActive(false);
		Option05.SetActive(false);
		Option06.SetActive(false);
		Option07.SetActive(false);
		Option08.SetActive(false);
		Option09.SetActive(false);
		Option10.SetActive(false);
		Option11.SetActive(false);
		Option12.SetActive(false);
		Option13.SetActive(false);
		Option14.SetActive(false);
		Option15.SetActive(false);
	}


	//What happens if you choose each answer for the first question
	public void ChoiceOption1() 
	{
		TextBox.GetComponent<Text>().text = "I left";
		Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option04.SetActive(true);
		Option05.SetActive(true);
		Option06.SetActive(true);
		SelectedAnswer = 1;
	}

	public void ChoiceOption2() 
	{
		TextBox.GetComponent<Text>().text = "I hide";
		Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
		Option07.SetActive(true);
		SelectedAnswer = 2;
	}

	public void ChoiceOption3() 
	{
		TextBox.GetComponent<Text>().text = "I scared";
		Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option05.SetActive(true);
		Option08.SetActive(true);
		Option09.SetActive(true);
		SelectedAnswer = 3;
	}


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(1))
        {
            Activate.SetActive(false);
            TextBox.GetComponent<Text>().text = "You found me!";
			SelectedAnswer = 0;
        }
	}
	public void ChoiceOption4() 
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option04.SetActive(false);
		Option05.SetActive(false);
		Option06.SetActive(false);
		Option10.SetActive(true);
		Option11.SetActive(true);
		SelectedAnswer = 4;
	}

	public void ChoiceOption5()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option04.SetActive(false);
		Option05.SetActive(false);
		Option06.SetActive(false);
		Option07.SetActive(false);
		Option08.SetActive(false);
		Option09.SetActive(false);
		Option10.SetActive(true);
		Option11.SetActive(true);
		SelectedAnswer = 5;
	}

	public void ChoiceOption6()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option04.SetActive(false);
		Option05.SetActive(false);
		Option06.SetActive(false);
		Option07.SetActive(false);
		Option10.SetActive(true);
		Option11.SetActive(true);
		SelectedAnswer = 6;
	}
	public void ChoiceOption7()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option05.SetActive(false);
		Option06.SetActive(false);
		Option07.SetActive(false);
		Option10.SetActive(true);
		Option11.SetActive(true);
		SelectedAnswer = 7;
	}

	public void ChoiceOption8()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option05.SetActive(false);
		Option08.SetActive(false);
		Option09.SetActive(false);
		Option10.SetActive(true);
		Option11.SetActive(true);
		SelectedAnswer = 8;
	}
	
	public void ChoiceOption9()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option05.SetActive(false);
		Option08.SetActive(false);
		Option09.SetActive(false);
		Option10.SetActive(true);
		Option11.SetActive(true);
		SelectedAnswer = 9;
	}

	public void ChoiceOption10()
	{
		TextBox.GetComponent<Text>().text = "I scared";
		Option10.SetActive(false);
		Option11.SetActive(false);
		Option12.SetActive(true);
		Option13.SetActive(true);
		SelectedAnswer = 10;
	}

	public void ChoiceOption11()
	{
		TextBox.GetComponent<Text>().text = "I scared";
		Option10.SetActive(false);
		Option11.SetActive(false);
		Option12.SetActive(true);
		Option13.SetActive(true);
		SelectedAnswer = 11;
	}

	public void ChoiceOption12()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option12.SetActive(false);
		Option13.SetActive(false);
		Option14.SetActive(true);
		Option15.SetActive(true);
		SelectedAnswer = 12;
	}

	public void ChoiceOption13()
	{
		TextBox.GetComponent<Text>().text = "They scary";
		Option12.SetActive(false);
		Option13.SetActive(false);
		Option14.SetActive(true);
		Option15.SetActive(true);
		SelectedAnswer = 13;
	}

	public void ChoiceOption14()
	{
		SelectedAnswer = 14;
		TextBox.GetComponent<Text>().text = "OK. I be purple";
		Option14.SetActive(false);
		Option15.SetActive(false);

	}

	public void ChoiceOption15()
	{
		SelectedAnswer = 15;
		TextBox.GetComponent<Text>().text = "OK. I be purple";
		Option14.SetActive(false);
		Option15.SetActive(false);
	}
}

