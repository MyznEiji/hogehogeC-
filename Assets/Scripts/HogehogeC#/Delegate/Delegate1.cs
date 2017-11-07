using UnityEngine;

delegate void delegate1();
delegate int delegate2(int a,int b);
delegate void delegate3(int a);
delegate void delegate6();
delegate int delegate7(int a);
public class Delegate1 : MonoBehaviour
{
	void Start()
	{
		delegate1 d1 = new delegate1(show);
		d1 += new delegate1(hoge);
		d1 += new delegate1(fuga);
		d1();

		delegate2 d2 = new delegate2(piyo);
		print(d2(2,10));

		//いままで　
		delegate3 d3 = new delegate3(ShowShow);
		d3(5);

		//匿名メソッド
		delegate3 d3s = delegate(int i){print(i);};
		d3s(10);

		delegate3 d3ss = delegate(int i)
		{
			if(i > 10) print("10より大きいです");
			else print("10以下です");
		};
		d3ss(36);


		delegate6 d6 = () => {show();};
		d6();
		delegate7 d7 = (x) => {return ShowShowShow(x);};
		d7(3);

	}
	public static void show()
	{
		Debug.Log("called");
	}
	public static void hoge()
	{
		Debug.Log("hogehoge");
	}

	public static void fuga()
	{
		Debug.Log(222222);
	}

	public int piyo(int a,int b)
	{	
		return a + b;
	}
	public void ShowShow(int a)
	{
		print(a);
	}

	public int ShowShowShow(int a)
	{
		return a;
	}
	
}