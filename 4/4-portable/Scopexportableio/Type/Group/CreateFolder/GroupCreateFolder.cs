using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static DirectoryInfo GroupCreateFolder(String DirectoryFullName___VALUE, Boolean answer_CREATE_should)
        {
            DirectoryInfo directoryInfoResult = default;

            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && Directory.Exists(DirectoryFullName___VALUE) is false;

            Boolean isEqualContagentCheck;

            isEqualContagentCheck = boolean is true;

            DirectoryInfo directoryInfo;

            if (isEqualContagentCheck)
            {
                directoryInfo = Directory.CreateDirectory(DirectoryFullName___VALUE);
            }
            else
            {
                directoryInfo = new DirectoryInfo(DirectoryFullName___VALUE);
            }

            directoryInfoResult = directoryInfo;

            return directoryInfoResult;
        }
    }
}
