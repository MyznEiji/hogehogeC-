using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour 
{
	private string letter;
	public Letter(string letter)
	{
		this.letter = letter;
	}
	public void ShowLetter()
	{
		Debug.Log(letter);
	}
}
