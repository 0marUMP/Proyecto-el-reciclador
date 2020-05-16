using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidrio : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Vidrio")
        {
            Destroy(col.gameObject, (float).5);
            ScoreManager.score += 10;
        }

    }
}
