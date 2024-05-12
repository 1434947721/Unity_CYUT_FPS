using UnityEngine;

public class HpSystem : MonoBehaviour
{
    [SerializeField, Header("HP"), Range(0, 500)]
    protected float hp;

    protected virtual void Damage(float damage)
    {
        hp -= damage;
        if (hp <= 0) Dead();

        print($"{gameObject.name} HP : {hp}");
    }

    protected virtual void Dead()
    {
        print($"{gameObject.name} You die");
    }
}
