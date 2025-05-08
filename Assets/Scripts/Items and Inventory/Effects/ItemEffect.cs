using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : ScriptableObject
{
    [TextArea]
    public string effectDescription;

    public virtual void ExecuteEffect(Transform _enemyPosition)
    {
        // This method should be overridden in derived classes
        Debug.Log("Executing base item effect.");
    }
}
