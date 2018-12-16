using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogEndBlob : MonoBehaviour {

	public GameObject Activate;
    public GameObject Exit;
    public GameObject endBlobs;
    public GameObject Option01;
    public GameObject Option02;
    public GameObject Option03;
    public GameObject Option04;
	public GameObject Option05;
    public GameObject Option06;

    public int SelectedAnswer;

	// Use this for initialization
	void Start () 
	{
		Activate.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Activate.activeSelf == false)
       {
           SelectedAnswer = 0;
           endBlobs.GetComponent<TextMeshProUGUI>().text = "<b>White:</b> Adam... is that really you? We thought we'd never see you again.";
       } 
	}

	void OnMouseDown()
    {
		switch(SelectedAnswer) 
		{
			case 0:
				ChoiceStart();
				break;
			case 1:
				ChoiceOption1();
				break;
			case 2:
				ChoiceOption2();
				break;
			case 3:
				ChoiceOption3();
				break;
			case 4:
				ChoiceOption4();
				break;
			default:
				Debug.Log("end");
				break;
		}
    }

	public void ChoiceStart() {
		Activate.SetActive(true);
		Option01.SetActive(true);
		Option02.SetActive(false);
		Option03.SetActive(false);
		Option04.SetActive(false);
		Option05.SetActive(false);
		Option06.SetActive(false);
	}

    public void ChoiceOption1()
    {
        endBlobs.GetComponent<TextMeshProUGUI>().text = "<b>White:</b> Bro... you don't remember us? We were your best friends, at least before you disappeared...";
		SelectedAnswer = 1;
        Option01.SetActive(false);
		Option02.SetActive(true);
    }

    public void ChoiceOption2()
    {
        endBlobs.GetComponent<TextMeshProUGUI>().text = "<b>White:</b> Well yeah, isn't this great? Your plan worked just like you said it would!";
		SelectedAnswer = 2;
		Option02.SetActive(false);
		Option03.SetActive(true);
    }

	public void ChoiceOption3()
    {
        endBlobs.GetComponent<TextMeshProUGUI>().text = "<b>White:</b> Yes, they were all happy... but not us. After the council decided me and Black were not colors anymore they treated us like trash. You too, because you were the only black and white blob in Blobbytown.";
		SelectedAnswer = 3;
		Option03.SetActive(false);
		Option04.SetActive(true);
    }

    public void ChoiceOption4()
    {
        endBlobs.GetComponent<TextMeshProUGUI>().text = "You made a plan to get our revenge by getting rid of all the colors. So do you want to help us or give up and let things go back to the way they were?";
        SelectedAnswer = 4;
		Option04.SetActive(false);
		Option05.SetActive(true);
		Option06.SetActive(true);
	}

	public void ChoiceGoodGuy(){
		Debug.Log("Good guy");
	}

	public void ChoiceBadGuy() {
		Debug.Log("Bad guy");
	}
}