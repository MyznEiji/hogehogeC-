using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVPrinter : MonoBehaviour {
    TextAsset csv;
    StringReader reader;
    int lineNum = 0;
    public List<string[]> csvDatas;
    // Use this for initialization
    void Start () {
        csv = Resources.Load("CSVData") as TextAsset;
        reader = new StringReader(csv.text);
        csvDatas = new List<string[]>();
        while (reader.Peek() > -1) {
            string line = reader.ReadLine();
            print(line);
            csvDatas.Add(line.Split(','));
            lineNum++;
        }

			string description = null;
			for (int i = 0; i < csvDatas [0].Length; i++) {
			    description += csvDatas[0][i];

			    if(i != csvDatas [0].Length - 1){
			        description += "、";
			    }
			}
        description += "のデータが";
        description += ((lineNum-1) + "人分あります。");

        print (description);
        print(csvDatas[1][0]);
        print(csvDatas[0][0]);
    }

}
