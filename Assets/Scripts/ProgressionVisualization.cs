using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       

[RequireComponent(typeof(Timer))]
public class ProgressionVisualization : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    float _duration;
    private void Start()
    {
        _duration = GetComponent<Timer>().durationTime;
    }

    float GetProgression()
    {
        
        return GetComponent<Timer>().RemainingTime/_duration; 
    }
    private void Update()
    {
        slider.value = GetProgression();    
    }
}
