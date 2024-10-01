using System;
using Prashalt.ConversationBehavior.Core;
using TMPro;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using Unity.VisualScripting;

namespace Prashalt.ConversationBehavior.Foundation.Actions
{
    [Serializable, GeneratePropertyBag]
    [NodeDescription(name: "Set Message Text", story: "Set Message Text [Value]", category: "Action/Conversation ", id: "72aa2c6be1029e6062380c11965af1d1")]
    public partial class SetMessageTextValueAction : Action
    {
    [SerializeReference] public BlackboardVariable<TextMeshProUGUI> Value;
        protected override Status OnUpdate()
        {
            var instanceID = GameObject.GetInstanceID();
            
            ConversationBehaviorManager.Instance.DataDictionary.TryAdd(instanceID, new ());
            ConversationBehaviorManager.Instance.DataDictionary[instanceID].MessageText = Value.Value;
            
            return Status.Success;
        }
    }
}

