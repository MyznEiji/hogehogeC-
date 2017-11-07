using UnityEngine;

delegate void delegate4(int d);

public class HisDelegate : MonoBehaviour
{
	void Start()
	{
		//Mydelegate ~ YourDelegate
		HisDelegateSub hds = new HisDelegateSub();
		delegate4 d4 = new delegate4(hds.show);
		d4(555);

		//匿名メソッド
		delegate4 d4s = delegate(int i)
			{ 
				print(i);
				print(i + "匿名です");
			};
		d4s(666);
	}
}