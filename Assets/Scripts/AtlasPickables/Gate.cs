using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    [SerializeField] private KeyCollectable doorKey;
    [SerializeField] private bool isDoorOpen = false;

    private void Start()
    {
        if (isDoorOpen == true)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door Entered");
        if (doorKey.isKeyCollected == true && isDoorOpen == false)
        {
            OpenDoor(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isDoorOpen == true)
        {
           CloseDoor();
        }
    }

    void OpenDoor()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        isDoorOpen = true;
    }

    void CloseDoor()
    {
        GetComponent<Collider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;
        isDoorOpen = false;
    }


}
