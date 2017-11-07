using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONPrinter : MonoBehaviour {
	JsonSampleClass smpl = new JsonSampleClass();
	// Use this for initialization
	void Start () {
		smpl.name = "Yamada";
		smpl.age = 34;
		smpl.level = 1;

		string smplJson = JsonUtility.ToJson(smpl);
		print(smplJson);
		smplJson = JsonUtility.ToJson(smpl,true);
		print(smplJson);

		JsonSampleClass newSample = JsonUtility.FromJson<JsonSampleClass>(smplJson);
		print("name:" + newSample.name);
		print("age:" + newSample.age);
		print("level:" + newSample.level);

		string overwrite = "{\"age\":50}";
		JsonUtility.FromJsonOverwrite(overwrite,newSample);
		print("name:" + newSample.name);
		print("age:" + newSample.age);
		print("level:" + newSample.level);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
