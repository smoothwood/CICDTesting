﻿FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app
# Copy necessary files and restore
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
# Build runtime image
FROM microsoft/dotnet:2.2-aspnetcore-runtime
COPY --from=build-env /app/out .
# Set environment
# ENV ASPNETCORE_ENVIRONMENT Development
# Start
ENTRYPOINT ["dotnet", "CICDTesting.dll"]