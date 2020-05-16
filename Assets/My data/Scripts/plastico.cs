using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plastico : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Plastico")
        {
            Destroy(col.gameObject, (float) .5);
            ScoreManager.score += 10;
        }
            
    }
}
