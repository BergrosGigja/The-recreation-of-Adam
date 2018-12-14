using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogOutsideScene : MonoBehaviour {
	//creating the objects used for the dialog
	public GameObject Activate;
    public GameObject Exit;
    public GameObject Joe;
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
           Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: What do you want?";
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
        FindObjectOfType<AudioManager>().Play("Joe");
    }

    public void ChoiceOption1()
    {
        Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: It's Blobember 12th, 2239 you prick, For 5 dollars I can also tell you who's president of Blobbytown.";
        SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption2()
    {
        Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: t's Blobember 12th, 2239 you prick, For 5 dollars I can also tell you who's president of Blobbytown.";
        SelectedAnswer = 2;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption3()
    {
        Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: Are you blind? We have the primary colors. Black and white along with every grey imaginable all around us.";
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
    }

    public void ChoiceOption4()
    {
        Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: Are you blind? We have the primary colors. Black and white along with every grey imaginable all around us.";
        SelectedAnswer = 4;
        Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
	}

	public void ChoiceOption5()
    {
        Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: Yeah they are, it was in the news. After all the colors left, the council decided to make black and white the primary colors. If you need more information I suggest you go to the library.";
        SelectedAnswer = 5;
        Option05.SetActive(false);
		Option06.SetActive(false);
	}

	public void ChoiceOption6()
    {
        Joe.GetComponent<TextMeshProUGUI>().text = "One Eyed Joe: Yeah they are, it was in the news. After all the colors left, the council decided to make black and white the primary colors. If you need more information I suggest you go to the library.";
        SelectedAnswer = 6;
        Option05.SetActive(false);
		Option06.SetActive(false);
	}
}