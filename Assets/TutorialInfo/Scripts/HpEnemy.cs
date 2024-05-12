using UnityEngine;

public class HpEnemy : HpSystem
{
    protected override void Dead()
    {
        base.Dead();
        Destroy(gameObject);
    }
}
