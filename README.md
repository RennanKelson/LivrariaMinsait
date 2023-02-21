# Livraria Minsait

Este projeto foi desenvolvido como parte de um desafio proposto pela empresa Minsait. O objetivo era criar um sistema de gerenciamento de livros que atendesse aos requisitos de negócio de uma livraria, utilizando o conhecimento adquirido no treinamento de .Net/Angular.
O sistema apresenta uma funcionalidade de CRUD (Create, Read, Update e Delete), permitindo que o usuário cadastre novos livros, atualize informações de livros já cadastrados, exclua livros do estoque e busque por livros. 

O projeto foi desenvolvido utilizando a arquitetura cliente-servidor, com a parte de frontend construída em Angular e a parte de backend em .NET. Além disso, para a implementação deste sistema de gerenciamento de livros, foi necessário criar um banco de dados para armazenar as informações dos livros. Para isso, foi utilizado o PostgreSQL. Foi necessário também a validação de entrada e checagem de integridade de dados.

### 📋 Pré-requisitos

Para executar este projeto em sua máquina, é necessário instalar o .Net, o Visual Studio e o Visual Studio Code, além do Node.js para o Angular e o Git. Também será necessário ter o PostgreSQL instalado para fazer a conexão com o banco de dados.

## 🚀 Começando

A seguir, seguem os passos para a execução do projeto:

Passo 1: Clone este repositório utilizando o comando git clone.

Passo 2: Abra o terminal de sua preferência e execute o comando "npm i" para instalar os pacotes necessários para o projeto clonado.

Passo 3: Após a instalação, digite "ng serve" no terminal para executar o frontend em seu navegador padrão.

Passo 4: Abra o Visual Studio e no arquivo "Program", faça a conexão com o banco de dados.

```
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<LivroContext>(options =>
options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=livraria-minsait-db;User Id=postgres;Password=1234;"));
```

Passo 5: Compile o projeto e inicie a execução.

Passo 6: Com o frontend e o backend em execução, será possível utilizar as funcionalidades desenvolvidas.

Com esses passos, você estará apto a executar o sistema de gerenciamento de livros em sua própria máquina e explorar todas as funcionalidades implementadas.
Dependendo do ambiente de desenvolvimento e das configurações do seu computador, pode ser necessário realizar algumas etapas adicionais para a correta configuração do ambiente e execução do projeto.

## 📌 Por fim

Em conclusão, o sistema de gerenciamento de livros desenvolvido para atender aos requisitos do desafio proposto é uma solução bastante intuitiva e prática para o gerenciamento de estoques de livros. Com uma interface intuitiva e botões autoexplicativos, o sistema permite o cadastro, atualização e exclusão de livros de forma fácil e rápida, além de permitir ao usuário a visualização dos livros cadastrados.
