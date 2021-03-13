# NetCoreApiSeed
Projeto de uma API RestFull .Net Core

# IDE's
> **Visual Studio 2019** 

# DataBase
> **PostgreSQL 13**


# Migrations (Code First)

> **O Code First é uma funcionalidade incluída na versão 4.1 do Entity Framework.
Esse novo recurso permite o mapeamento/persistência de classes POCO e geração de base de dados a partir da estrutura dessas classes**

### Classe de conexão

```
{
  "ConnectionStrings": {
    "MyWebApiConection": "User ID =postgres;Password=1234;Server=localhost;Port=5432;Database=testDb;Integrated Security=true;Pooling=true;"
  },
  "Logging": {
    "IncludeScopes": false,
    "Debug": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "Console": {
      "LogLevel": {
        "Default": "Warning"
      }
    }
  }
}
```

### Comandos

> **PM> enable-migrations** <br>
> **PM> add-migration initial** <br>
> **PM> update-database** <br>

### Para mais informações sobre como implementar o CodeFirst
> **https://medium.com/faun/asp-net-core-entity-framework-core-with-postgresql-code-first-d99b909796d7 (13/03/2021)**

