using Core;

namespace Core
{
    using System;

    public partial class ScopexportableinterfaceExposer
    {
        public interface IExposer
        {
            void ExposePage();

            void CleanPage();
        }

        public interface IExposer<T>
        {
            T ExposePage();

            T CleanPage();
        }
    }
}