using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]

    private float _spawnRate;

    private float _lastTimeSpawn;
    [SerializeField]
    private GameObject _prefab;

    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(PeriodicSpawn());
    }

    private IEnumerator PeriodicSpawn()
    {
        Vector3 spawnPos = Vector3.zero;
        while (true)
        {
             yield return new WaitForSeconds(_spawnRate);
        spawnPos.x = Random.Range(-28f, 250f);
        spawnPos.y = Random.Range(-21f, -14f);
        Instantiate(_prefab, spawnPos, Quaternion.identity); 
        }
    }
}
