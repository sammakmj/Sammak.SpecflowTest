using System.Configuration;

namespace Sammak.SpecflowTest.Common
{
    class Utils
    {
        public static string Test_EnrollmentId = ConfigurationManager.AppSettings["Test_EnrollmentId"];
        public static string Test_PracticeId = ConfigurationManager.AppSettings["Test_PracticeId"];
        public static string Test_PersonId = ConfigurationManager.AppSettings["Test_PersonId"];
    }
}
