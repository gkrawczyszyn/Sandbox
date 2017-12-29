FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY Sandbox.ConsoleApp/*.csproj ./Sandbox.ConsoleApp/
COPY Sandbox.BusinessLogic/*.csproj ./Sandbox.BusinessLogic/
RUN dotnet restore Sandbox.ConsoleApp/Sandbox.ConsoleApp.csproj

# copy everything else and build
COPY . ./
RUN dotnet publish Sandbox.ConsoleApp/Sandbox.ConsoleApp.csproj -c Release -o out

# build runtime image
FROM microsoft/dotnet:2.0.4-runtime 
WORKDIR /app
COPY --from=build-env /app/Sandbox.ConsoleApp/out ./
ENTRYPOINT ["dotnet", "Sandbox.ConsoleApp.dll"]