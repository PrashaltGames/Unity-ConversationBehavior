using System;
using Prashalt.ConversationBehavior.Core;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Set Message", story: "Speaker speaks [Message]", category: "Action/Conversation ", id: "217a56e208b6deff4321f298745a9c43")]
public partial class SetMessageAction : Action
{
    [SerializeReference] public BlackboardVariable<string> Message;
    private int _instanceID;
    private float _deltaTime;
    
    protected override Status OnStart()
    {
        _instanceID = GameObject.GetInstanceID();

        if (!ConversationBehaviorManager.Instance.DataDictionary.TryGetValue(_instanceID, out var data))
        {
            return Status.Failure;   
        }
        data.MessageText.SetText(Message.Value);
        data.MessageText.maxVisibleCharacters = 0;
            
        return Status.Running;

    }

    protected override Status OnUpdate()
    {
        if (!ConversationBehaviorManager.Instance.DataDictionary.TryGetValue(_instanceID, out var data))
        {
            return Status.Failure;
        }

        if (_deltaTime < data.MessageSpeed)
        {
            _deltaTime += Time.deltaTime;
            return Status.Running;
        }

        _deltaTime = 0;
        data.MessageText.maxVisibleCharacters++;

        return data.MessageText.maxVisibleCharacters > Message.Value.Length ? Status.Success : Status.Running;
    }
}

