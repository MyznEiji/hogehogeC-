using UnityEngine;

delegate void mydelegate(int a);
public class MyDelegate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyDelegateSub mds = new MyDelegateSub();
		mds.show(111);
		mydelegate md = new mydelegate(mds.show);
		md(222);
		md += new mydelegate(mds.showshow);
		md(333);
	}
	

}
