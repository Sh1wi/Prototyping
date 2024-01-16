using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class GateOpen : MonoBehaviour
    {
        [SerializeField] KeyCollectable doorKey;
        bool isDoorOpen = false;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Door Entered");
            if (doorKey.isKeyCollected == true && isDoorOpen == false)
            {
                transform.Find("door").GetComponent<Collider>().enabled = false;
                transform.Find("door").GetComponent<MeshRenderer>().enabled = false;
                isDoorOpen = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (isDoorOpen == true)
            {
                transform.Find("door").GetComponent<Collider>().enabled = true;
                transform.Find("door").GetComponent<MeshRenderer>().enabled = true;
                isDoorOpen = false;
            }
        }
    }
