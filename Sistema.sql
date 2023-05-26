--- *** 1. LIMPA BANCO DE DADOS
--TRUNCATE Lancamentos;
DELETE FROM Lancamentos;
DBCC CHECKIDENT ('Lancamentos', 'RESEED', 0);
--TRUNCATE TABLE LancamentosTipo;
DELETE FROM LancamentosTipo;
DBCC CHECKIDENT ('LancamentosTipo', 'RESEED', 0);
--TRUNCATE TABLE LancamentosTipoNatureza;
DELETE FROM LancamentosTipoNatureza;
DBCC CHECKIDENT ('LancamentosTipoNatureza', 'RESEED', 0);
--TRUNCATE TABLE Titulares;
DELETE FROM Titulares;
DBCC CHECKIDENT ('Titulares', 'RESEED', 0);
--TRUNCATE TABLE Operadores;
DELETE FROM Operadores;
DBCC CHECKIDENT ('Operadores', 'RESEED', 0);

--- *** 2. INSERE OPERADORES

--BancoGV
INSERT INTO Operadores(Nome, Sobrenome, Usuario, Email, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('BancoGV', 'Sistema', 'bancogv','bancogv@bancogv.com.br', GETDATE(), GETDATE(), NULL, NULL);

UPDATE Operadores SET CriadoPor = 1, ModificadoPor = 1 WHERE ID = 1;

--Gabriel Veloso
INSERT INTO Operadores(Nome, Sobrenome, Usuario, Email, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Gabriel', 'Veloso', 'gabriel.veloso','gabriel.veloso@bancogv.com.br', GETDATE(), GETDATE(), 1, 1);

-- 2.1. ** INSERE TITULARES

-- Gabriel Veloso
INSERT INTO Titulares(Nome, Sobrenome, CPFCNPJ, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Gabriel', 'Veloso', '10962509779', GETDATE(), GETDATE(), 1, 1);

-- 2.2. ** INSERE NATUREZA DOS TIPOS DE LANÇAMENTOS
--Soma
INSERT INTO LancamentosTipoNatureza(Nome, SimboloOperacao, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Soma', '+', GETDATE(), GETDATE(), 1, 1);

--Subtração
INSERT INTO LancamentosTipoNatureza(Nome, SimboloOperacao, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Subtração', '-', GETDATE(), GETDATE(), 1, 1);

-- 2.3. ** INSERE TIPOS DE LANÇAMENTOS
--Crédito
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Operação de Crédito Comum', 'Operação de Crédito Comum em Conta Corrente', 1, GETDATE(), GETDATE(), 1, 1);

--Débito
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Operação de Débito Comum', 'Operação de Débito Comum em Conta Corrente', 2, GETDATE(), GETDATE(), 1, 1);

--Depósito de Empréstimo
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Depósito de Empréstimo', 'Depósito de Empréstimo obtido com o BancoGV', 1, GETDATE(), GETDATE(), 1, 1);

--Cobrança de Empréstimo
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Cobrança de Empréstimo', 'Cobrança de Empréstimo obtido com o BancoGV', 2, GETDATE(), GETDATE(), 1, 1);

-- 2.4. ** INSERE LANÇAMENTOS
--Cabo USB-C Turbo Recharge
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Cabo USB-C Turbo Recharge', 'Cabo recarregador para celular tipo USB-C. Tecnologia Turbo Recharge.', '59.90', 2, 1, '2023-05-20', GETDATE(), GETDATE(), 1, 1);

--Celular Samsung A5 (2017) Dourado
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Celular Samsung A5 (2017) Dourado', 'Celular Samsung A5 (2017) Dourado. Acompanha capa e película 3D. Produto novo. Embalagem original.', '799.00', 2, 1, '2023-05-14', GETDATE(), GETDATE(), 1, 1);

--Notebook Lenovo 17", Monitor 240mhz, i9 11900H, 32GB, RTX 3060 12 GB, 1TB NVME 2
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Notebook Lenovo 17", Monitor 240mhz, i9 11900H, 32GB, RTX 3060 12 GB, 1TB NVME 2', 'Notebook Lenovo 17", i9 11900H, 32GB, RTX 3060 12 GB, 1TB NVME 2, Monitor 240mhz', '5999.00', 2, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Depósito Pessoa Jurídica
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Depósito Pessoa Jurídica', 'Depósito Pessoa Jurídica - CNPJ: 12.344.385/0001-93', '16000.00', 1, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Depósito Pessoa Física
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Depósito Pessoa Física - CPF: 109.625.097-79', 'Depósito Pessoa Física - CPF: 109.625.097-79, Nome: Gabriel Henrique de Azevêdo Veloso', '5000.00', 1, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Crédito de Empréstimo
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Crédito de Empréstimo', 'Crédito de Empréstimo com o BancoGV', '2500.00', 3, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Débito de Empréstimo
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Pagamento de Empréstimo', 'Pagamento de Empréstimo com o BancoGV', '2700.00', 4, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);
