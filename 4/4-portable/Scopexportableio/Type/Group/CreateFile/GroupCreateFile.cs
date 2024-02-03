using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static FileInfo GroupCreateFile(String FileFilename_VALUE, Boolean answer_CREATE_should, String Content_VALUE)
        {
            FileInfo fileInfoResult = default;

            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && Directory.Exists(FileFilename_VALUE) is false;

            Boolean isEqualCheck;

            isEqualCheck = boolean is true;

            if (isEqualCheck is true)
            {
                File.WriteAllText(FileFilename_VALUE, Content_VALUE);
            }
            else
                "false".ToString();

            FileInfo fileInfo;

            fileInfo = new FileInfo(FileFilename_VALUE);

            fileInfoResult = fileInfo;

            return fileInfoResult;
        }
    }
}
