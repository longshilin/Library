using System;
using UnityEngine;
using UnityEngine.UI;

namespace Longshilin.Utility
{
    
    [RequireComponent(typeof(Text))]
    public class FPSCounter : MonoBehaviour
    {
        const float FPSMeasurePeriod = 0.5f;
        const string Display = "{0} FPS";

        private int _fpsAccumulator = 0;
        private float _fpsNextPeriod = 0;
        private int _currentFps;
        private Text _text;

        private void Start()
        {
            _fpsNextPeriod = Time.realtimeSinceStartup + FPSMeasurePeriod;
            _text = GetComponent<Text>();
        }

        private void Update()
        {
            // measure average frames per second
            _fpsAccumulator++;
            if (Time.realtimeSinceStartup > _fpsNextPeriod)
            {
                _currentFps = (int) (_fpsAccumulator / FPSMeasurePeriod);
                _fpsAccumulator = 0;
                _fpsNextPeriod += FPSMeasurePeriod;
                _text.text = string.Format(Display, _currentFps);
            }
        }
    }
}