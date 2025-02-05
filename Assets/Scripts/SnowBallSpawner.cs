using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _snowBallVar;

    private float _timeSpawn;

    [SerializeField] private float _startTimeInt;
    [SerializeField] private float _decreaseTime;
    [SerializeField] private float _minTime;

    private void FixedUpdate()
    {
        if (_timeSpawn <= 0)
        {
            int random = Random.Range(0, _snowBallVar.Length);
            Instantiate(_snowBallVar[random], transform.position, Quaternion.identity);
            _timeSpawn = _startTimeInt;   
            
            if (_startTimeInt > _minTime)
            {                
                _startTimeInt -= _decreaseTime;
            }            
        }
        else
        {
            _timeSpawn -= Time.deltaTime;
        }

    }
}
