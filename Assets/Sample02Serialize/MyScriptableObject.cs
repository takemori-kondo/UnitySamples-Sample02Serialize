using UnityEngine;

namespace Assets.Sample02Serialize
{
    [CreateAssetMenu(menuName = "Sample02Serialize/MyScriptableObject")]
    public class MyScriptableObject : ScriptableObject
    {
        public S1 S1_public;
        private S1 _s1_private;

        public void AllCountUp()
        {
            S1_public.CountUp();
            _s1_private?.CountUp();
        }

        public string AllGetText()
        {
            return nameof(MyScriptableObject) + "'s" + "\n"
                + "  s1_public" + "\n"
                + S1_public.GetText() + "\n"
                + "  s1_private" + "\n"
                + (_s1_private?.GetText() ?? "    null");
        }
    }
}
