using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceAssignorder
    {
        public interface IAssignorder
        {
            void Assignorder();
        }

        public interface IAssignorder<T>
        {
            T Assignorder();
        }
    }
}