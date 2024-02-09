using Core;

namespace Core
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class Scopexportablemagic
    {
        public static LinkedListNode<T> ScopexportablemagicLinkedListNodeDispenser<T>(T Type_VALUE)
        {
            LinkedListNode<T> nodeResult = default;

            LinkedListNode<T> node;

            node = new LinkedListNode<T>(Type_VALUE);

            nodeResult = node;

            return nodeResult;
        }
    }
}
