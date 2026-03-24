# Sử dụng SDK .NET 10.0 để build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copy file csproj và restore các dependency
COPY BigProject.API/*.csproj ./BigProject.API/
RUN dotnet restore ./BigProject.API/BigProject.API.csproj

# Copy toàn bộ code và publish
COPY . .
WORKDIR /app/BigProject.API
RUN dotnet publish -c Release -o /out /p:UseAppHost=false /p:PublishReadyToRun=false --no-restore

# Sử dụng Runtime .NET 10.0 để chạy cho nhẹ
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /out .

# Cấu hình cổng 5294 như trong hình ảnh của bạn
ENV ASPNETCORE_URLS=http://+:5294
EXPOSE 5294

ENTRYPOINT ["dotnet", "BigProject.API.dll"]
