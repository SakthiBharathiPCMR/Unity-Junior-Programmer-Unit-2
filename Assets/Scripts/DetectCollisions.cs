using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.Instance.AddLives(-1);
            Destroy(gameObject);
        }
        else if(other.CompareTag("Animal"))
        {
            GameManager.Instance.AddScores(5);
            Destroy(gameObject);
            Destroy(other.gameObject);

        }

    }

  
}
