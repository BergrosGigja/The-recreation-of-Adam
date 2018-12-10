using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScriptOne : MonoBehaviour
{
    //creating the objects used for the dialog
    public GameObject Activate;
    public GameObject Exit;
    public GameObject TextBox;
    public GameObject Option01;
    public GameObject Option02;
    public GameObject Option03;
    public GameObject Option04;
    public GameObject Option05;

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
    }


    //What happens if you choose each answer for the first question
    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "Nurse: You were in a car accident 10 years ago.";
        SelectedAnswer = 1;
    }

    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Nurse: You are at the hospital.";
        SelectedAnswer = 2;
    }

    public void ChoiceOption3()
    {
        TextBox.GetComponent<Text>().text = "Nurse: You have been in a coma for 10 years. Alot has happened.";
        SelectedAnswer = 3;
    }


    // Update is called once per frame
    void Update()
    {
        if (SelectedAnswer >= 1)
        {
            Option01.SetActive(false);
            Option02.SetActive(false);
            Option03.SetActive(false);
            Option04.SetActive(true);
            Option05.SetActive(true);
        }

        
       if(Activate.activeSelf == false)
       {
           SelectedAnswer = 0;
           TextBox.GetComponent<Text>().text = "Nurse: Adam, why are you up?";
       }
        
    }

    //What happens if you choose each answer for the second question
    public void ChoiceOption4()
    {
        TextBox.GetComponent<Text>().text = "Nurse: All the colors are gone.";
        SelectedAnswer = 4;
    }

    public void ChoiceOption5()
    {
        TextBox.GetComponent<Text>().text = "Nurse: All the colors are gone.";
        SelectedAnswer = 5;
    }
    void LateUpdate()
    {
        if (SelectedAnswer >= 4)
        {
            Option04.SetActive(false);
            Option05.SetActive(false);
        }
    }
}
