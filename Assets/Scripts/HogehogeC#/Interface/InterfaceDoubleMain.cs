using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceDoubleMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InterfaceDouble ifd = new InterfaceDouble();
		IFirst ifi;
		ISecond ise;


		ifd.Show(2);
		ifd.Show(3,4);		

		ifi = ifd;
		ifi.Show(3);
		ise = ifd;
		ise.Show(3);
	}
}
