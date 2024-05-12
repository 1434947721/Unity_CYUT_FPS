using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HpPlayer : HpSystem
{
    [SerializeField, Header("HPfount")]
    private Image imgHP;
    [SerializeField, Header("Text")]
    private TMP_Text textHp;
    
    private string enemyAttackArea = "atk_area";
    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
        UpdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(enemyAttackArea))
        {
            Damage(50);
        }
    }

    private void UpdateUI()
    {
        imgHP.fillAmount = hpMax / hpMax;
        textHp.text = $"HP: {hp} / {hpMax}";
    }

    protected override void Damage(float damage)
    {
        if (hp <= 0) return;
        base.Damage(damage);
        UpdateUI();
    }
}
