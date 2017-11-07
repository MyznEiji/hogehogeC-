using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharLetter : MonoBehaviour 
{
	public char singleletter;
	
	public CharLetter(char c)
	{
		singleletter = c;
	}

	public void ShowCharLetter()
	{
		Debug.Log(singleletter);
	}
}
