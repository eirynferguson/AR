using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;


public class CollectedItems : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    private List<GameObject> collectedObjects = new List<GameObject>();

    //GameObject item;
   
    public void Add(GameObject s)
    {
        collectedObjects.Add(s);
    }

    void Start()
    {
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedObjects.Count > 0) //checks there are items in the list
        {
            foreach (GameObject item in collectedObjects) //goes through each item in the list
            {
                if (item = Cube)
                {
                    item1.SetActive(true);
                }
                else if (item = Cube1)
                {
                    item2.SetActive(true);
                }
                else if (item = Cube2)
                {
                    item3.SetActive(true);
                }
            }
            
             
        }
    }
}
