FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MyFirstCoreApplication/MyFirstCoreApplication.csproj", "MyFirstCoreApplication/"]
COPY ["MyFirstCoreLibrary/MyFirstCoreLibrary.csproj", "MyFirstCoreLibrary/"]
RUN dotnet restore "MyFirstCoreApplication/MyFirstCoreApplication.csproj"
COPY . .
WORKDIR "/src/MyFirstCoreApplication"
RUN dotnet build "MyFirstCoreApplication.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyFirstCoreApplication.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyFirstCoreApplication.dll"]