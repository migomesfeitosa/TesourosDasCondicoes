using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    public GameObject inventarioPanel;
    bool inventarioActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            inventarioActive = !inventarioActive;
            inventarioPanel.SetActive(inventarioActive);
        }

        if (inventarioActive)
        {
            Cursor.lockState = CursorLockMode.None;
        } 
    }
}
