📒 Agenda de Contatos - Console App (.NET)

Aplicação de console desenvolvida em C# (.NET) para gerenciamento de contatos, aplicando conceitos de organização em camadas, separação de responsabilidades e padrão Repository.

Este projeto foi criado com foco em aprendizado prático e construção de portfólio para vagas Back-end Júnior.

🚀 Funcionalidades

✅ Adicionar contato

✅ Listar contatos cadastrados

✅ Buscar contato pelo nome

✅ Validações básicas de entrada

✅ Menu interativo no console

🧱 Arquitetura do Projeto

O projeto foi organizado seguindo uma estrutura simples e limpa:

Menu (UI)
  ↓
AgendaService (Regra de negócio)
  ↓
ContatoRepository (Acesso e gerenciamento da lista)

Responsabilidades:

Menu

Interface com o usuário

Entrada de dados e navegação

AgendaService

Lógica da aplicação

Comunicação entre Menu e Repository

ContatoRepository

Armazenamento e manipulação dos dados

Operações de lista, busca e inserção

Contato (Model)

Representa a entidade Contato

🛠 Tecnologias Utilizadas

C#

.NET Console Application

Programação Orientada a Objetos (POO)

List<T>

Injeção de Dependência Manual

Repository Pattern (conceito)

▶ Como Executar o Projeto
Pré-requisitos:

.NET SDK instalado
👉 https://dotnet.microsoft.com/download

Passos:

Clone o repositório:

git clone https://github.com/seu-usuario/nome-do-repositorio.git


Entre na pasta do projeto:

cd nome-do-repositorio


Execute:

dotnet run

📸 Demonstração (Console)

Exemplo do menu:

=== Agenda de Contatos ===
1. Adicionar Contato
2. Listar Contatos
3. Buscar Contato
4. Sair

📚 Conceitos Aplicados

Separação de camadas

Encapsulamento

Injeção de dependência via construtor

Boas práticas de organização de código

Reutilização de classes

Responsabilidade única (SRP)

📈 Próximas Melhorias (Roadmap)

🔹 Persistência em arquivo ou banco de dados

🔹 Atualizar contato

🔹 Remover contato

🔹 Validação de email e telefone

🔹 Interface gráfica ou API REST

👨‍💻 Autor

Projeto desenvolvido por [Seu Nome]
Estudante de Back-end .NET focado em desenvolvimento C# e boas práticas.

⭐ Observação

Este projeto faz parte do meu processo de aprendizado e evolução profissional na área de desenvolvimento de software.
