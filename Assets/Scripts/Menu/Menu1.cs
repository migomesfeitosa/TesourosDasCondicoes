using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{

    public FaseFinalController controller;
    public void mudar_fase(string fase) 
    {
        SceneManager.LoadScene(fase);
    }
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    public void case0()
    {
        controller.case0();
    }

    public void case1()
    {
        controller.case1();
    }

    public void case2()
    {
        controller.case2();
    }
    public void case3()
    {
        controller.case3();
    }

    public void cases()
    {
        controller.cases();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene("Menu");
            
        }
    }
}
