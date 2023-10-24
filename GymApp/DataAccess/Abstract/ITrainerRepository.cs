using GymApp.Models;

namespace GymApp.DataAccess.Abstract
{
    public interface ITrainerRepository
    {
        IQueryable<Trainer> Trainers { get; }
        void Add(Trainer trainer);
    }
}
