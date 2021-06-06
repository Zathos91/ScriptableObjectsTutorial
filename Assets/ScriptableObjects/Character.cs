using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Character", menuName = "ScriptableObjects/New Character", order = 0)]
    public class Character : ScriptableObject
    {
        public string characterName;
        public int characterLife, characterDamage;
        public AnimatorOverrideController animatorOverrideController;
    }
}