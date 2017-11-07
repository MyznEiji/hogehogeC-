using UnityEngine;

public class event01 : MonoBehaviour
{
	float time = 0;
	MyClass mc = new MyClass();
	MyEventClass myevent = new MyEventClass();

	void Start()
	{
		myevent.eventname += new MyDelegate32(mc.show);
	}
	void Update()
	{
		time += Time.deltaTime;
		if(time > 10)
		{
			myevent.OnEventname();
			time = 0;
		}
	}
}