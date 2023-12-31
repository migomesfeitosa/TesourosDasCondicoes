using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Dialogo
{
    [SerializeField]
    private TextDialogo[] _frases;

    [SerializeField]
    private string _nomeNpc;

    public TextDialogo[] GetFrases() 
    { 
        return _frases; 
    }

    public string GetNomeNpc()
    {
        return _nomeNpc;
    }
}
