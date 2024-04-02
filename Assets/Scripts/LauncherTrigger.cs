using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LauncherTrigger : MonoBehaviour
{
    [SerializeField] string tag = "ragdoll";
    [SerializeField] Launcher launcher;

    private void Start()
    {
        launcher.Launch();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tag)
        {
            launcher.Launch();
        }
    }
}
