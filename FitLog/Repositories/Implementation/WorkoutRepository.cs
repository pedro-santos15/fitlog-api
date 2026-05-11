using FitLog.Model;
using FitLog.Model.Context;

namespace FitLog.Repositories.Implementation
{
    public class WorkoutRepository : RepositoryBase<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(AppDbContext context) : base(context)
        {
        }
    }
}
