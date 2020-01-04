using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       

[RequireComponent(typeof(Timer))]
public class ProgressionVisualization : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    private Timer _timerComponent;
    private float _duration;
    private void Start()
    {
        _timerComponent = GetComponent<Timer>();
        _duration = _timerComponent.DurationTime;
    }

    private float GetProgression()
    {
        
        return _timerComponent.RemainingTime /_duration; 
    }
    private void Update()
    {
        slider.value = GetProgression();    
    }
}
