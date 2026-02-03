# 📒 Agenda de Contatos (.NET Console + PostgreSQL)

Aplicação de console desenvolvida em **C# (.NET)** para gerenciamento de contatos, utilizando **Entity Framework Core** e **PostgreSQL** para persistência de dados.

Projeto criado com foco em **boas práticas**, **arquitetura em camadas** e **padrão Repository**, voltado para portfólio de **Back-end Júnior**.

---

## 🚀 Funcionalidades

- Adicionar contatos  
- Listar contatos cadastrados  
- Buscar contato pelo nome  
- Remover contatos  
- Persistência em banco de dados PostgreSQL  
- Menu interativo no console  

---

## 🧱 Arquitetura do Projeto

Organização baseada em camadas:

Menu (UI)
↓
AgendaService (Regra de negócio)
↓
ContatoRepository (Acesso a dados)
↓
AgendaContext (Entity Framework)
↓
PostgreSQL (Banco de Dados)


---

### Responsabilidades

### 🖥 Menu (UI)
- Interação com o usuário  
- Entrada de dados  
- Navegação do sistema  

### ⚙ AgendaService
- Regras de negócio  
- Validações  
- Comunicação entre Menu e Repository  

### 🗄 ContatoRepository
- Persistência dos dados  
- Operações no banco (CRUD)  
- Comunicação com o DbContext  

### 📦 Models (Contato)
- Representação da entidade de domínio  

### 🛢 AgendaContext
- Contexto do Entity Framework  
- Configuração da conexão com PostgreSQL  

---

## 🛠 Tecnologias Utilizadas

- C#  
- .NET Console Application  
- Entity Framework Core  
- PostgreSQL  
- Npgsql Provider  
- Programação Orientada a Objetos  
- Repository Pattern  
- Injeção de Dependência (manual)  

---

## 🗄 Banco de Dados

### Banco utilizado

- PostgreSQL  

---

### Tabela criada automaticamente via Migration

Tabela:


Campos:

- Id  
- Nome  
- Telefone  
- Email  

---

## ⚙ Configuração do Banco

No arquivo:


Configure sua connection string:

```csharp
options.UseNpgsql(
    "Host=localhost;Port=5432;Database=agenda_db;Username=postgres;Password=SUA_SENHA"
);

▶ Como Executar o Projeto

Pré-requisitos

.NET SDK

PostgreSQL instalado

pgAdmin (opcional para visualizar dados)

Download .NET:

https://dotnet.microsoft.com/download

Download PostgreSQL:

https://www.postgresql.org/download/

1️⃣ Clone o repositório

git clone https://github.com/seu-usuario/nome-do-repositorio.git

2️⃣ Entre na pasta

cd nome-do-repositorio

3️⃣ Instale os pacotes (se necessário)

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

4️⃣ Execute as migrations

dotnet ef database update

5️⃣ Rode o projeto

dotnet run

📸 Demonstração (Console)
Menu principal:

=== Agenda de Contatos ===

1. Adicionar Contato
2. Listar Contatos
3. Buscar Contato
4. Remover Contato
5. Sair

📚 Conceitos Aplicados

*Arquitetura em camadas

*Separação de responsabilidades

*Padrão Repository

*Entity Framework Core

*Migrations

*Persistência em banco relacional

*Injeção de dependência via construtor

*Boas práticas de organização


Desenvolvido por Leonardo Augusto
Estudante de Back-end .NET com foco em C#, Entity Framework e desenvolvimento de software.
