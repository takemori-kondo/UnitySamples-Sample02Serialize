using System;
using UnityEngine;

namespace Assets.Sample02Serialize
{
    // S1 is not UnityEngine.Object!
    [Serializable]
    public class S1
    {
        public int Num1_public;
        [NonSerialized]
        public int Num2_public_NonSerialized;
        public int Num3_property { get; set; }
        private int _num4_private;
        [SerializeField]
        private int _num5_private_SerializeField;


        public void CountUp()
        {
            Num1_public++;
            Num2_public_NonSerialized++;
            Num3_property++;
            _num4_private++;
            _num5_private_SerializeField++;
        }

        public string GetText()
        {
            return
                "        Num1_public = " + Num1_public + "\n" +
                "        Num2_public_NonSerialized = " + Num2_public_NonSerialized + "\n" +
                "        Num3_property = " + Num3_property + "\n" +
                "        _num4_private = " + _num4_private + "\n" +
                "        _num5_private_SerializeField = " + _num5_private_SerializeField;
        }
    }
}
