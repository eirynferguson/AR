using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using UnityEngine;

public class InteractwithCollectable : MonoBehaviour
{
    public CollectedItems list;

    public void OnMouseClick()
    {
        list.AddItem(this.gameObject);
        Destroy(this.gameObject);
    }
}
