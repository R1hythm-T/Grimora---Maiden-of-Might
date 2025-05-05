using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTriggers : MonoBehaviour
{
    private Player player => GetComponentInParent<Player>();
    private void AnimationTrigger()
    {
        player.AnimationTrigger();
    }

    private void AttackTrigger()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(player.attackCheck.position, player.attackCheckRadius);

        foreach (var hit in colliders)
        {
            if (hit.GetComponent<Enemy>() != null)
            {
                EnemyStats _target = hit.GetComponent<EnemyStats>();

                player.stats.DoDamage(_target);

                Inventory.instance.GetEquipment(EquipmentType.Weapon).Effect(_target.transform);

                ItemData_Equipment weaponData = Inventory.instance.GetEquipment(EquipmentType.Weapon);
                if (weaponData != null)
                { 
                    weaponData.Effect(_target.transform);
                }
            }
        }
    }



    private void ThrowSword()
    {
        if (!player.sword)

        {
            SkillManager.instance.sword.CreateSword();
            return;
        }
    }
}
