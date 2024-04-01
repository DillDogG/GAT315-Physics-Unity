using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject character;
    [SerializeField] KeyCode key = KeyCode.Space;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(character);
        }
    }
}
