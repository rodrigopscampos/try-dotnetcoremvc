FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .

ENV PORT = 80

#CMD ASPNETCORE_URLS=http://*:/$PORT dotnet aspnetcoremvc.dll
ENTRYPOINT ["dotnet", "aspnetcoremvc.dll", "http://*:/$PORT"]