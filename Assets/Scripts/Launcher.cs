using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] GameObject character;
    [SerializeField] float speed = 1;

    public void Launch()
    {
        GameObject gameObject = Instantiate(character, transform.position, transform.rotation);
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);// = Vector3.forward * speed;
    }
}
