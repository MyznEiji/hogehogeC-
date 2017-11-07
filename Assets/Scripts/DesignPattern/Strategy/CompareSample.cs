using UnityEngine;

public class CompareSample : MonoBehaviour {

    private IComparator comparator = null;
    private int resultHeight = 0;
    private int resultAge = 0;


    void Start(){
        StrategyHuman h1 = new StrategyHuman("Yamada", 170, 60, 20);
        StrategyHuman h2 = new StrategyHuman("Sato", 175, 55, 20);
        comparator = new AgeComparator();
        resultAge = Compare(h1, h2);

        comparator = new HeightComparator();
        resultHeight = Compare(h1, h2);

        print("age :" + resultAge);
        print("height :" + resultHeight);
    }

    public int Compare(StrategyHuman h1,StrategyHuman h2){
        return comparator.compare(h1,h2);
    }
}