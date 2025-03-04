﻿using UnityEngine;

namespace Assets.Sample02Serialize
{
    public class MyBehaviour : MonoBehaviour
    {
        public S1 S1_public;
        private S1 _s1_private;

        void Awake()
        {
            Debug.Log($"{Time.frameCount}frame : {nameof(MyBehaviour)} Awake");
        }

        void Start()
        {
            Debug.Log($"{Time.frameCount}frame : {nameof(MyBehaviour)} Start");
        }

        private bool _isUpdated;
        void Update()
        {
            if (!_isUpdated)
            {
                _isUpdated = true;
                Debug.Log($"{Time.frameCount}frame : {nameof(MyBehaviour)} 1st Update");
            }
        }

        public void AllCountUp()
        {
            S1_public.CountUp();
            _s1_private?.CountUp();
        }

        public string AllGetText()
        {
            return nameof(MyBehaviour) + "'s" + "\n"
                + "    s1_public" + "\n"
                + S1_public.GetText() + "\n"
                + "    s1_private" + "\n"
                + (_s1_private?.GetText() ?? "    null");
        }
    }
}
