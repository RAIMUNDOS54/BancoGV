# Banco GV

# Requisitos

* Docker

## Windows 
.\bancogv.bat

## Linux
.\bancogv.sh

## URL para teste público na Azure

### 1. Autenticar

{
  "userName": "user",
  "password": "user"
}
 
http://168.138.149.235:8086/api/auth

### 2. Saldo Consolidado Diário

http://168.138.149.235:8086/api/extrato/consolidado/titular/1/2023-04-01

## URL para teste público em servidor on-premise na Oracle Cloud
https://bancogv.azurewebsites.net/


### 1. Autenticar

{
  "userName": "user",
  "password": "user"
}
 
https://bancogv.azurewebsites.net/api/auth

### 2. Saldo Consolidado Diário

https://bancogv.azurewebsites.net/api/extrato/consolidado/titular/1/2023-04-01

## Coleção PostMan
#### Consultar para CRUD e outras operações

https://forreste.postman.co/workspace/Team-Workspace~0acc090f-d078-430b-8ee6-1c02fe0fdc4d/collection/15045359-01695b7e-d6c8-4bee-958d-0c8abeafbcbd?action=share&creator=15045359
