select p.name, c.name from relations as r
full join products as p on p.id = r.product_id
full join categories as c on c.id = r.category_id;