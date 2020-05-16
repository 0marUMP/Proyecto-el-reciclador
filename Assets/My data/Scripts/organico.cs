using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organico : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Organico")
        {
            Destroy(col.gameObject, (float).5);
            ScoreManager.score += 10;

        }

    }
}
