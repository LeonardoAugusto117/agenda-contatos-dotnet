# 📒 Agenda de Contatos (.NET Console)

Aplicação de console desenvolvida em **C# (.NET)** para gerenciamento de contatos, aplicando conceitos de **arquitetura em camadas**, **separação de responsabilidades** e **padrão Repository**.

Projeto voltado para prática e portfólio de **Back-end Júnior**.

---

## 🚀 Funcionalidades

- Adicionar contatos  
- Listar contatos cadastrados  
- Buscar contato pelo nome  
- Menu interativo no console  

---

## 🧱 Estrutura do Projeto

Organização baseada em camadas:

O projeto foi organizado seguindo uma estrutura simples e limpa:

Menu (UI)
  ↓
AgendaService (Regra de negócio)
  ↓
ContatoRepository (Acesso e gerenciamento da lista)


### Responsabilidades

**Menu**
- Interação com o usuário  
- Navegação e entrada de dados  

**AgendaService**
- Lógica da aplicação  
- Comunicação entre Menu e Repository  

**ContatoRepository**
- Armazenamento e manipulação dos contatos  

**Contato (Model)**
- Representação da entidade Contato  

---

## 🛠 Tecnologias Utilizadas

- C#  
- .NET Console Application  
- Programação Orientada a Objetos  
- List<T>  
- Injeção de Dependência (manual)  
- Repository Pattern (conceito)  

---

## ▶ Como Executar

### Pré-requisitos

- .NET SDK instalado  
https://dotnet.microsoft.com/download  

---

### Passo a passo

Clone o repositório:

```bash

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

Separação de responsabilidades

Encapsulamento

Injeção de dependência via construtor

Organização em camadas

Boas práticas de código

🚧 Próximas Melhorias

Persistência em arquivo ou banco de dados

Atualizar contatos

Remover contatos

Validação de email e telefone

Versão com API REST

👨‍💻 Autor

Desenvolvido por Leonardo Augusto
Estudante de Back-end .NET focado em C# e desenvolvimento de software.




