using UnityEngine;

public class HpEnemy : HpSystem
{
    private string bulletName = "buill";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(bulletName))
        {
            Damage(50);
        }
    }
    protected override void Dead()
    {
        base.Dead();
        Destroy(gameObject);
    }
}
