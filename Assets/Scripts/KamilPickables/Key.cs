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
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player") && collision.gameObject.tag == "Player")
        print("Door Open!");
        1{
            collision.GetComponent<InventoryManager1>().AddKey(keyType);
            //KeyCollector keyCollector = collision.gameObject.GetComponent<KeyCollector>();
            //keyCollector.keys += 1; // private variable therfore not accesible
            //keyCollector.AddKey(1);
            gameObject.SetActive(false);
        }
    }

}