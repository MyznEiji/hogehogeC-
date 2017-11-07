using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterFactory : MonoBehaviour {
	private readonly Dictionary<char,CharLetter> list = new Dictionary<char,CharLetter>();
	private static readonly LetterFactory instance = new LetterFactory();

	public LetterFactory GetInstnce()
	{
		return instance;
	}
	public CharLetter GetLetter(char c)
	{
		if(list.ContainsKey (c))
		{
			return list[c];
		}
		var unUsedletter = new CharLetter(c);
		list.Add(c,unUsedletter);

		return unUsedletter;
	}
}
