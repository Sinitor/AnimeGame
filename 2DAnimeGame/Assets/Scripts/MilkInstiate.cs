using UnityEngine;
public class MilkInstiate : MonoBehaviour
{
    [SerializeField] private GameObject milkPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(milkPrefab, transform.position, transform.rotation);
    }
}
