using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Censored : MonoBehaviour
{
    public GameObject check;
    public Animator anim;

    private void Update()
    {
        if (check == null)
        {
            anim.SetBool("Des", true);
        }
    }
}
