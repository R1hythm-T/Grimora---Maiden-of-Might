using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    [SerializeField] private int maxItemsToDrop;
    [SerializeField] private ItemData[] possibleDrop;
    private List<ItemData> dropList = new List<ItemData>();

    [SerializeField] private GameObject dropPrefab;

    public virtual void GenerateDrop()
    {
        dropList.Clear(); // Clear any old data just in case

        // Build the drop list based on drop chances
        for (int i = 0; i < possibleDrop.Length; i++)
        {
            if (Random.Range(0, 100) <= possibleDrop[i].dropChance)
                dropList.Add(possibleDrop[i]);
        }

        // Safety check: make sure we have items to drop
        int itemsToDrop = Mathf.Min(maxItemsToDrop, dropList.Count);

        for (int i = 0; i < itemsToDrop; i++)
        {
            int randomIndex = Random.Range(0, dropList.Count); // Correct bounds
            ItemData randomItem = dropList[randomIndex];

            dropList.RemoveAt(randomIndex);
            DropItem(randomItem);
        }
    }

    protected void DropItem(ItemData _itemData)
    {
        GameObject newDrop = Instantiate(dropPrefab, transform.position, Quaternion.identity);
        Vector2 randomVelocity = new Vector2(Random.Range(-5, 5), Random.Range(4, 8));
        newDrop.GetComponent<ItemObject>().SetupItem(_itemData, randomVelocity);
    }
}
