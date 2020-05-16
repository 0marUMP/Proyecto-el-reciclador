using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public GameObject GameGanarText;
    public static GameObject GameGanarStatic;

    // Start is called before the first frame update
    void Start()
    {
        Ganar.GameGanarStatic = GameGanarText;
        Ganar.GameGanarStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void show()
    {
        Ganar.GameGanarStatic.gameObject.SetActive(true);
    }
}
