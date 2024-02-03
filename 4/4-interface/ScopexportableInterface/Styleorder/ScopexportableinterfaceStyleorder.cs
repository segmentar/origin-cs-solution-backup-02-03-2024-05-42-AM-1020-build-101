using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceStyleorder
    {
        public interface IStyleorder
        {
            void Styleorder();
        }

        public interface IStyleorder<T>
        {
            T Styleorder();
        }
    }
}