using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salir : MonoBehaviour
{
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Se salio del juego");
    }
}
