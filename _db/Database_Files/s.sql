CREATE TABLE compras (id_compras int not null primary key,
    id_cliente int,
    produto nvarchar(50),
    quantidade int,
    preco_unidade int,
    atualizacao datetime,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE)

INSERT INTO tb_product ( id_shop, id_lang, description, description_short, meta_description, meta_keywords, meta_title, name, available_now, available_later )
SELECT ps_product.*,
         cs_product_lang_br.id_shop,
         cs_product_lang_br.id_lang,
         cs_product_lang_br.description,
         cs_product_lang_br.description_short,
         cs_product_lang_br.meta_description,
         cs_product_lang_br.meta_keywords,
         cs_product_lang_br.meta_title,
         cs_product_lang_br.name,
         cs_product_lang_br.available_now,
         cs_product_lang_br.available_later
FROM cs_product_lang_br
INNER JOIN ps_product
    ON cs_product_lang_br.id_product = ps_product.id_product; 