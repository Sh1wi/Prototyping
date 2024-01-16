using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    //[SerializeField] private Key3.KeyType keyType1;
    public Key.KeyType GetKeyType() 
    { 
        return keyType;
    } 
    /*public Key3.KeyType GetKeyType1()
    {
        return keyType1;
    }*/
    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }

}
