using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collision : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        hits += 1;
        Debug.Log(hits);
    }
}
