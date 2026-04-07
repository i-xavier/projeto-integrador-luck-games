CREATE DATABASE projeto_luck_games;

USE projeto_luck_games;

CREATE TABLE clientes(
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(20),
    CPF VARCHAR(14) NOT NULL
);


CREATE TABLE aparelhos(
    id_aparelho INT PRIMARY KEY AUTO_INCREMENT,
    marca VARCHAR (100) NOT NULL,
    tipo VARCHAR (100) NOT NULL,
    num_serie VARCHAR (100) NOT NULL,
    modelo VARCHAR (100),
    data_entrada DATETIME,
    descricao_problema TEXT,
    fk_id_cliente INT,
    FOREIGN KEY (fk_id_cliente) REFERENCES clientes(id_cliente)
);

CREATE TABLE funcionarios(
    id_funcionario INT PRIMARY KEY AUTO_INCREMENT,
    nome_funcionario VARCHAR (100) NOT NULL,
    cargo VARCHAR (100), 
    telefone VARCHAR(20) NOT NULL,
    tipo_acesso VARCHAR (100) NOT NULL,
    senha VARCHAR(30) NOT NULL
);


CREATE TABLE ordens (
id_ordem INT PRIMARY KEY AUTO_INCREMENT,
aprovacao_orcamento VARCHAR (100),
valor DECIMAL (7, 2),
data_ordem DATETIME,
fk_id_cliente INT,
fk_id_aparelho INT,
fk_id_funcionarios INT,
FOREIGN KEY (fk_id_cliente) REFERENCES clientes (id_cliente),
FOREIGN KEY (fk_id_aparelho) REFERENCES aparelhos (id_aparelho),
FOREIGN KEY (fk_id_funcionarios) REFERENCES funcionarios (id_funcionario)
);

CREATE TABLE produtos(
id_produto int 	PRIMARY KEY AUTO_INCREMENT,
nome_produto VARCHAR (100),
categoria VARCHAR (50),
quantidade int
);

CREATE TABLE itens_ordem(
id_itens_ordem INT PRIMARY KEY AUTO_INCREMENT,
quantidade INT,
valor_unitario DECIMAL (6, 2),
fk_id_ordem int,
fk_id_produtos int,
FOREIGN KEY (fk_id_ordem) REFERENCES ordens (id_ordem),
FOREIGN KEY (fk_id_produtos) REFERENCES produtos (id_produto)
);

CREATE TABLE movimentacao(
id_movimentcao int PRIMARY KEY AUTO_INCREMENT,
tipo_movimentacao VARCHAR (50),
fk_id_produtos INT,
FOREIGN KEY (fk_id_produtos) REFERENCES produtos (id_produto)
);

INSERT INTO clientes (nome, telefone, CPF) VALUES
('João Silva', '11999990001', '111.111.111-01'),
('Maria Oliveira', '11999990002', '111.111.111-02'),
('Carlos Pereira', '11999990003', '111.111.111-03'),
('Ana Souza', '11999990004', '111.111.111-04'),
('Lucas Lima', '11999990005', '111.111.111-05'),
('Fernanda Alves', '11999990006', '111.111.111-06'),
('Rafael Costa', '11999990007', '111.111.111-07'),
('Juliana Rocha', '11999990008', '111.111.111-08'),
('Bruno Martins', '11999990009', '111.111.111-09'),
('Patrícia Gomes', '11999990010', '111.111.111-10');

INSERT INTO funcionarios (nome_funcionario, cargo, telefone, tipo_acesso, senha) VALUES
('Pedro Santos', 'Atendente', '11988880001', 'basico', '123'),
('Marcos Silva', 'Técnico', '11988880002', 'tecnico', '123'),
('Renato Lima', 'Técnico', '11988880003', 'tecnico', '123'),
('Camila Rocha', 'Atendente', '11988880004', 'basico', '123'),
('Roberto Alves', 'Administrador', '11988880005', 'admin', '123'),
('Daniel Costa', 'Técnico', '11988880006', 'tecnico', '123'),
('Paula Borges', 'Atendente', '11988880007', 'basico', '123'),
('André Martins', 'Supervisor', '11988880008', 'admin', '123'),
('Bianca Faria', 'Atendente', '11988880009', 'basico', '123'),
('Eduardo Pires', 'Técnico', '11988880010', 'tecnico', '123');

