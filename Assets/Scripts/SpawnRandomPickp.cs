using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomAmmo : MonoBehaviour
{
    public GameObject pistonAmmo;
    public GameObject shotgunAmmo;

    List<GameObject> pickupList;

    // Start is called before the first frame update
    void Start()
    {
        pickupList.Add(pistonAmmo);
        pickupList.Add(shotgunAmmo);
    }

    public void SpawnDropItem()
    {
        int num = Random.Range(0, pickupList.Count);
        
    }
}
