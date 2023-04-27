using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            
            hit += 1;
            Debug.Log("Hit: " + hit);
        }
    }
}
