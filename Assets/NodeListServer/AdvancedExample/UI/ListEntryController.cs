// Attach to the prefab for easier component access by the UI Scripts.
// Otherwise we would need slot.GetChild(0).GetComponentInChildren<Text> etc.
using UnityEngine;
using UnityEngine.UI;

namespace NodeListServer
{
    public class ListEntryController : MonoBehaviour
    {
        public Text titleText;
        public Text playersText;
        public Text latencyText;
        public Text addressText;
        public Button joinButton;
    }
}