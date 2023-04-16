using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject[] items;

    public float secondSpawn = 0.5f;
    public float min;
    public float max;

    private void Start()
    {
        
    }

    IEnumerator Spawn()
    {
        var wanted = Random.Range(min, max);
        var position = new Vector3(wanted, transform.position.y);
        GameObject gameObject = Instantiate(items[Random.Range(0, items.Length)],
        position, Quaternion.identity);
        yield return new WaitForSeconds(secondSpawn);
        Destroy(gameObject, 5f);

    }
}
