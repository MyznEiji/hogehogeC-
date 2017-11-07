using UnityEngine;

delegate void delegate5();
public class YourDelegate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		YourDelegateSub yds = new YourDelegateSub();
		delegate5 d5 = new delegate5(yds.show1);

		d5();

		d5 += new delegate5(yds.show2);
		d5();

		d5 += new delegate5(yds.show3);
		d5();

		d5 -= new delegate5(yds.show2);
		d5();
	}
}
