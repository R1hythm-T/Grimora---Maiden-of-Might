using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Thunder Strike Effect", menuName = "Data/Item Effect/Thunder Strike")]

public class ThunderStrikeEffect : ItemEffect
{
    [SerializeField] private GameObject thunderstrikePrefab;
    public override void ExecuteEffect(Transform _enemyPosition)
    {
        GameObject newThunderStrike = Instantiate(thunderstrikePrefab, _enemyPosition.position, Quaternion.identity);
        // This method should be overridden in derived classes
        Destroy(newThunderStrike, 1f);
    }
}
