using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Coregithub
    {      
        public static IList<DirectoryInfo> CoregithubSetResource(String[] DirectoryFullName___ARRAY)
        {
            ICollection<DirectoryInfo> collectionResult = default;

            collectionResult = new Collection<DirectoryInfo>();

            foreach (String DirectoryFullName___VALUE in DirectoryFullName___ARRAY)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = new DirectoryInfo(DirectoryFullName___VALUE);

                var boolean = false;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityOne) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityTwo) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityThree) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityFour) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityFive) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntitySix) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityOneHalf) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityTwoHalf) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityThreeHalf) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityFourHalf) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntityFiveHalf) is true;

                boolean = boolean || Object.Equals(directoryInfo.Name, Corestore.EntitySixHalf) is true;

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = boolean is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(directoryInfo);

                continue;
            }

            return new List<DirectoryInfo>(collectionResult);
        }
    }
}
