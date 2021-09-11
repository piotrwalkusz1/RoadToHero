using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFogEffect : MonoBehaviour
{
    public List<GameObject> affectedObjects;

    void OnTriggerEnter(Collider other)
    {
        if (affectedObjects.Contains(other.gameObject))
        {
            other.transform.Rotate(180 * Vector3.up, Space.Self);
        }
    }
}
