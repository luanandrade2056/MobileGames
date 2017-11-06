using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TipoItem
{
    private int tipoItemID;

    public int TipoItemID
    {
        get { return tipoItemID; }
        set { tipoItemID = value; }
    }

    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
