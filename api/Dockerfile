FROM mcr.microsoft.com/dotnet/core/sdk:5.0 AS build
WORKDIR /app 

COPY *.sln .
COPY PetAdoption.Domain/*.csproj ./PetAdoption.Domain/
COPY PetAdoption.Api/*.csproj ./PetAdoption.Api/
COPY PetAdoption.Domain.Infra/*.csproj ./PetAdoption.Domain.Infra/
COPY PetAdoption.Domain.Tests/*.csproj ./PetAdoption.Domain.Tests/ 

RUN dotnet restore 

COPY PetAdoption.Domain/. ./PetAdoption.Domain/
COPY PetAdoption.Api/. ./PetAdoption.Api/
COPY PetAdoption.Domain.Infra/. ./PetAdoption.Domain.Infra/ 

WORKDIR /app/PetAdoption.Api
RUN dotnet publish -c Release -o out 

FROM mcr.microsoft.com/dotnet/core/aspnet:5.0 AS runtime
WORKDIR /app 

COPY --from=build /app/PetAdoption.Api/out ./
ENTRYPOINT ["dotnet", "PetAdoption.Api.dll"]