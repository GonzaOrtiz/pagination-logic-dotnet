using Newtonsoft.Json;

namespace prueba;
public static class UserService
{
    public static void ShowData()
    {
        //actualizar path
        string path = @"C:\Users\Gonza\OneDrive\Escritorio\prueba\prueba\user.json";
        StreamReader r = new StreamReader(path);
        string jsonString = r.ReadToEnd();
        var data = JsonConvert.DeserializeObject<Users>(jsonString);
        foreach (var user in data.usuario)
        {
            Console.WriteLine($"{user.nombre} - {user.apellido}");
        }
    }

    public static Users GetUsers()
    {
        string path = @"C:\Users\Gonza\OneDrive\Escritorio\prueba\prueba\user.json";
        StreamReader r = new StreamReader(path);
        string jsonString = r.ReadToEnd();
        var data = JsonConvert.DeserializeObject<Users>(jsonString);

        return data;
    }
}
