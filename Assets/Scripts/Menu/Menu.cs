using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void mudar_fase(string fase) 
    {
        SceneManager.LoadScene(fase);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
