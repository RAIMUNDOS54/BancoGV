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

-- 2.2. ** INSERE NATUREZA DOS TIPOS DE LAN�AMENTOS
--Soma
INSERT INTO LancamentosTipoNatureza(Nome, SimboloOperacao, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Soma', '+', GETDATE(), GETDATE(), 1, 1);

--Subtra��o
INSERT INTO LancamentosTipoNatureza(Nome, SimboloOperacao, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Subtra��o', '-', GETDATE(), GETDATE(), 1, 1);

-- 2.3. ** INSERE TIPOS DE LAN�AMENTOS
--Cr�dito
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Opera��o de Cr�dito Comum', 'Opera��o de Cr�dito Comum em Conta Corrente', 1, GETDATE(), GETDATE(), 1, 1);

--D�bito
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Opera��o de D�bito Comum', 'Opera��o de D�bito Comum em Conta Corrente', 2, GETDATE(), GETDATE(), 1, 1);

--Dep�sito de Empr�stimo
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Dep�sito de Empr�stimo', 'Dep�sito de Empr�stimo obtido com o BancoGV', 1, GETDATE(), GETDATE(), 1, 1);

--Cobran�a de Empr�stimo
INSERT INTO LancamentosTipo(Nome, Descricao, Natureza, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Cobran�a de Empr�stimo', 'Cobran�a de Empr�stimo obtido com o BancoGV', 2, GETDATE(), GETDATE(), 1, 1);

-- 2.4. ** INSERE LAN�AMENTOS
--Cabo USB-C Turbo Recharge
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Cabo USB-C Turbo Recharge', 'Cabo recarregador para celular tipo USB-C. Tecnologia Turbo Recharge.', '59.90', 2, 1, '2023-05-20', GETDATE(), GETDATE(), 1, 1);

--Celular Samsung A5 (2017) Dourado
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Celular Samsung A5 (2017) Dourado', 'Celular Samsung A5 (2017) Dourado. Acompanha capa e pel�cula 3D. Produto novo. Embalagem original.', '799.00', 2, 1, '2023-05-14', GETDATE(), GETDATE(), 1, 1);

--Notebook Lenovo 17", Monitor 240mhz, i9 11900H, 32GB, RTX 3060 12 GB, 1TB NVME 2
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Notebook Lenovo 17", Monitor 240mhz, i9 11900H, 32GB, RTX 3060 12 GB, 1TB NVME 2', 'Notebook Lenovo 17", i9 11900H, 32GB, RTX 3060 12 GB, 1TB NVME 2, Monitor 240mhz', '5999.00', 2, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Dep�sito Pessoa Jur�dica
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Dep�sito Pessoa Jur�dica', 'Dep�sito Pessoa Jur�dica - CNPJ: 12.344.385/0001-93', '16000.00', 1, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Dep�sito Pessoa F�sica
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Dep�sito Pessoa F�sica - CPF: 109.625.097-79', 'Dep�sito Pessoa F�sica - CPF: 109.625.097-79, Nome: Gabriel Henrique de Azev�do Veloso', '5000.00', 1, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--Cr�dito de Empr�stimo
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Cr�dito de Empr�stimo', 'Cr�dito de Empr�stimo com o BancoGV', '2500.00', 3, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);

--D�bito de Empr�stimo
INSERT INTO Lancamentos(Nome, Descricao, Valor, Tipo, Titular, Data, DataCriacao, DataModificacao, CriadoPor, ModificadoPor)
VALUES('Pagamento de Empr�stimo', 'Pagamento de Empr�stimo com o BancoGV', '2700.00', 4, 1, '2023-04-01', GETDATE(), GETDATE(), 1, 1);
