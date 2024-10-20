using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    
    [SerializeField] private GameObject _Pipe;

    private float _timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }


    
    public void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-1, 2));
        GameObject pipe = Instantiate(_Pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
