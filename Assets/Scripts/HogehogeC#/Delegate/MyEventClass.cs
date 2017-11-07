using UnityEngine;

public delegate void MyDelegate32();
public class MyEventClass : MonoBehaviour
{
	public event MyDelegate32 eventname;

	public void OnEventname()
	{
		if(eventname != null)
		{
			eventname();
		}
	}
}