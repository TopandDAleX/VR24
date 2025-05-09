using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Animator anim_;
    private void OnMouseDown()
    {
        anim_.SetTrigger("Go");
    }
}
