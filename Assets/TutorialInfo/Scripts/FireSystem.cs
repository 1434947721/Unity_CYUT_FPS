using UnityEngine;

public class FireSystem : MonoBehaviour
{
    [SerializeField, Header("buill")]
    private GameObject prefabBullet;
    [SerializeField, Header("buill_place")]
    private Transform firepoint;
    [SerializeField, Header("buill_speed"), Range(0, 3000)]
    private float firespeed = 500;

    private void Awake()
    {
        FireBullet();
    }

    private void FireBullet()
    {
        GameObject temp = Instantiate(prefabBullet, firepoint.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddForce(transform.forward * firespeed);
    }
}
