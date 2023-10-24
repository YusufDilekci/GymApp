using GymApp.DataAccess.Abstract;
using GymApp.Models;

namespace GymApp.DataAccess.Concrete.InMemory
{
    public class FakeTrainerRepository : ITrainerRepository
    {
        private IQueryable<Trainer> _trainers;
        public IQueryable<Trainer> Trainers => _trainers;

        public FakeTrainerRepository() 
        {
            _trainers = new List<Trainer>() 
            {
                new Trainer() {TrainerId=1, CategoryId=1, FirstName="Yusuf", LastName="Dilekci", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer1.jpg"},
                new Trainer() {TrainerId=2, CategoryId=1, FirstName="Sadik", LastName="Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer2.jpg"},
                new Trainer() {TrainerId=3, CategoryId=2, FirstName="Birol", LastName="Sahin", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer3.jpg"},
                new Trainer() {TrainerId=4, CategoryId=2, FirstName="Azat", LastName="Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer4.jpg"},
                new Trainer() {TrainerId=5, CategoryId=3, FirstName="Mert", LastName="Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer5.jpg"},
                new Trainer() {TrainerId=6, CategoryId=4, FirstName="Fatih", LastName="Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer6.jpg"},
                new Trainer() {TrainerId=7, CategoryId=5, FirstName="James", LastName="Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer7.jpg"},

            }.AsQueryable();
        }
        public void Add(Trainer trainer)
        {
            _trainers.ToList().Add(trainer);    
        }
    }
}
