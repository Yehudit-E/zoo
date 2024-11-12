using zoo.Entities;

namespace zoo.DTO
{
    public interface IDataContex
    {
        public List<Animal> LoadData();
        public bool SaveData(List<Animal> coins);
    }
}
