using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    bool dogSpawned;

    private void Start()
    {
        StartCoroutine(SpawnDogs());
    }
    IEnumerator SpawnDogs()
    {
        while (!dogSpawned)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogSpawned = true;
                yield return new WaitForSeconds(.5f);
                dogSpawned = false;
            }
            else
            {
                yield return null;
            }
        }
    }
}
