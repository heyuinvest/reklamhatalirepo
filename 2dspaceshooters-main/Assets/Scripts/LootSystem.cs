using UnityEngine;
[System.Serializable]
public class ItemToSpawn
{
    public string rarity;
    public GameObject Item;
    public float SpawnRate;
    [HideInInspector] public float minSpawnProbability, maxSpawnProbability;
}
public class LootSystem : MonoBehaviour
{
    [SerializeField] ItemToSpawn[] itemToSpawn;
    public bool Assigned = false;
   
    void OnEnable()
    {
        for (int i = 0; i < itemToSpawn.Length; i++)//For turning the obj off;
        {
            if (itemToSpawn[i].Item.activeSelf)
            {
                itemToSpawn[i].Item.SetActive(false);
                break;
            }

        }
        if (!Assigned)
        {
            for (int i = 0; i < itemToSpawn.Length; i++)
            {
                if (i == 0)
                {
                    itemToSpawn[i].minSpawnProbability = 0;
                    itemToSpawn[i].maxSpawnProbability = itemToSpawn[i].SpawnRate - 1;
                }
                else
                {

                    itemToSpawn[i].minSpawnProbability = itemToSpawn[i - 1].maxSpawnProbability + 1;
                    itemToSpawn[i].maxSpawnProbability = itemToSpawn[i].minSpawnProbability + itemToSpawn[i].SpawnRate - 1;
                }
            }
            Assigned = true;
        }//to assign probability value on items

       
       
        SpawnLoot();
    }

    private void SpawnLoot()//Spawn According to probability
    {
        float random = Random.Range(0, 100);
        for (int i = 0; i < itemToSpawn.Length; i++)
        {
            if (random>itemToSpawn[i].minSpawnProbability && random < itemToSpawn[i].maxSpawnProbability)
            {

                itemToSpawn[i].Item.SetActive(true);
                break;

            }      
        }
    }
}



