#FROM microsoft/mssql-server-linux:latest

# Default SQL Server TCP/Port.
#EXPOSE 1433

#ENV MSSQL_PID=Express
# docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -e 'MSSQL_PID=Express' -p 1433:1433 -d microsoft/mssql-server-linux:latest

FROM mysql
ENV MYSQL_ROOT_PASSWORD=root
#docker run --name some-mysql -e MYSQL_ROOT_PASSWORD=my-secret-pw -d mysql:tag
