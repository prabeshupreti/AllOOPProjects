
namespace OverrideByConfiguration
{
    public class Traditional
    {
        public virtual void Settings(Configuration configuration) 
        {
            Console.WriteLine($"Resolution: {configuration.Resolution}");
            Console.WriteLine($"Description: {configuration.Description}");
            Console.WriteLine($"Quality: {configuration.Quality}");
            Console.WriteLine($"Quality Type: {configuration.QualityType}");

        }
    }
}
