using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using UnityEngine;


public class CollectedItems : MonoBehaviour
{
    private List<GameObject> collectedObjects = new List<GameObject>();

    public void Add(GameObject s)
    {
        collectedObjects.Add(s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
