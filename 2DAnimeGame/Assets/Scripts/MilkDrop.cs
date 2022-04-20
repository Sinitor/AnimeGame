using UnityEngine;
public class MilkDrop : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
     
    private float speed = 10f;
    private void Update()
    {
        if (transform.position.y >= 6)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Check")
        {
            sr.enabled = false;
            Score.check1-= 17;
            speed = 7f;
        }
        if (collision.gameObject.tag == "Check2")
        {
            sr.enabled = false;
            Score.check2 -= 17;
            speed = 7f;
        }
        if (collision.gameObject.tag == "Check3")
        {
            sr.enabled = false;
            Score.check3 -= 17;
            speed = 7f;
        }
        if (collision.gameObject.tag == "Check4")
        {
            sr.enabled = false;
            Score.check4 -= 17;
            speed = 7f;
        }
        if (collision.gameObject.tag == "Check5")
        {
            sr.enabled = false;
            Score.check5 -= 17;
            speed = 7f;
        }
        if (collision.gameObject.tag == "Mono")
        {
            Score.adRemake--;
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         speed = 10f;
    }
}
