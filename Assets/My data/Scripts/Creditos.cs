using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Creditos : MonoBehaviour
{
    public void creditos(string Creditos)
    {
        SceneManager.LoadScene(Creditos);
    }
}
