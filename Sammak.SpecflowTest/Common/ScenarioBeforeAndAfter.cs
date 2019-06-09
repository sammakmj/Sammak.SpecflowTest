using TechTalk.SpecFlow;

namespace Sammak.SpecflowTest.Common
{
    [Binding]
    public class ScenarioBeforeAndAfter
    {

        [BeforeScenario]
        public static void Before()
        {
            // run before each scenario
        }

        [AfterScenario]
        public static void After()
        {
            // dispose stuff
        }

    }
}
