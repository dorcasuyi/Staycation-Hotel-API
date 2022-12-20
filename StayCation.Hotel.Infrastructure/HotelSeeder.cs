using Newtonsoft.Json;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Infrastructure
{
    public static class HotelSeeder
    {
        public static void SeedData(HotelDbContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

            dbContext.Database.EnsureCreated();
            var filePath = Path.Combine(baseDir, "Data/Hotel.json");
            if (!dbContext.Category.Any())
            {
                var path =  File.ReadAllText(filePath);
                var hbaUsers = JsonConvert.DeserializeObject<List<Hotels>>(path);
                dbContext.Hotels.AddRange(hbaUsers);
               dbContext.SaveChanges();
            }
         
        }
        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }
}
