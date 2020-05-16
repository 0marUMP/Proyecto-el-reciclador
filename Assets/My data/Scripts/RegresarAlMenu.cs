using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class RegresarAlMenu : MonoBehaviour
{
    public void regresarMenu(string RegresarMenu)
    {
        SceneManager.LoadScene(RegresarMenu);
    }
}
