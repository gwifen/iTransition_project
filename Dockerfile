FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"

COPY *.csproj ./
RUN dotnet restore
COPY . ./

RUN dotnet publish project.csproj -c Release -o out
RUN dotnet ef migrations bundle --project project.csproj --self-contained -r linux-x64 -o out/efbundle

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/out .

RUN chmod +x ./efbundle

ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "project.dll"]