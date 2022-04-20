using UnityEngine;
public class Player : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mouseX = mousePosition.x;
        mouseX = Mathf.Clamp(mouseX, -7.5f, 7.5f);
        transform.position = new Vector3(mouseX, -4.3f, 0);

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Idle", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Idle", false);
        }
    }
}
