using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void ButtonGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PhysicsGame");
    }

    public void ButtonBlockBuster()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("BlockBuster");
    }

    public void ButtonCharacter()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Character");
    }

    public void ButtonCharacterAnimations()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CharacterAnimations");
    }

    public void ButtonCloth()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Cloth");
    }

    public void ButtonCollider()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Collider");
    }

    public void ButtonCollision()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Collision");
    }

    public void ButtonJoints()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Joints");
    }

    public void ButtonRagdoll()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Ragdoll");
    }

    public void ButtonRigidbody()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Rigidbody");
    }

    public void ButtonVehicle()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Vehicle");
    }
}
