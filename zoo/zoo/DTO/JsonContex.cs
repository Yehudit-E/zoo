using System.Text.Json;
using zoo.Entities;

namespace zoo.DTO
{
    public class JsonContex: IDataContex
    {
        
        public JsonContex()
        {
            
        }
        public List<Animal> LoadData()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
            string jsonString = File.ReadAllText(path);
            var AllAnimal = JsonSerializer.Deserialize<DataDB>(jsonString);

            return AllAnimal.db;
        }


        public bool SaveData(List<Animal> dataAnimal)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                DataDB data = new DataDB();
                data.db = dataAnimal;
                string jsonString = JsonSerializer.Serialize<DataDB>(data);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}



    



  

