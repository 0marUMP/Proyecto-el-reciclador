using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papel : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Papel")
        {
            Destroy(col.gameObject, (float).5);
            ScoreManager.score += 10;
        }

    }
}
