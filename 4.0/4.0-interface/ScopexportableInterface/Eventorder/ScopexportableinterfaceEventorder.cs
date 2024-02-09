using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceEventorder
    {
        public interface IEventorder
        {
            void Eventorder();
        }

        public interface IEventorder<T>
        {
            T Eventorder();
        }
    }
}