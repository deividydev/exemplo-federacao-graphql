
# Exemplo de Federação GraphQL com .NET 8 e Apollo Router

Este projeto demonstra uma arquitetura **GraphQL federada** com foco em boas práticas modernas utilizando:

-  **.NET 8** com [GraphQL.NET](https://github.com/graphql-dotnet/graphql-dotnet)
-  **Apollo Router** como gateway federado
-  Subgraphs separados por domínio (`users`, `products`)
-  Composição de supergraph com o [Rover CLI](https://www.apollographql.com/docs/rover/)
-  Ambiente isolado com **Docker Compose**

---

## Estrutura do Projeto

```
/
├── SubgraphProducts/        # Subgraph responsável por produtos (porta 5000)
├── SubgraphUsers/           # Subgraph responsável por usuários (porta 5001)
├── Supergraph/              # Configuração do Apollo Router
│   ├── supergraph.graphql   # Supergraph gerado via Rover CLI
│   ├── supergraph-config.yaml
│   └── router-config.yaml
├── docker-compose.yaml      # Orquestração dos serviços
└── README.md
```

---

## Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Rover CLI](https://www.apollographql.com/docs/rover/quickstart/)

---

## Como Executar o Projeto

### 1. Execute os Subgraphs e o Router

```bash
docker compose up -d --build
```

Isso iniciará:

- `SubgraphProducts` em `http://localhost:5000/graphql`
- `SubgraphUsers` em `http://localhost:5001/graphql`
- `Apollo Router` em `http://localhost:4000/`

---

## Testando

Exemplo de query no Apollo Router:

```bash
curl -X POST http://localhost:4000/   -H "Content-Type: application/json"   -d '{"query":"{ productById(id: 1) { id name } }"}'
```

---

## Boas Práticas Adotadas

- Cada subgraph expõe um schema GraphQL federado com diretiva `@key`
- Containers escutam em `0.0.0.0` para compatibilidade com Docker
- `localhost` substituído por `products` e `users` via rede interna Docker
- Supergraph regenerado sempre que houver alteração de schema
- SDLs exportadas manualmente para versionamento claro

---

## Links úteis

- [Apollo Federation](https://www.apollographql.com/docs/federation/)
- [GraphQL.NET](https://graphql-dotnet.github.io/)
- [Apollo Router](https://www.apollographql.com/router)

## Autor

Desenvolvido por Deividy Henrique Alves Pinheiro.
