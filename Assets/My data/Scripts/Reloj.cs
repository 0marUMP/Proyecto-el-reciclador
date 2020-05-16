using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloj : MonoBehaviour
{
    public float tiempo = 1;
    public string scena;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Temp());
    }

    IEnumerator Temp()
    {
        yield return new WaitForSeconds(tiempo);
        SceneManager.LoadScene(scena);
    }
}
