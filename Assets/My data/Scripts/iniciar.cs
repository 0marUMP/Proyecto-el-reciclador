using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class iniciar : MonoBehaviour
{
    public void Iniciar(string iniciar)
    {
        SceneManager.LoadScene(iniciar);
    }
}
