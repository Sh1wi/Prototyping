using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGameButton : MonoBehaviour
{
    public GameObject menu;
    //public OptionsMenu optionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu != null)
            {
                if (menu.activeSelf)
                {
                    // If menu is active, close it
                    menu.SetActive(false);
                }
                else
                {
                    // If menu is inactive, open it
                    menu.SetActive(true);
                }
            }
        }
    }
}
