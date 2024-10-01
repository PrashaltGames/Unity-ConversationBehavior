using System;
using Prashalt.ConversationBehavior.Core;
using Unity.Behavior;
using Unity.Properties;
using UnityEngine;
using Action = Unity.Behavior.Action;

namespace Prashalt.ConversationBehavior.Foundation.Actions
{
    [Serializable, GeneratePropertyBag]
    [NodeDescription(name: "Set Message Speed", story: "Set Message Speed [Value]", category: "Action/Conversation ", id: "244ef323e3b9d045249fe134033a2276")]
    public partial class SetMessageSpeedAction : Action
    {
    [SerializeReference] public BlackboardVariable<float> Value;
        protected override Status OnUpdate()
        {
            var instanceID = GameObject.GetInstanceID();

            ConversationBehaviorManager.Instance.DataDictionary.TryAdd(instanceID, new());
            ConversationBehaviorManager.Instance.DataDictionary[instanceID].MessageSpeed = Value.Value;
            
            return Status.Success;
        }
    }
}

