using UnityEngine;

delegate void delegate1();
public class Delegate1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		delegate1 d1 = new delegate1(Show);
		d1();
	}
	
	// Update is called once per frame
	public static void Show()
	{
		print("hoge");
	}
}
