using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger1 : MonoBehaviour
{
    private float spawnsRate = 1.0f;
    public List<GameObject> targets;
    public GameObject[] targets2;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        yield return new WaitForSeconds(spawnsRate);
        int index = Random.Range(0, targets.Count);
        Instantiate(targets[index]);
    }
}
