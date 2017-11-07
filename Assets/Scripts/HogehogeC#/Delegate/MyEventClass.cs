using UnityEngine;

public delegate void Mydelegate2();
public class MyEventClass : MonoBehaviour {
	public event Mydelegate2 eventname;

	public void OnEventname()
	{
		if(eventname != null)
		{
			eventname();
		}
	}
}
