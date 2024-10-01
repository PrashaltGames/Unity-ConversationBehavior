using System;
using Prashalt.ConversationBehavior.Core;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

namespace Prashalt.ConversationBehavior.Foundation.Actions
{
    [Serializable, GeneratePropertyBag]
    [NodeDescription(name: "Set Speaker", story: "Set Speaker [Value]", category: "Action/Conversation ", id: "83115324605dc40ae511c211727ab13b")]
    public partial class SetSpeakerAction : Action
    {
    [SerializeReference] public BlackboardVariable<string> Value;
        protected override Status OnUpdate()
        {
            var instanceID = GameObject.GetInstanceID();
            ConversationBehaviorManager.Instance.DataDictionary[instanceID].SpeakerText.SetText(Value.Value);
            
            return Status.Success;
        }
    }
}
