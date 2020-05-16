using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perder : MonoBehaviour
{
    public GameObject GamePerderText;
    public static GameObject GamePerderStatic;

    // Start is called before the first frame update
    void Start()
    {
        Perder.GamePerderStatic = GamePerderText;
        Perder.GamePerderStatic.gameObject.SetActive(false);
    }
    public static void show()
    {
        Perder.GamePerderStatic.gameObject.SetActive(true);
    }
}
