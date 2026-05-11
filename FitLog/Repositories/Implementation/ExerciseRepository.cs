using FitLog.Model;
using FitLog.Model.Context;

namespace FitLog.Repositories.Implementation
{
    public class ExerciseRepository : RepositoryBase<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
