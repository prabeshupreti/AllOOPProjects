
namespace OverrideByConfiguration
{
    public class Modern:Traditional
    {
        public override void Settings(Configuration configuration)
        {
            configuration.Resolution = "4K";

            Console.WriteLine("Modern Settings Applied:");

            base.Settings(configuration);
        }
    }
}
