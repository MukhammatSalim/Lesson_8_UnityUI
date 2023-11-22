using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthcontroller : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;
    [SerializeField] private float _Health;
    [SerializeField] private float _FillSpeed;
    private float _healthPercents;

    private void Start()
    {
        _Health = 100;
        _healthPercents = _Health / 100;
    }
    public void MakeDMG(float damage)
    {
        if (_Health > 0) { 
        _Health -= damage;
        }
        else
        {
            _Health = 0;
        }

        _healthPercents = _Health / 100;
    
    }

    private void Update()
    {
       _healthbar.value = Mathf.Lerp(_healthbar.value, _healthPercents, Time.deltaTime * _FillSpeed);
    }
}