INSERT INTO produtos (nome_produto, categoria, quantidade) VALUES
('Controle PS4', 'Acessórios', 15),
('Fonte Xbox One', 'Componentes', 8),
('HD 1TB', 'Armazenamento', 10),
('Cooler Interno', 'Refrigeração', 12),
('Cabo HDMI', 'Cabos', 30),
('Joystick Genérico', 'Acessórios', 20),
('Fonte Nintendo Switch', 'Componentes', 6),
('Leitor de Disco', 'Componentes', 5),
('SSD 512GB', 'Armazenamento', 7),
('Placa Wireless', 'Componentes', 9);

INSERT INTO aparelhos
(marca, tipo, num_serie, modelo, data_entrada, descricao_problema, fk_id_cliente) VALUES
('Sony', 'Console', 'SN001', 'PS4', '2026-03-01 10:00:00', 'Não liga', 1),
('Microsoft', 'Console', 'SN002', 'Xbox One', '2026-03-02 10:00:00', 'Superaquecimento', 2),
('Nintendo', 'Console', 'SN003', 'Switch', '2026-03-03 10:00:00', 'Tela quebrada', 3),
('Sony', 'Console', 'SN004', 'PS5', '2026-03-04 10:00:00', 'Erro no sistema', 4),
('Microsoft', 'Console', 'SN005', 'Xbox Series S', '2026-03-05 10:00:00', 'Não reconhece controle', 5),
('Sony', 'Console', 'SN006', 'PS4 Slim', '2026-03-06 10:00:00', 'Sem vídeo', 6),
('Nintendo', 'Console', 'SN007', 'Switch Lite', '2026-03-07 10:00:00', 'Bateria não carrega', 7),
('Sony', 'Console', 'SN008', 'PS3', '2026-03-08 10:00:00', 'Não lê disco', 8),
('Microsoft', 'Console', 'SN009', 'Xbox 360', '2026-03-09 10:00:00', 'Luz vermelha', 9),
('Sony', 'Console', 'SN010', 'PS4 Pro', '2026-03-10 10:00:00', 'Travando', 10);

INSERT INTO ordens
(aprovacao_orcamento, valor, data_ordem, fk_id_cliente, fk_id_aparelho, fk_id_funcionarios) VALUES
('Aprovado', 300.00, '2026-03-11 14:00:00', 1, 1, 2),
('Pendente', 450.00, '2026-03-12 14:00:00', 2, 2, 3),
('Aprovado', 200.00, '2026-03-13 14:00:00', 3, 3, 6),
('Aprovado', 600.00, '2026-03-14 14:00:00', 4, 4, 10),
('Pendente', 350.00, '2026-03-15 14:00:00', 5, 5, 2),
('Aprovado', 250.00, '2026-03-16 14:00:00', 6, 6, 6),
('Aprovado', 400.00, '2026-03-17 14:00:00', 7, 7, 3),
('Pendente', 150.00, '2026-03-18 14:00:00', 8, 8, 10),
('Aprovado', 500.00, '2026-03-19 14:00:00', 9, 9, 2),
('Aprovado', 280.00, '2026-03-20 14:00:00', 10, 10, 6);

INSERT INTO itens_ordem
(quantidade, valor_unitario, fk_id_ordem, fk_id_produtos) VALUES
(1, 150.00, 1, 1),
(2, 50.00, 2, 5),
(1, 200.00, 3, 3),
(1, 300.00, 4, 8),
(1, 100.00, 5, 6),
(1, 250.00, 6, 9),
(2, 80.00, 7, 4),
(1, 150.00, 8, 2),
(1, 200.00, 9, 7),
(1, 180.00, 10, 10);

INSERT INTO movimentacao (tipo_movimentacao, fk_id_produtos) VALUES
('Saída', 1),
('Saída', 2),
('Saída', 3),
('Entrada', 4),
('Saída', 5),
('Entrada', 6),
('Saída', 7),
('Saída', 8),
('Entrada', 9),
('Saída', 10);


DROP DATABASE projeto_luck_games;

