namespace PhotoBlog.Models
{
    public static class PhotoBlogSeed
    {
        public static void Seed(AppDbContext db) 
        {
            if (db.Photos.Any() || db.Tags.Any()) return;


            // Tags
            var yol = new Tag() { Name = "yol" };
            var su = new Tag() { Name = "su" };
            var ev = new Tag() { Name = "ev" };
            var agac = new Tag() { Name = "ağaç" };
            var gunes = new Tag() { Name = "günes" };
            var sehir = new Tag() { Name = "şehir" };


            var tags = new Tag[]{ yol, su, ev, agac, gunes, sehir };

            foreach (var tag in tags)
            {
                db.Tags.Add(tag);
                db.SaveChanges();
            }

            // Photos

            var photos = new Photo[]
            {
                new Photo()
                {
                    Title="Photo 1",
                    Description="Photo 1 Description",
                    PhotoName="1", 
                    Tags= new List<Tag>(){ yol, su, ev, gunes } 
                },

                new Photo()
                {
                    Title="Photo 2",
                    Description="Photo 2 Description",
                    PhotoName="2",
                    Tags= new List<Tag>(){ yol, su, agac, sehir}
                },

                new Photo()
                {
                    Title="Photo 3",
                    Description="Photo 3 Description",
                    PhotoName="3",
                    Tags= new List<Tag>(){ agac, su, ev }
                },
            };

            foreach (var photo in photos)
            {
                db.Photos.Add(photo);
                db.SaveChanges();
            }
        }
    }
}
