using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       

[RequireComponent(typeof(Timer))]
public class ProgressionVisualization : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    private float _duration;
  
    Timer _timerComponent;
    private void Start()
    {
        _timerComponent = GetComponent<Timer>();
        _duration = GetComponent<Timer>().DurationTime;
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
