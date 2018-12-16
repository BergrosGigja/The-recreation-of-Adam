using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogLibrarian : MonoBehaviour {
	//creating the objects used for the dialog
	 public GameObject Activate;
    public GameObject Exit;
    public GameObject librarian;
    public GameObject Option01;
    public GameObject Option02;
    public GameObject Option03;
    public GameObject Option04;

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
           librarian.GetComponent<TextMeshProUGUI>().text = "<b>Librarian:</b> Can I help you with something?";
       }   
    }

    void OnMouseDown()
    {
        Activate.SetActive(true);
        Option01.SetActive(true);
        Option02.SetActive(true);
        Option03.SetActive(false);
        Option04.SetActive(false);
        FindObjectOfType<AudioManager>().Play("Library");
    }

    public void ChoiceOption1()
    {
        librarian.GetComponent<TextMeshProUGUI>().text = "<b>Librarian:</b> We have today's newspaper on the table over there. If you need more information there are some books in the back.";
        SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption2()
    {
        librarian.GetComponent<TextMeshProUGUI>().text = "<b>Librarian:</b> We have today's newspaper on the table over there. If you need more information there are some books in the back.";
        SelectedAnswer = 2;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption3()
    {
        librarian.GetComponent<TextMeshProUGUI>().text = "<b>Librarian:</b> (aggressively) Shhh...";
        Option03.SetActive(false);
		Option04.SetActive(false);
    }

    public void ChoiceOption4()
    {
        librarian.GetComponent<TextMeshProUGUI>().text = "<b>Librarian:</b> (aggressively) Shhh...";
        SelectedAnswer = 4;
        Option03.SetActive(false);
		Option04.SetActive(false);
	}
}