CREATE DATABASE projeto_luck_games;
USE projeto_luck_games;

CREATE TABLE cargo (
    id_cargo INT PRIMARY KEY AUTO_INCREMENT,
    nome_cargo VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE nivel_acesso (
    id_acesso INT PRIMARY KEY AUTO_INCREMENT,
    nome_nivel ENUM('basico', 'tecnico', 'admin') NOT NULL UNIQUE
);


CREATE TABLE pergunta_seguranca (
    id_pergunta INT PRIMARY KEY AUTO_INCREMENT,
    texto_pergunta VARCHAR(150) NOT NULL
);


CREATE TABLE funcionario (
    id_funcionario INT PRIMARY KEY AUTO_INCREMENT,
    nome_funcionario VARCHAR(100) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    senha VARCHAR(255) NOT NULL,
    resposta_secreta VARCHAR(255) NOT NULL,

    fk_id_cargo_funcionario INT NOT NULL,
    fk_id_acesso_funcionario INT NOT NULL,
    fk_id_pergunta_funcionario INT NOT NULL,

    FOREIGN KEY (fk_id_cargo_funcionario)
        REFERENCES cargo(id_cargo),

    FOREIGN KEY (fk_id_acesso_funcionario)
        REFERENCES nivel_acesso(id_acesso),

    FOREIGN KEY (fk_id_pergunta_funcionario)
        REFERENCES pergunta_seguranca(id_pergunta)
);


CREATE TABLE cliente (
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(20),
    CPF VARCHAR(14) NOT NULL UNIQUE
);


CREATE TABLE aparelho (
    id_aparelho INT PRIMARY KEY AUTO_INCREMENT,
    marca VARCHAR(100) NOT NULL,
    tipo VARCHAR(100) NOT NULL,
    num_serie VARCHAR(100) UNIQUE,
    modelo VARCHAR(100),
    data_entrada DATETIME NOT NULL,
    estado VARCHAR(100) NOT NULL,
    descricao_problema TEXT,

    fk_id_cliente_aparelho INT NOT NULL,

    FOREIGN KEY (fk_id_cliente_aparelho)
        REFERENCES cliente(id_cliente)
);


CREATE TABLE ordem (
    id_ordem INT PRIMARY KEY AUTO_INCREMENT,

    aprovacao_orcamento ENUM(
        'pendente',
        'aprovado',
        'recusado'
    ) DEFAULT 'pendente',

    valor DECIMAL(10,2) NOT NULL,
    data_ordem DATETIME NOT NULL,

    fk_id_cliente_ordem INT NOT NULL,
    fk_id_aparelho_ordem INT NOT NULL,
    fk_id_funcionario_ordem INT NOT NULL,

    FOREIGN KEY (fk_id_cliente_ordem)
        REFERENCES cliente(id_cliente),

    FOREIGN KEY (fk_id_aparelho_ordem)
        REFERENCES aparelho(id_aparelho),

    FOREIGN KEY (fk_id_funcionario_ordem)
        REFERENCES funcionario(id_funcionario)
);


CREATE TABLE produto (
    id_produto INT PRIMARY KEY AUTO_INCREMENT,

    nome_produto VARCHAR(100) NOT NULL,
    quantidade_minima INT NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    quantidade_total INT NOT NULL,
    valor_unitario DECIMAL(10,2) NOT NULL
);


CREATE TABLE item_ordem (
    id_itens_ordem INT PRIMARY KEY AUTO_INCREMENT,

    quantidade INT NOT NULL,
    valor_unitario DECIMAL(10,2) NOT NULL,

    fk_id_ordem INT NOT NULL,
    fk_id_produto INT NOT NULL,

    FOREIGN KEY (fk_id_ordem)
        REFERENCES ordem(id_ordem),

    FOREIGN KEY (fk_id_produto)
        REFERENCES produto(id_produto)
);


CREATE TABLE movimentacao (
    id_movimentacao INT PRIMARY KEY AUTO_INCREMENT,

    tipo_movimentacao ENUM(
        'entrada',
        'saida',
        'ajuste'
    ) NOT NULL,

    quantidade INT NOT NULL,
    motivo TEXT,

    fk_id_produto_movimentacao INT NOT NULL,

    data_movimentacao DATETIME NOT NULL,

    FOREIGN KEY (fk_id_produto_movimentacao)
        REFERENCES produto(id_produto)
);


INSERT INTO cargo (nome_cargo)
VALUES
('Técnico(a)'),
('Estoquista'),
('Atendente'),
('Proprietário(a)');

INSERT INTO nivel_acesso (nome_nivel)
VALUES
('basico'),
('tecnico'),
('admin');

INSERT INTO pergunta_seguranca (texto_pergunta)
VALUES
('Qual é o nome da sua primeira escola?'),
('Qual é o nome do seu primeiro pet?'),
('Em que cidade sua mãe nasceu?');


DELIMITER $


CREATE TRIGGER valida_estoque
BEFORE INSERT
ON item_ordem
FOR EACH ROW
BEGIN

    DECLARE estoque_atual INT;

    SELECT quantidade_total
    INTO estoque_atual
    FROM produto
    WHERE id_produto = NEW.fk_id_produto;

    IF estoque_atual < NEW.quantidade THEN

        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Estoque insuficiente';

    END IF;

END$


CREATE TRIGGER saida_item_estoque
AFTER INSERT
ON item_ordem
FOR EACH ROW
BEGIN

    UPDATE produto
    SET quantidade_total = quantidade_total - NEW.quantidade
    WHERE id_produto = NEW.fk_id_produto;

    INSERT INTO movimentacao
    (
        tipo_movimentacao,
        quantidade,
        motivo,
        fk_id_produto_movimentacao,
        data_movimentacao
    )
    VALUES
    (
        'saida',
        'Item adicionado em Ordem de Serviço',
        NEW.quantidade,
        NEW.fk_id_produto,
        NOW()
    );

END$


CREATE TRIGGER entrada_item_estoque
AFTER DELETE
ON item_ordem
FOR EACH ROW
BEGIN

    UPDATE produto
    SET quantidade_total = quantidade_total + OLD.quantidade
    WHERE id_produto = OLD.fk_id_produto;

    INSERT INTO movimentacao
    (
        tipo_movimentacao,
        quantidade,
        fk_id_produto_movimentacao,
        data_movimentacao
    )
    VALUES
    (
        'entrada',
        'Item retirado de Ordem de Serviço',
        OLD.quantidade,
        OLD.fk_id_produto,
        NOW()
    );

END$


CREATE TRIGGER atualiza_estoque_item_ordem
AFTER UPDATE
ON item_ordem
FOR EACH ROW
BEGIN

   

    UPDATE produto
    SET quantidade_total = quantidade_total + OLD.quantidade
    WHERE id_produto = OLD.fk_id_produto;

    

    UPDATE produto
    SET quantidade_total = quantidade_total - NEW.quantidade
    WHERE id_produto = NEW.fk_id_produto;

    

    INSERT INTO movimentacao
    (
        tipo_movimentacao,
        quantidade,
        motivo,
        fk_id_produto_movimentacao,
        data_movimentacao
    )
    VALUES
    (
        'ajuste',
        'ajuste',
        NEW.quantidade,
        NEW.fk_id_produto,
        NOW()
    );

END$

DELIMITER ;
