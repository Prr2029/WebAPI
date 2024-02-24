using WebAPI.DatabaseContext;
using WebAPI.Model;

namespace WebAPI.Service
{
    public class LogSheetService
    {
        ProjectDbContext db = null;
        public LogSheetService(ProjectDbContext dbContext)
        {
            db = dbContext;


        }
        public LogSheetService()
        {

        }

        public bool Add(LogSheet logsheet)
        {
            db.LogSheets.Add(logsheet);
            db.SaveChanges();
            return true;
        }
    }
}
