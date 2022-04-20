using System.Collections;
using UnityEngine;

public class CheckAnim : MonoBehaviour
{
    [SerializeField] private Animator anim;  

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "Milk")
         {
            anim.SetBool("Idle", true);
         }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Milk")
        {
            anim.SetBool("Idle", false);
        }
    }
}
