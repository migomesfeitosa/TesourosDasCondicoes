using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializadorDialogo : MonoBehaviour
{
    [SerializeField]
    private GerenciadorDialogo _gerenciadorDialogo;
    [SerializeField]
    private Dialogo _dialogo;

    public void Inicializa()
    {
        if (_gerenciadorDialogo == null)
            return;
        _gerenciadorDialogo.Inicializa(_dialogo);
    }
}
