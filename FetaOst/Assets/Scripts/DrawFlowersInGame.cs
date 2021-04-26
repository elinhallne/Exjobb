using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFlowersInGame : MonoBehaviour
{
    [SerializeField]
    private Transform[] spritesToSpawn;
    [SerializeField]
    private float amountOfFlowers;

    private List<Transform> transforms;
    private Vector3 area;
    private float length;
    private float height;

    private Transform quad;
    void Start()
    {
        quad = gameObject.transform.Find("Area");
        transforms = new List<Transform>();

        AddFlowersToList();
        SetArea(quad);
        InstanFlowers();
        DestroyQuad();
        
        //instansieringa va blommor.
        

    }

    private void AddFlowersToList()
    {
        foreach (Transform transform in spritesToSpawn)
        {
            transforms.Add(transform);
        }
    }

    private void SetArea(Transform transform)
    {

        area = transform.localScale;
        length = area.x;
        height = area.y;
              

    }

    private void InstanFlowers()
    {
        Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);

        for (int i = 0; i < amountOfFlowers; i++)
        {
            var newFlower = Instantiate(RandomTypeOfTramsform(), gameObject.transform.position + RandomPosition(), spawnRotation);
            newFlower.transform.parent = gameObject.transform;
        }
    }

    private Transform RandomTypeOfTramsform()
    {
        int randomNum;
        randomNum = Random.Range(0, transforms.Count);
        return transforms[randomNum];
    }

    private Vector3 RandomPosition()
    {
        
        return new Vector3(
               Random.Range(-length/2, length/2),
               0.1f,
               Random.Range(-height/2, height/2)
               );
        
    }

    private void DestroyQuad()
    {
        Destroy(quad.gameObject);
    }

}
