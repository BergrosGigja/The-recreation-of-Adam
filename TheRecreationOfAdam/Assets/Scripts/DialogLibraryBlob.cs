using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogLibraryBlob : MonoBehaviour {
	//creating the objects used for the dialog
	 public GameObject Activate;
    public GameObject Exit;
    public GameObject blob;
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
           blob.GetComponent<TextMeshProUGUI>().text = "Blob: Gee Wiz, thanks for freeing me from that terribly small box!";
       }   
    }

    void OnMouseDown()
    {
        Activate.SetActive(true);
        Option01.SetActive(true);
        Option02.SetActive(true);
        Option03.SetActive(false);
        Option04.SetActive(false);
    }

    public void ChoiceOption1()
    {
        blob.GetComponent<TextMeshProUGUI>().text = "Blob: They took me! They stuffed me in there. I've been stuck in there for ages.";
        SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption2()
    {
        blob.GetComponent<TextMeshProUGUI>().text = "Blob: They took me! They stuffed me in there. I've been stuck in there for ages.";
        SelectedAnswer = 2;
        Option01.SetActive(false);
		Option02.SetActive(false);
		Option03.SetActive(true);
		Option04.SetActive(true);
    }

    public void ChoiceOption3()
    {
        blob.GetComponent<TextMeshProUGUI>().text = "I have to go now. My people need me!";
        Option03.SetActive(false);
		Option04.SetActive(false);
    }

    public void ChoiceOption4()
    {
        blob.GetComponent<TextMeshProUGUI>().text = "I have to go now. My people need me!";
        SelectedAnswer = 4;
        Option03.SetActive(false);
		Option04.SetActive(false);
	}
}