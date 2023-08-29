using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class TextDialogo
{
    [SerializeField]
    [TextArea(1,4)]
    private string _frase;

    [SerializeField]
    private string _btnContinue;

    public string GetFrase()
    {
        return _frase;
    }

    public string GetBotaoContinuar()
    {
        return _btnContinue;
    }
}
