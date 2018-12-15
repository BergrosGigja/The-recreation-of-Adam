using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntryDialogManager : MonoBehaviour {

	private Queue<string> sentences;
	public GameObject textBox;
	public Text dialogText;
	public GameObject ContinueButton;
	public GameObject StartButton;
	public Animator anim;
	public GameObject Name;
	public GameObject Adam;


	void Start()
	{
		sentences = new Queue<string>();
	}

	public void StartDialog(DialogEntry dialog)
	{
		//anim.SetBool(IsOpen, true);
		Adam.SetActive(false);
		Name.SetActive(false);
		StartButton.SetActive(false);
		textBox.SetActive(true);
		ContinueButton.SetActive(true);

		foreach(string sentence in dialog.sentences)
		{
			sentences.Enqueue(sentence);
		}
	}

	public void DisplayNextSentence()
	{
		if(sentences.Count == 0)
		{
			return;
		}
		string sentence = sentences.Dequeue();
		StartCoroutine(TypeSentence(sentence));

	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogText.text = "";
		foreach(char letter in sentence.ToCharArray())
		{
			dialogText.text += letter;
			yield return null;
		}
	}

	void EndDialog()
	{
		//anim.SetBool(IsOpen, false);
	}
}