# Exemplo de Federação GraphQL com .NET e Apollo Router

Este projeto demonstra uma arquitetura federada usando:

- ✅ **Apollo Router** como gateway federado
- ✅ **GraphQL.NET** (em C# / .NET 8) como subgraph
- ✅ Composição de schema via arquivo SDL (`schema.graphql`)
- ✅ Integração com `rover` CLI da Apollo

---

## 🧱 Estrutura

- `subgraph-users/`: Subgraph em C# usando GraphQL.NET
- `gateway/`: Configuração do Apollo Router
- `schema.graphql`: Schema SDL exportado manualmente do subgraph

---

## 🚀 Como executar

### 1. Gere o schema federado do subgraph (ou use o fornecido)
```bash
dotnet run --project subgraph-users
