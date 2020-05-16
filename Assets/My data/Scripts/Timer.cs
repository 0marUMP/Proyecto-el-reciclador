using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text tiempoText;
    public float tiempo = 333.0f;

    public void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0") + " segundos";
        if(tiempo <= 0)
        {
            Perder.show();
            if(tiempo <= -2)
            {
                SceneManager.LoadScene("Menu");
            }
            
        }
    }
}