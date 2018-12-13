using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogFancyPants : MonoBehaviour {
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
           Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: What? I'm in a hurry";
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
    }

    public void ChoiceOption1()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: Fine, make quick. I'm on my way to seef 50 shades of grey.";
        SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption2()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: Fine, make quick. I'm on my way to seef 50 shades of grey.";
        SelectedAnswer = 2;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption3()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: Ugh, well I did see something wierd in the museum today.. They call that art?";
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
    }

    public void ChoiceOption4()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: Ugh, well I did see something wierd in the museum today.. They call that art?";
        SelectedAnswer = 4;
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
	}

	public void ChoiceOption5()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: I really need to go the show is starting.";
        SelectedAnswer = 5;
        Option05.SetActive(false);
		Option06.SetActive(false);
	}

	public void ChoiceOption6()
    {
        Person.GetComponent<TextMeshProUGUI>().text = "Fancy Pants: I really need to go the show is starting.";
        SelectedAnswer = 6;
        Option05.SetActive(false);
		Option06.SetActive(false);
	}
}