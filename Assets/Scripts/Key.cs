using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType
    {
        RedKey
      
    }
    public KeyType GetKeyType()
    {
        return keyType;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player") && collision.gameObject.tag == "Player")
        //print("Door Open!");
        {
            //KeyCollector keyCollector = collision.gameObject.GetComponent<KeyCollector>();
            //keyCollector.keys += 1; // private variable therfore not accesible
            //keyCollector.AddKey(1);
            gameObject.SetActive(false);
        }
    }
}