using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDatabase
{
    public static class Configuration
    {
        public static List<KeyValuePair<string, string>> DevTwo()
        {
            List<KeyValuePair<string, string>> _devTwo = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLServer14"),
            new KeyValuePair<string, string>("Database", "Visionblue_Dev2"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "InsolvUK"),
               new KeyValuePair<string, string>("Password", "Y?4£2Wb"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")

        };
            return _devTwo;
        }

        public static List<KeyValuePair<string, string>> StandardQA()
        {
            List<KeyValuePair<string, string>> _standardQA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLStandard"),
            new KeyValuePair<string, string>("Database", "VisionblueUK_Standard_QA"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "insolvqa"),
               new KeyValuePair<string, string>("Password", "B3lFa$t"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")

        };
            return _standardQA;
        }

        
        public static List<KeyValuePair<string, string>> FairpointQA()
        {
            List<KeyValuePair<string, string>> _fairpointQA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLStandard"),
            new KeyValuePair<string, string>("Database", "VisionblueUK_Fairpoint_QA"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "insolvqa"),
               new KeyValuePair<string, string>("Password", "B3lFa$t"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")

        };
            return _fairpointQA;
        }

        public static List<KeyValuePair<string, string>> CustomQA()
        {
            List<KeyValuePair<string, string>> _customQA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLStandard"),
            new KeyValuePair<string, string>("Database", "VisionblueUK_Custom_QA"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "insolvqa"),
               new KeyValuePair<string, string>("Password", "B3lFa$t"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")

        };
            return _customQA;
        }

        public static List<KeyValuePair<string, string>> StepchangeQA()
        {
            List<KeyValuePair<string, string>> _stepchangeQA = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLStandard"),
            new KeyValuePair<string, string>("Database", "VisionblueUK_Stepchange_QA"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "insolvqa"),
               new KeyValuePair<string, string>("Password", "B3lFa$t"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")

        };
            return _stepchangeQA;
        }

        public static List<KeyValuePair<string, string>> Aperture()
        {
             List<KeyValuePair<string, string>> _aperture = new List<KeyValuePair<string, string>>()
        {
        new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLServer14"),
            new KeyValuePair<string, string>("Database", "VisionblueUK_Aperture"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "InsolvUK"),
               new KeyValuePair<string, string>("Password", "Y?4£2Wb"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")
        };
             return _aperture;
        }

        public static List<KeyValuePair<string, string>> InternalTraining()
        {
            List<KeyValuePair<string, string>> _internalTraining = new List<KeyValuePair<string, string>>()
        {
        new KeyValuePair<string, string>("HostName", @"172.21.0.146\SQLStandard"),
            new KeyValuePair<string, string>("Database", "VisionblueUK_Internal_Training"),
             new KeyValuePair<string, string>("DriverName", "DevartSQLServer"),
              new KeyValuePair<string, string>("User_Name", "InsolvUK"),
               new KeyValuePair<string, string>("Password", "Y?4£2Wb"),
               new KeyValuePair<string, string>("OS Authentication", "False"),
               new KeyValuePair<string, string>("UseUnicode", "False")
        };
            return _internalTraining;
        }


    }
}
