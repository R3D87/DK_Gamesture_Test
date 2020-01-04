using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Time in seconds")]
    public float DurationTime = 3;
    public bool Autostart = true;
    public float RemainingTime { get { return DurationTime - _elapsedTime; } }
    public UnityEvent OnTimeUpEvent;

    private bool _isExecuting = false;
    private float _elapsedTime = 0;

    private void OnEnable()
    {
        if (Autostart)
            Run();
    }

    public void Run()
    {
        _elapsedTime = 0;
        _isExecuting = true;
    }

    private void Update()
    {    
        if (!_isExecuting)
            return;
        _elapsedTime += Time.deltaTime;
        if (IsTimeUp())
        {
            _isExecuting = false;
           if (OnTimeUpEvent != null)
                OnTimeUpEvent.Invoke();
        }
    }
    public bool IsTimeUp()
    {
        return _elapsedTime >= DurationTime;
    }
    private void OnDisable()
    {
        _isExecuting = false;
    }
}
    

