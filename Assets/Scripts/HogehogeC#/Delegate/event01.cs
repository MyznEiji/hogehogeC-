using UnityEngine;

public class event01 : MonoBehaviour {
	float time = 0;
	MyClass mc = new MyClass();
	MyEventClass myEventClass = new MyEventClass();

	// Use this for initialization
	void Start () {
		myEventClass.eventname += new Mydelegate2(mc.show);

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
			if (time > 10)
			{
				myEventClass.OnEventname();
				time = 0;
			}
	}
}
