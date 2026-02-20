## Bootcamp Deloitte 

Repositório dedicado ao desenvolvimento do Sistema de Monitoramento, projeto final do Bootcamp em C#/.NET da Deloitte.

---

### Sobre o Projeto 

O Sistema de Monitoramento é uma API REST desenvolvida em ASP.NET Core, utilizando Entity Framework Core para integração com banco de dados PostgreSQL.


A aplicação permite realizar operações de CRUD (Create, Read, Update e Delete) para gerenciamento de equipamentos, incluindo informações como código, tipo, modelo, horímetro, status operacional, data de aquisição e localização atual.


O projeto está configurado para execução com Docker, facilitando a padronização do ambiente e a execução local.

### Pré-requisitos 
Para executar o projeto localmente, é necessário instalar:

### Extensões do Visual Studio Code  
- .NET Install Tool  
- C#  
- C# Dev Kit  

### SDK do .NET  
- SDKs do .NET para Visual Studio  
- https://dotnet.microsoft.com/pt-br/download/visual-studio-sdks  

---

### Como executar o projeto  

1. Crie uma pasta em sua máquina.  
2. Abra o **Prompt de Comando (CMD)** ou **Terminal**.  
3. Navegue até a pasta criada e execute o comando abaixo para clonar o repositório:

```bash
git clone https://github.com/dayvidcristiano/sistema-de-monitoramento-bootcamp-dtt.git
```

4. Acesse a pasta do projeto em que deseja executar.

```bash
cd sistema-de-monitoramento-bootcamp-dtt
```
5. Execute os containers com Docker:
```bash
docker-compose up --build
```
6. A API estará disponível em:
```bash
http://localhost:8080
```
ou na porta configurada no docker-compose.yml

---

<p align="center"> © 2026 Dayvid Cristiano </p>
