namespace WebAPI.Service
{
    public class LogsheetService
    {
        ProjectDbContext db = null;
        public LogsheetService(ProjectDbContext dbContext)
        {
            db = dbContext;


        }
        public LogsheetService()
        {

        }
        public bool Add(LogSheet log)
        {
            db.Add(log);
            db.SaveChanges();
            return true;

        }


    }
}
