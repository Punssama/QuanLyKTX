# THÌ 1: BUILD (Sử dụng SDK 10.0 để biên dịch)
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Bước quan trọng: Copy tất cả file dự án (.csproj) để restore trước
# Việc này giúp sửa lỗi NETSDK1004 bạn vừa gặp
COPY BigProject.API/*.csproj ./BigProject.API/
COPY KTX.Shared/*.csproj ./KTX.Shared/

# Restore các thư viện NuGet (Docker sẽ cache bước này để build nhanh hơn lần sau)
RUN dotnet restore ./BigProject.API/BigProject.API.csproj

# Bây giờ mới copy toàn bộ mã nguồn vào
COPY . .

# Chuyển vào thư mục API để thực hiện Publish
WORKDIR /app/BigProject.API
RUN dotnet publish -c Release -o /out --no-restore /p:UseAppHost=false

# THÌ 2: RUNTIME (Sử dụng bản nhẹ chỉ để chạy app, tiết kiệm RAM cho VPS)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

# Copy kết quả đã build từ bước trên sang
COPY --from=build /out .

# Mở port cho API (đúng với port bạn hay dùng)
EXPOSE 5294
ENV ASPNETCORE_URLS=http://+:5294

# Lệnh chạy ứng dụng
ENTRYPOINT ["dotnet", "BigProject.API.dll"]
