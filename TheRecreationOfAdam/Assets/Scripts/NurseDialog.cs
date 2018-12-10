using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NurseDialog : MonoBehaviour
{
    //creating the objects used for the dialog
    public GameObject Activate;
    public GameObject Exit;
    public GameObject nurse;
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
           nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: Adam, why are you up?";
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
        nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: You were in a car crash 10 years ago and you have been taking up space ever since. How are you feeling?";
        SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption2()
    {
        nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: You were in a car crash 10 years ago and you have been taking up space ever since. How are you feeling?";
        SelectedAnswer = 2;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption3()
    {
        nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: Anything you might be feling is normal, you've been in a coma for so long... You're lucky we didn't pull the plug on you.";
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
    }

    public void ChoiceOption4()
    {
        nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: Anything you might be feling is normal, you've been in a coma for so long... You're lucky we didn't pull the plug on you.";
        SelectedAnswer = 4;
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
    }

    public void ChoiceOption5()
    {
        nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: Personally I think the gray gives the place more personality that it had before. No please go bother someone else... I have work to do.";
        SelectedAnswer = 5;
        Option05.SetActive(false);
		Option06.SetActive(false);
    }

    public void ChoiceOption6()
    {
        nurse.GetComponent<TextMeshProUGUI>().text = "Nurse: Personally I think the gray gives the place more personality that it had before. No please go bother someone else... I have work to do.";
        SelectedAnswer = 6;
        Option05.SetActive(false);
		Option06.SetActive(false);
    }
}
