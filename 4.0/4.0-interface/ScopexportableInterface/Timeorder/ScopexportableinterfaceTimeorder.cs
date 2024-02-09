using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceTimeorder
    {
        public interface ITimeorder
        {
            void Timeorder();
        }

        public interface ITimeorder<T>
        {
            T Timeorder();
        }
    }
}