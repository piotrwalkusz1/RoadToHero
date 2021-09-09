using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorExtension : MonoBehaviour
{
    void SetBool(string name, bool value)
    {
        GetComponent<Animator>().SetBool(name, value);
    }
}
