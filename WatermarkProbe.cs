using UnityEngine;
using UnityEngine.Rendering;

namespace AbyssMoth.Internal.Codebase.Utils
{
    [DisallowMultipleComponent]
    public sealed class WatermarkProbe : MonoBehaviour
    {
        private void Awake()
        {
            var visible = Watermark.IsVisible();
            Debug.Log($"<color=yellow>Watermark visible: {visible}</color>");
        }
    }
}
