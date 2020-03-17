FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app
# Copy necessary files and restore
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
# Build runtime image
# FROM microsoft/dotnet:2.2-aspnetcore-runtime
FROM microsoft/dotnet:2.2-sdk
COPY --from=build-env /app/out .
# Expose ports
EXPOSE 80
ENV ASPNETCORE_URLS http://*:80
# Set environment
ENV ASPNETCORE_ENVIRONMENT Development
# Start
ENTRYPOINT ["dotnet", "CICDTesting.dll"]