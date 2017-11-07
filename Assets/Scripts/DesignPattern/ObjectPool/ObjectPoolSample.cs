using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolSample : MonoBehaviour {

    [SerializeField] GameObject pollObject;
    [SerializeField] int polledAmount = 20;
    [SerializeField] List<GameObject> pollList;
    void Start()
    {
        pollList = new List<GameObject>();
        for(int i = 0; i < polledAmount; i++)
        {
            GameObject gameObject = Instantiate
            (
                pollObject, Vector3.right * i,transform.rotation
            );
            gameObject.SetActive(false);
            pollList.Add(gameObject);
        }
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            getPollObject();
        }
    }

    public GameObject getPollObject()
    {
        for(int i = 0; i < pollList.Count; i++)
        {
            if(!pollList[i].activeInHierarchy)
            {
                pollList[i].SetActive(true);
                return pollList[i];
            }
        }
        GameObject gameObject = Instantiate(pollObject);
        pollList.Add(gameObject);
        return gameObject;
    }
}
