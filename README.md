
# SentimentAnalysisMLNET - Expandido

Projeto com análise de sentimentos utilizando ML.NET e uma API ASP.NET Core para consumo via HTTP.

## Como executar

### API
```bash
cd api
dotnet run
```

### Docker
```bash
docker build -t sentiment-api .
docker run -p 8080:80 sentiment-api
```

## Requisição de exemplo
```json
POST /api/sentiment
{
  "SentimentText": "O serviço foi excelente!"
}
```

## CI/CD
A build automatizada está definida em `.github/workflows/dotnet.yml`.

## Autor
Silas Siderio
