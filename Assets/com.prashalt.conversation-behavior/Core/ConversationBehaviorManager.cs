using System.Collections.Generic;
using Prashalt.ConversationBehavior.Foundation;

namespace Prashalt.ConversationBehavior.Core
{
    public sealed class ConversationBehaviorManager : APureSingleton<ConversationBehaviorManager>
    {
        public Dictionary<int, ConversationBehaviorData> DataDictionary = new();
    }
}