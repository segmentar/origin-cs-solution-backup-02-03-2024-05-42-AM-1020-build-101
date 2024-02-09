using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceControlorder
    {
        public interface IControlorder
        {
            void Controlorder();
        }

        public interface IControlorder<T>
        {
            T Controlorder();
        }
    }
}