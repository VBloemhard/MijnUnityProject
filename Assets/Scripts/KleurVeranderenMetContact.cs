using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class KleurVeranderenMetContact : MonoBehaviour

{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        objectRenderer.material.color = Color.lightBlue;
    }
}