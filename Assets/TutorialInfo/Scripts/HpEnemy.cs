using UnityEngine;

public class HpEnemy : HpSystem
{
    private string bulletName = "buill";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(bulletName))
        {
            float attack = collision.gameObject.GetComponent<Bullet>().attack;
            Damage(attack);
        }
    }
    protected override void Dead()
    {
        base.Dead();
        Destroy(gameObject);
    }
}
