using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Walls_collision : MonoBehaviour
{
    private Material originalMaterial;

    private void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Check if the MeshRenderer is not null (to avoid null reference exception)
        if (meshRenderer != null)
        {
            // Store a reference to the original material
            originalMaterial = meshRenderer.material;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

            // Check if the MeshRenderer is not null (to avoid null reference exception)
            if (meshRenderer != null)
            {
                // Create a new material and set its color to red
                Material newMaterial = new Material(originalMaterial);
                newMaterial.color = Color.red;

                // Assign the new material to the MeshRenderer
                meshRenderer.material = newMaterial;
            }
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                // Revert to the original material by assigning it back
                meshRenderer.material = originalMaterial;
            }
        }
        
    }
}
