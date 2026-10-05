using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BalVeranderenMetContact : MonoBehaviour

{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionExit(Collision collision)
    {
        objectRenderer.material.color = Color.lightBlue;
    }
}