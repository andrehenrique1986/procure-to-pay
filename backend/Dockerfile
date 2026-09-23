FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /backend


# Copia os arquivos de projeto e restaura dependências
COPY ["backend/ProcureToPayAPI/ProcureToPay.API/ProcureToPay.API.csproj", "ProcureToPay/ProcureToPay.API"]
COPY ["backend/Infra/Data/ProcureToPay.Infra.Data/ProcureToPay.Infra.Data.csproj", "Infra.Data/ProcureToPay.Infra.Data"]
COPY ["backend/Infra/CrossCutting/ProcureToPay.Infra.CrossCutting/ProcureToPay.Infra.CrossCutting.csproj", "Infra.CrossCutting/ProcureToPay.Infra.CrossCutting"]
COPY ["backend/Domain/ProcureToPay.Domain/ProcureToPay.Domain.csproj", "ProcureToPay/ProcureToPay.Domain"]
COPY ["backend/Application/ProcureToPay.Application/ProcureToPay.Application.csproj", "ProcureToPay/ProcureToPay.Application"]

RUN dotnet restore "ProcureToPayAPI/ProcureToPay.API/ProcureToPay.API.csproj"

# Copia todo o código e compila
COPY . .
WORKDIR "/src/src/WebAPI/ProcureToPay.WebAPI"
RUN dotnet publish "ProcureToPay.API.csproj" -c Release -o /app/publish

# Imagem final de execução
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "ProcureToPay.API.dll"]