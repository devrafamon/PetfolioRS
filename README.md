📋 Documentação do Repositório PetfolioRS
O que é
PetfolioRS é uma API REST desenvolvida em C# como projeto educacional durante um curso focado em boas práticas de desenvolvimento. A aplicação implementa operações CRUD (Create, Read, Update, Delete) para gerenciamento de pets, seguindo os princípios SOLID para organização e arquitetura de código.

Stack
Linguagem: C# (.NET 10.0)
Framework: ASP.NET Core Web API
Bibliotecas notáveis: Swagger/Swashbuckle para documentação de API, Microsoft.AspNetCore.OpenApi
Como está organizado
Code
Petfolio/                       Camada de apresentação (API)
  Controllers/                  Endpoints HTTP (PetController)
  Program.cs                    Configuração da aplicação
  appsettings.json              Configurações

Petfolio.Application/           Camada de lógica de negócio
  UseCases/Pets/                Implementação dos casos de uso
    Register/                   Registrar novo pet
    Update/                     Atualizar pet
    GetAll/                     Listar todos os pets
    GetById/                    Obter pet por ID
    Delete/                     Deletar pet

Petfolio.Communication/         Camada de comunicação (DTOs)
  Requests/                     Modelos de requisição
    RequestPetJSON.cs           Dados de entrada para operações
  Responses/                    Modelos de resposta
    ResponseRegisteredPetJSON   Resposta de registro
    ResponseAllPetJSON          Resposta de listagem
    ResponseErrorJSON           Resposta de erro
  Enums/                        Enumerações
    PetTypeEnum.cs              Tipos de pets disponíveis
Fluxo de requisição: As requisições HTTP chegam aos endpoints do PetController, que delegam a lógica de negócio aos casos de uso (UseCases) na camada Application. Estes casos utilizam os DTOs definidos em Communication para validar e estruturar dados de entrada e saída, respeitando a separação de responsabilidades.

Como executar
A aplicação usa ASP.NET Core com Swagger para documentação interativa:

bash
# Restaurar dependências e compilar
dotnet build

# Executar a aplicação
dotnet run --project Petfolio/Petfolio.API.csproj

# A API estará disponível em https://localhost:5171
# Swagger UI em https://localhost:5171/swagger/index.html
Portas padrão: O servidor executa na porta 5171 (confira appsettings.json para detalhes).
