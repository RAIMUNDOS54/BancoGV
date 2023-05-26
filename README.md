# Banco GV

# Requisitos

* Docker

## Windows 
.\bancogv.bat

## Linux
.\bancogv.sh

## URL para teste público

1. Autenticar

{
  "userName": "user",
  "password": "user"
}
 
https://168.138.149.235:8086/api/auth

2. Saldo Consolidado Diário

https://168.138.149.235:8086/api/extrato/consolidado/titular/1/2023-04-01

Consultar coleção do PostMan disponível como referência para CRUD e outras operações:

https://forreste.postman.co/workspace/Team-Workspace~0acc090f-d078-430b-8ee6-1c02fe0fdc4d/collection/15045359-01695b7e-d6c8-4bee-958d-0c8abeafbcbd?action=share&creator=15045359