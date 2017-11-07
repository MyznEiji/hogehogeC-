using UnityEngine;

delegate void delegate3();
public class YourDelegate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		YourDelegateSub yds = new YourDelegateSub();
		delegate3 d3 = new delegate3(yds.show1);

		d3();

		d3 += new delegate3(yds.show2);
		d3();

		d3 += new delegate3(yds.show3);
		d3();

		d3 -= new delegate3(yds.show2);
		d3();
	}
}
