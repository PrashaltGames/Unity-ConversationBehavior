using System;
using Prashalt.ConversationBehavior.Core;
using TMPro;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

namespace Prashalt.ConversationBehavior.Foundation.Actions
{
    [Serializable, GeneratePropertyBag]
    [NodeDescription(name: "Set Speaker Text", story: "Set Speaker Text [Value]", category: "Action/Conversation ", id: "1b3de9eb3702cf9f04e8f0a6160756a4")]
    public partial class SetSpeakerTextAction : Action
    {
    [SerializeReference] public BlackboardVariable<TextMeshProUGUI> Value;
        protected override Status OnUpdate()
        {
            var instanceID = GameObject.GetInstanceID();
            
            ConversationBehaviorManager.Instance.DataDictionary.TryAdd(instanceID, new ());
            ConversationBehaviorManager.Instance.DataDictionary[instanceID].SpeakerText = Value.Value;
            
            return Status.Success;
        }
    }
}
