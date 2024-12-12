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

    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;

    public List<GameObject> collectedObjects = new List<GameObject>();

    //GameObject item;
   
    public void AddItem(GameObject s)
    {
        collectedObjects.Add(s);
    }

    public void Collect(GameObject cube)
    {
        /*if (collectedObjects.Count > 0) //checks there are items in the list
        {
            
        }*/

        foreach (GameObject item in collectedObjects) //goes through each item in the list
        {
            if (item == Cube)
            {
                item1.SetActive(true);
                Destroy(cube);
            }
            else if (item == Cube1)
            {
                item2.SetActive(true);
                Destroy(cube);

            }
            else if (item == Cube2)
            {
                item3.SetActive(true);
                Destroy(cube);
            }
            else
            {
                return;
            }
        }
    }

    void Start()
    {
        item1.SetActive(false);
        item2.SetActive(false);
        item3.SetActive(false);

        Cube = GameObject.Find("Cube");
        Cube1 = GameObject.Find("Cube1");
        Cube2 = GameObject.Find("Cube2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
