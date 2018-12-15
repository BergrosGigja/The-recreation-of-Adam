using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

	public Text DialogText;
	public GameObject Name;
	public GameObject Adam;
	public GameObject PlayButton;
	public GameObject ContinueButton;
	public GameObject StartGameButton;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		StartGameButton.SetActive(false);
		ContinueButton.SetActive(false);
	}

	public void StartDialog(Dialog dialog)
	{
		sentences.Clear();
		ContinueButton.SetActive(true);
		Name.SetActive(false);
		PlayButton.SetActive(false);
		Adam.SetActive(false);

		foreach(string sentence in dialog.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
		if(sentences.Count == 0)
		{
			EndDialog();
			return;
		}
	}

	IEnumerator TypeSentence(string sentence)
	{
		DialogText.text = "";
		foreach(char letter in sentence.ToCharArray())
		{
			DialogText.text += letter;
			yield return null;
		}
	}

	void EndDialog()
	{
		ContinueButton.SetActive(false);
		StartGameButton.SetActive(true);
	}
}