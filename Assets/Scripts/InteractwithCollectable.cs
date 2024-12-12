using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractwithCollectable : MonoBehaviour
{
    public CollectedItems list;
    public CollectedItems collected;

    //public GameObject Cube;
    //public GameObject Cube1;
    //public GameObject Cube2;

    public void Start()
    {
        list = GetComponent<CollectedItems>();
        collected = GetComponent<CollectedItems>();

        //Cube = GameObject.Find("Cube");
        //Cube1 = GameObject.Find("Cube1");
        //Cube2 = GameObject.Find("Cube2");
    }

    public void Update()
    {
        Touch touch = Input.GetTouch(0);

        // Check if the touch phase just began (indicating the player has just touched the screen).
        if (touch.phase == TouchPhase.Began)
        {
            // Create a ray from the camera through the touch position on the screen.
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            // Perform a raycast to check if the touch intersects with any objects in the AR scene.
            if (Physics.Raycast(ray, out hit))
            {
                // Get the GameObject that was hit by the raycast.
                GameObject touchedObject = hit.collider.gameObject;

                list.AddItem(touchedObject);
                collected.Collect(touchedObject);
                Destroy(touchedObject);
                

                //list.AddItem(this.gameObject);

                /*if (touchedObject == Cube)
                {
                    list.AddItem(touchedObject);
                    Destroy(touchedObject);
                    //
                }
                else if (touchedObject == Cube1)
                {
                    list.AddItem(touchedObject);
                    Destroy(touchedObject);
                    //collected.Collect(touchedObject);

                }
                else if (touchedObject == Cube2)
                {
                    list.AddItem(touchedObject);
                    Destroy(touchedObject);
                    //collected.Collect(touchedObject);
                }*/


            }
        }
    }
}
