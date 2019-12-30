FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
#WorkingDirectory=/var/aspnetcore

COPY /bin/Release/netcoreapp2.2/publish /var/aspnetcore
#COPY MVaahan.XML /app
#work 
WORKDIR /var/aspnetcore
#WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT Staging
ENV AWS_ACCESS_KEY_ID AccessKey
ENV AWS_SECRET_KEY SecertKey
ENV TIME_ZONE Asia/Kolkata
ENV ASPNETCORE_URLS http://+:56884

ENTRYPOINT ["dotnet", "/var/aspnetcore/MVaahan.dll"]
