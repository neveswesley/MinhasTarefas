# 📌 Minhas Tarefas API (To-Do List)

API RESTful para gerenciamento de tarefas com **autenticação e autorização JWT**, controle de usuários e acesso seguro aos dados. Cada usuário pode acessar apenas suas próprias tarefas, garantindo privacidade e segurança.

---

## 🚀 Funcionalidades

- ✅ Cadastro e login de usuários com autenticação JWT  
- 🔐 Rotas protegidas por autorização baseada em token  
- 📋 CRUD completo de tarefas (criar, listar, editar, excluir)  
- 👤 Acesso restrito às tarefas por usuário logado  
- 🔁 Renovação de token via refresh token  
- 🧠 Validação de modelo e tratamento de erros  

---

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core Web API**
- **C#**
- **Entity Framework Core**
- **SQL Server**
- **JWT (JSON Web Tokens)**
- **Identity (controle de autenticação)**

---

## 🧱 Arquitetura

- Padrão **Repository**
- Separação por camadas: `Models`, `DTOs`, `Repositories`, `Controllers`
- **Token JWT** com geração e renovação de acesso
- **Refresh Tokens** persistidos em banco

---

## 🗂️ Endpoints principais

### 🔑 Autenticação

| Método | Endpoint               | Descrição                         |
|--------|------------------------|-----------------------------------|
| POST   | `/api/usuario/login`   | Login do usuário                  |
| POST   | `/api/usuario/renovar` | Gera novo token via refresh token |
| POST   | `/api/usuario`         | Cadastro de novo usuário          |

### ✅ Tarefas (requer autenticação)

| Método | Endpoint            | Descrição                |
|--------|---------------------|--------------------------|
| GET    | `/api/tarefa`       | Lista tarefas do usuário |
| POST   | `/api/tarefa`       | Cria nova tarefa         |
| PUT    | `/api/tarefa/{id}`  | Atualiza uma tarefa      |
| DELETE | `/api/tarefa/{id}`  | Remove uma tarefa        |

---

## 💾 Banco de Dados

- Modelagem com **Entity Framework Core**
- Relacionamento entre `ApplicationUser` e `Tarefa`
- Tabelas principais:
  - `AspNetUsers` (usuários)
  - `Tarefa`
  - `Token` (refresh tokens)

