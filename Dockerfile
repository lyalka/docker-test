FROM microsoft/dotnet:1.1-sdk
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
WORKDIR /app
RUN ["dotnet", "build"]
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "run", "--server.urls", "http://*:5000"]