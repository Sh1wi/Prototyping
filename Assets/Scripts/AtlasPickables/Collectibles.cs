using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectable : MonoBehaviour
{
    public bool isKeyCollected = false;


    private void OnTriggerEnter(Collider other)
    {
        isKeyCollected = true;
        Debug.Log("Key is collected");
        this.GetComponent<MeshRenderer>().enabled = false;
        this.GetComponent<BoxCollider>().enabled = false;
    }

}
