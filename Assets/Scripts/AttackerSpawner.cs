using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    public bool spawn;
    float minSpawnDelay =1f; 
    float maxSpawnDelay = 5f;
    [SerializeField] private Attacker attackerPrefab;
    public Transform cloneParent;
    IEnumerator Start()
    {
        spawn = true;
        while ( spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
        
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation,cloneParent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
