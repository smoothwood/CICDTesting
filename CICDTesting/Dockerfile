FROM microsoft/dotnet:2.2-sdk AS build-env
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
# Expose ports
EXPOSE 80
ENV ASPNETCORE_URLS http://*:80


#ssh
EXPOSE 2222

RUN apt update \
    && apt install -y --no-install-recommends openssh-server \
    && mkdir -p /run/sshd \
    && echo "root:Docker!" | chpasswd

COPY sshd_config /etc/ssh/sshd_config

# # Set environment
ENV ASPNETCORE_ENVIRONMENT Staging
# Start
# ENTRYPOINT ["dotnet", "CICDTesting.dll"]
ENTRYPOINT ["/bin/bash", "-c", "/usr/sbin/sshd && dotnet CICDTesting.dll"]