﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.Sample02Serialize
{
    [DefaultExecutionOrder(-10)]
    public class Behaviour1 : MonoBehaviour
    {
        public Text Text;

        public MyBehaviour MyPrefab;
        private MyBehaviour _instantiated;
        public MyScriptableObject MyScriptableObject;
        public S1 S1;

        void Start()
        {
            Debug.Log($"{Time.frameCount}frame : {nameof(Behaviour1)} Start");

            Text.rectTransform.sizeDelta = new Vector2(300, 500);

            _instantiated = Instantiate(MyPrefab);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _instantiated.AllCountUp();
                MyScriptableObject.AllCountUp();
                S1.CountUp();
            }

            Text.text =
                "instantiated " + _instantiated.AllGetText() + "\n"
                + "\n"
                + "MyScriptableObject " + MyScriptableObject.AllGetText() + "\n"
                + "\n"
                + "S1" + "\n" + S1.GetText();

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(MyPrefab);
                Debug.Log($"{Time.frameCount}frame : {nameof(MyBehaviour)} Instantiated");
            }
        }
    }
}