using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceBindorder
    {
        public interface IBindorder
        {
            void Bindorder();
        }

        public interface IBindorder<T>
        {
            T Bindorder();
        }
    }
}