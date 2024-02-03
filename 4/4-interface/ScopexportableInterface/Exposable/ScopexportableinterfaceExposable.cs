using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceExposable
    {
        public interface IExposable
        {
            void ExposeInstance();

            void CleanInstance();
        }

        public interface IExposable<T>
        {
            T ExposeInstance();

            T CleanInstance();
        }
    }
}