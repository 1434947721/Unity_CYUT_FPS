using UnityEngine;

public class HpSystem : MonoBehaviour
{
    [SerializeField, Header("HP"), Range(0, 500)]
    private float hp;

    private void Damage(float damage)
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
