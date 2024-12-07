using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;


public class CollectedItems : MonoBehaviour
{
    public GameObject items;
    public static bool isHidden = false;

    private List<GameObject> collectedObjects = new List<GameObject>();
   
    public void Add(GameObject s)
    {
        collectedObjects.Add(s);
    }

    void Start()
    {
        isHidden = false;

        items.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedObjects.Count <= 0)
        {
            if
            itemsHidden();
        }
        else
        {
            itemsShown();
        }
    }
}
