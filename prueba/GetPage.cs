using System.Collections.Generic;

namespace prueba;

public static class GetPage
{
    public static List<Usuario> Page(Users data, int startIndex, int pageSize, string propertySortBy = "id", int AscOrDesc = 0)
    {
        Users users = new();

        if (propertySortBy == "id")
        {
            if (AscOrDesc == 0)
                users.usuario = data.usuario.OrderBy(x => x.id).ToList();
            if (AscOrDesc == 1)
                users.usuario = data.usuario.OrderByDescending(x => x.id).ToList();
        }

        return users.usuario.Skip(startIndex).Take(pageSize).ToList();
    }
}
