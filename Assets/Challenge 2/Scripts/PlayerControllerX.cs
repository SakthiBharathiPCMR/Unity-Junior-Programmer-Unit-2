using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float endTime = 1f;
    private float startTime;

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && startTime > endTime)
        {
            startTime = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }


    }
}
