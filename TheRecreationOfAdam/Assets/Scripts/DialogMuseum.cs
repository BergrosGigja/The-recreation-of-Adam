using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogMuseum : MonoBehaviour {
	//creating the objects used for the dialog
	public GameObject Activate;
    public GameObject Exit;
    public GameObject Person;
    public GameObject Option01;
    public GameObject Option02;
    public GameObject Option03;
    public GameObject Option04;
	public GameObject Option05;
	public GameObject Option06;

    public int SelectedAnswer;

    public void Start()
    {
        Activate.SetActive(false);
    }

	void Update()
    {        
       if(Activate.activeSelf == false)
       {
           SelectedAnswer = 0;
           Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Welcome to the Blobby Museum. How may I hep you today?";
       }   
    }

    void OnMouseDown()
    {
        Activate.SetActive(true);
        Option01.SetActive(true);
        Option02.SetActive(true);
        Option03.SetActive(false);
        Option04.SetActive(false);
		Option05.SetActive(false);
		Option06.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Museum");
    }

    public void ChoiceOption1()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Sure sweetie, admission is free today.";
        SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption2()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Sure sweetie, admission is free today.";
        SelectedAnswer = 2;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption3()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Back in the good'ol days we used to have another exhibition room downstairs. But it's been locked for years. Someone changed the door-code and we don't know how to get in.";
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
    }

    public void ChoiceOption4()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Back in the good'ol days we used to have another exhibition room downstairs. But it's been locked for years. Someone changed the door-code and we don't know how to get in. ";
        SelectedAnswer = 4;
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
	}

	public void ChoiceOption5()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Okay sweetie, enjoy.";
        SelectedAnswer = 5;
        Option05.SetActive(false);
		Option06.SetActive(false);
	}

	public void ChoiceOption6()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "<b>Museum lady:</b> Okay sweetie, enjoy.";
        SelectedAnswer = 6;
        Option05.SetActive(false);
		Option06.SetActive(false);
	}
}