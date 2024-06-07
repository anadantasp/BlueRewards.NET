# BlueRewards.NET

## Escopo do produto
Leia o escopo do produto [aqui](https://github.com/anadantasp/BlueRewards.NET/blob/main/Documentacao/Escopo%20do%20Produo%20-%20BlueRewards%20.pdf)

## Passo a passo de como executar o projeto
Acesse [aqui](#) o vídeo mostrando a execução do projeto

Repositório Java: [BlueRewardsJava](https://github.com/anadantasp/BlueRewards)

## Sequência dos endpoints criado para teste

### Endpoints empresa

1. POST
    - Request(/api/Empresa)
    ```
    {
      "cnpj": "string",
      "nome": "string"
    }
    ```
    - Response
    ```
    {
      "empresaId": 1,
      "cnpj": "39165475000173",
      "nome": "Addidas"
    }

    ```

2. GET(/api/Empresa)
- Response

  ```
    [
      {
        "empresaId": 1,
        "cnpj": "39165475000173",
        "nome": "Addidas"
      },
      {
        "empresaId": 2,
        "cnpj": "10488781000169",
        "nome": "Addidas"
      },
      {
        "empresaId": 3,
        "cnpj": "10488781000169",
        "nome": "Nike"
      }
    ]

  ```
3. GET(/api/Empresa/{id})
   
   - Response

   ```
   {
     "empresaId": 3,
     "cnpj": "10488781000169",
     "nome": "Nike"
   }
   ```
4. PUT(/api/Empresa/{id})

- Request(/api/Empresa)

    ```
    {
      "cnpj": "string",
      "nome": "string"
    }
    ```
    - Response
    ```
    {
      "empresaId": 1,
      "cnpj": "39165475000173",
      "nome": "Addidas"
    }

    ```
5. Delete(/api/Empresa/{id})

### Endpoints cupom
1. POST
    - Request(/api/Cupom)
    ```
    {
      "descricao": "string",
      "codigo": "string",
      "validade": "2024-06-06T21:03:03.410Z",
      "pontuacao": 0,
      "empresaId": 0
    }
    ```
    - Response
    ```
    {
        "cupomId": 1,
        "descricao": "10% de desconto em todo site",
        "codigo": "10PVC2024",
        "validade": "2024-06-07T21:03:32.56Z",
        "pontuacao": 10,
        "empresa": {
          "empresaId": 1,
          "cnpj": "39165475000173",
          "nome": "Addidas"
        }
    }

    ```
2. GET(/api/Cupom)
- Response

  ```
    [
        {
          "cupomId": 1,
          "descricao": "10% de desconto em todo site",
          "codigo": "10PVC2024",
          "validade": "2024-06-07T21:03:32.56",
          "pontuacao": 10,
          "empresa": {
            "empresaId": 1,
            "cnpj": "39165475000173",
            "nome": "Addidas"
          }
        },
        {
          "cupomId": 3,
          "descricao": "40% de desconto em todo site",
          "codigo": "40PVC2024",
          "validade": "2024-06-07T21:03:32.56",
          "pontuacao": 40,
          "empresa": {
            "empresaId": 3,
            "cnpj": "10488781000169",
            "nome": "Nike"
          }
        },
        {
          "cupomId": 4,
          "descricao": "50% de desconto em todo site",
          "codigo": "40PVC2024",
          "validade": "2024-06-07T21:03:32.56",
          "pontuacao": 100,
          "empresa": {
            "empresaId": 3,
            "cnpj": "10488781000169",
            "nome": "Nike"
          }
        }
    ]

  ```
  3. GET(/api/Cupom/{id})
   
   - Response

   ```
   {
        "cupomId": 4,
        "descricao": "50% de desconto em todo site",
        "codigo": "40PVC2024",
        "validade": "2024-06-07T21:03:32.56",
        "pontuacao": 100,
        "empresa": {
          "empresaId": 3,
          "cnpj": "10488781000169",
          "nome": "Nike"
        }
    }
   ```

4. Delete(/api/Cupom/{id})








    


    

