using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeWrapper : MonoBehaviour
{
    public void SetDeadAnimationState()
    {
        GetComponent<Animator>().SetBool("Dead", true);
    }

    public void Destroy(float time)
    {
        Object.Destroy(gameObject, time);
    }
}
