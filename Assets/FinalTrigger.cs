using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalTrigger : MonoBehaviour
{
    public TextMeshPro TextMesh;

    private void Start()
    {
        TextMesh = gameObject.GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        TextMesh.text = "FINISHED!!!";
    }
}
