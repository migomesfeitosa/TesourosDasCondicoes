using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{


    public int TextoContador1;
    public Text controlador1;
    public int TextoContador2;
    public Text controlador2;
    public int TextoContador3;
    public Text controlador3;
    public int TextoContador4;
    public Text controlador4;

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
        setContador1();
    }

    public void case1()
    {
        controller.case1();
        setContador2();
    }

    public void case2()
    {
        controller.case2();
        setContador3();
    }
    public void case3()
    {
        controller.case3();
        setContador4();
    }

    public void cases()
    {
        controller.cases();
    }

    public void LimpaCampos()
    {
        controller.LimparCampos();
        controlador1.text = "0";
        controlador2.text = "0";
        controlador3.text = "0";
        controlador4.text = "0";

        TextoContador1 = 0;
        TextoContador2 = 0;
        TextoContador3 = 0;
        TextoContador4 = 0;
    }


    public void setContador1()
    {
        TextoContador1++;
        recarregarTela();

    }

    public void setContador2()
    {
        TextoContador2++;
        recarregarTela();

    }

    public void setContador3()
    {
        TextoContador3++;
        recarregarTela();

    }

    public void setContador4()
    {
        TextoContador4++;
        recarregarTela();

    }


    public void recarregarTela()
    {
        controlador1.text = TextoContador1.ToString();
        controlador2.text = TextoContador2.ToString();
        controlador3.text = TextoContador3.ToString();
        controlador4.text = TextoContador4.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene("Menu");

        }
    }


}
