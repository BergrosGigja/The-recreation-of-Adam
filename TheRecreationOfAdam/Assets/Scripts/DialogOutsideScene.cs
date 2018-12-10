using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogOutsideScene : MonoBehaviour {
	//creating the objects used for the dialog
	public GameObject Activate;
	public GameObject Exit;
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

	public int SelectedAnswer;

	public void Start()
	{
		Activate.SetActive(false);
	}

	void Update () 
	{
		if(Activate.activeSelf == false)
		{
           SelectedAnswer = 0;
           TextBox.GetComponent<Text>().text = "One Eyed Joe: What do you want?";
		}
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
	}


	//What happens if you choose each answer for the first question
	public void ChoiceOption1() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: The colors?";
		SelectedAnswer = 1;
		Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option04.SetActive(true);
		Option05.SetActive(true);
	}

	public void ChoiceOption2() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: What colors?";
		SelectedAnswer = 2;
		Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option06.SetActive(true);
		Option07.SetActive(true);
	}

	public void ChoiceOption3() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: What do you mean?";
		SelectedAnswer = 3;
		Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option08.SetActive(true);
		Option09.SetActive(true);
	}
	
	//What happens if you choose each answer for the second question
	public void ChoiceOption4() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: I’m sorry pal. I’m not sure what happened to them. Maybe you should check out the library. There are still some old newspapers there from when they were all disappearing.";
		SelectedAnswer = 4;
	}

	public void ChoiceOption5() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: I’m sorry pal. I’m not sure what happened to them. Maybe you should check out the library. There are still some old newspapers there from when they were all disappearing.";
		SelectedAnswer = 5;
	}
	public void ChoiceOption6() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: I’m sorry pal. I’m not sure what happened to them. Maybe you should check out the library. There are still some old newspapers there from when they were all disappearing.";
		SelectedAnswer = 6;
	}

	public void ChoiceOption7() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: I’m sorry pal. I’m not sure what happened to them. Maybe you should check out the library. There are still some old newspapers there from when they were all disappearing.";
		SelectedAnswer = 7;
	}
	public void ChoiceOption8() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: I’m sorry pal. I’m not sure what happened to them. Maybe you should check out the library. There are still some old newspapers there from when they were all disappearing.";
		SelectedAnswer = 8;
	}

	public void ChoiceOption9() 
	{
		TextBox.GetComponent<Text>().text = "One Eyed Joe: I’m sorry pal. I’m not sure what happened to them. Maybe you should check out the library. There are still some old newspapers there from when they were all disappearing.";
		SelectedAnswer = 9;
	}
	void LateUpdate () 
	{
		if(SelectedAnswer >= 4)
		{
			Option04.SetActive(false);
			Option05.SetActive(false);
			Option06.SetActive(false);
			Option07.SetActive(false);
			Option08.SetActive(false);
			Option09.SetActive(false);
		}
	}
}
