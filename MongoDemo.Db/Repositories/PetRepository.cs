using MongoDB.Driver;
using MongoDemo.Core.Models.Entities;
using MongoDemo.Db.Database;

namespace MongoDemo.Db.Repositories
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> GetAll();
        Task<Pet?> GetById(string id);
        Task<Pet> Create(Pet pet);
        Task<Pet> Update(string id, Pet pet);
    }

    public class PetRepository(MongoContext context) : IPetRepository
    {
        public async Task<Pet> Create(Pet pet)
        {
            await context.Pets.InsertOneAsync(pet);
            return pet;
        }

        public async Task<IEnumerable<Pet>> GetAll()
        {
            return await context.Pets.Find(item => true).ToListAsync();
        }

        public async Task<Pet?> GetById(string id)
        {
            return await context.Pets.Find(item => item.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Pet> Update(string id, Pet pet)
        {
            var filter = Builders<Pet>.Filter.Eq(p => p.Id, id);
            var update = Builders<Pet>.Update
                .Set(p => p.Animal, pet.Animal)
                .Set(p => p.Color, pet.Color);

            var options = new FindOneAndUpdateOptions<Pet>
            {
                ReturnDocument = ReturnDocument.After // Return the updated document };
            };
           return await context.Pets.FindOneAndUpdateAsync(filter, update, options);
        }
    }
}
