<div align="center">

<!-- Banner -->
<img src="Github - Assets/banner.png" alt="Sistema Locadora Banner" width="100%"/>

<br/>
<br/>

<!-- Badges -->
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white)
![Windows Forms](https://img.shields.io/badge/WinForms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Status](https://img.shields.io/badge/Status-Concluído-brightgreen?style=for-the-badge)

<br/>

# 🎬 Sistema Locadora

> Trabalho prático da disciplina de **Banco de Dados I** — sistema desktop para gerenciamento de uma locadora de filmes, com interface gráfica e integração com banco de dados PostgreSQL.

</div>

---

## 📋 Sobre o Projeto

Este sistema foi desenvolvido como trabalho avaliativo da matéria de **Banco de Dados I**, com o objetivo de colocar em prática os conceitos de manipulação de dados em banco de dados relacional através de uma aplicação real.

O sistema utiliza o banco de dados **loc004** (banco da locadora) e permite gerenciar filmes, fitas e locações de forma simples e intuitiva.

---

## ✨ Funcionalidades

- 🎬 **Filmes** — Incluir, alterar e excluir filmes do catálogo
- 📼 **Fitas** — Incluir fitas e alterar a situação (Disponível / Locada)
- 🧾 **Locações** — Realizar locações com verificação automática de disponibilidade
- 🔍 **Busca de clientes** — Busca em tempo real pelo nome do cliente
- 📊 **Listagem** — Visualização dos dados em grade com filtros

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Descrição |
|---|---|
| `C#` | Linguagem principal do projeto |
| `.NET 8.0` | Framework da aplicação |
| `Windows Forms` | Interface gráfica desktop |
| `PostgreSQL` | Banco de dados relacional |
| `Npgsql` | Driver de conexão C# → PostgreSQL |
| `pgAdmin 4` | Gerenciamento do banco de dados |

---

## 📁 Estrutura do Projeto

```
SistemaLocadora/
│
├── 📄 ConexaoDB.cs          # Classe de conexão com o PostgreSQL
│
├── 📄 FilmeDAO.cs           # CRUD de filmes (SQL)
├── 📄 FitaDAO.cs            # Inclusão e alteração de fitas (SQL)
├── 📄 LocacaoDAO.cs         # Realização de locações (SQL)
│
├── 🖥️ Form1.cs              # Tela principal / Menu
├── 🖥️ FormFilme.cs          # Tela de gerenciamento de filmes
├── 🖥️ FormFita.cs           # Tela de gerenciamento de fitas
└── 🖥️ FormLocacao.cs        # Tela de locações
```

---

## 🗄️ Banco de Dados

O projeto utiliza o banco **loc004** com as seguintes tabelas:

```
loc004/
├── filme       (cod_filme, nom_filme, cod_cor, cod_genero)
├── fita        (cod_fita, cod_filme, sit_fita, dat_aquisicao)
├── locacao     (cod_locacao, cod_cliente, cod_fita, dat_locacao, dat_prevista_devolucao, dat_devolucao, val_locacao)
├── cliente     (cod_cliente, nom_cliente, rua_cliente, bai_cliente, cid_cliente, uf_cliente, cod_cliente_titular, sit_cliente)
├── genero      (cod_genero, nom_genero)
├── cor         (cod_cor, nom_cor, val_fita)
└── dominio     (cod_dominio, val_dominio, dsc_dominio)
```

---

## 🚀 Como Rodar o Projeto

### Pré-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [PostgreSQL](https://www.postgresql.org/) + [pgAdmin 4](https://www.pgadmin.org/)
- .NET 8.0 SDK

### Passo a Passo

**1.** Clone o repositório:
```bash
git clone https://github.com/seu-usuario/SistemaLocadora.git
```

**2.** Importe o banco de dados no pgAdmin:
- Crie um banco chamado `loc004`
- Abra o Query Tool e execute o arquivo `.sql` do projeto

**3.** Configure a conexão em `ConexaoDB.cs`:
```csharp
"Host=localhost;Database=loc004;Username=postgres;Password=SUA_SENHA;"
```

**4.** Instale o pacote Npgsql via NuGet:
```
Install-Package Npgsql
```

**5.** Rode o projeto com **F5** no Visual Studio!

---

## 📚 Disciplina

| | |
|---|---|
| 📖 **Matéria** | Banco de Dados I |
| 🎓 **Tipo** | Trabalho Individual |
| 📅 **Entrega** | 25/05/2026 |
| 💯 **Valor** | 10 pontos |

---

## 👤 Autor

Feito com 💙 para a disciplina de Banco de Dados I.

---

<div align="center">
<sub>Desenvolvido em C# com Windows Forms e PostgreSQL</sub>
</div>
