using UnityEngine;

namespace ScriptableObjects {
    [CreateAssetMenu(fileName = "New Base", menuName = "Base")]
    public class TowerBaseSO : ScriptableObject {
        public float towerMultiplier;
    }
}